using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_Management.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Task_Management
{
    public static class ConnectDb
    {
        private static string mysqlCon = "Server=127.0.0.1; Uid=root; Database=taskmanager; Pwd=''";
        public static List<User> getUsers() 
        {
            List<User> userList = new List<User>();
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();

                string query = "SELECT id, name, password, taskamount, tasksDone FROM users";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string password = reader.GetString("password");
                    int taskamount = reader.GetInt32("taskamount");
                    int tasksDone = reader.GetInt32("tasksDone");
                    userList.Add(new User(id, name, password, taskamount,tasksDone));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return userList;
        }

        public static List<Task> getTasks(int userId,string userName, int isDone) 
        {
            List<Task> taskList = new List<Task>();
            string query = "";

            if (userName == "admin")
                query = $"SELECT id, name, description, deadline, user_id FROM tasks WHERE isDone = '{isDone}'";
            else
                query = $"SELECT id, name, description, deadline, user_id FROM tasks WHERE user_id = '{userId}' AND isDone = '{isDone}'";

            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open(); 
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string description = reader.GetString("description");
                    DateTime deadline = reader.GetDateTime("deadline");
                    int user_id = reader.GetInt32("user_id");   
                    taskList.Add(new Task(id,name, description, deadline,user_id));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return taskList;
        }
        public static int getTaskAmount(int userId) 
        {
            string query = $"SELECT taskamount FROM users WHERE id = '{userId}'";
            int taskamount = 0;
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    taskamount = reader.GetInt32("taskamount");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return taskamount;
        }
        public static int getDoneTaskAmount(int userId)
        {
            string query = $"SELECT tasksDone FROM users WHERE id = '{userId}'";
            int tasksDone = 0;
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tasksDone = reader.GetInt32("tasksDone");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return tasksDone;
        }
        public static int logIn(string givenName, string givenPassword) 
        {
            List<User> userList = getUsers();

            foreach (User user in userList)
            {
                if (user.Name == givenName)
                {
                    if (user.Password == givenPassword)
                        return user.Id;
                    else
                        return -1;
                }
            }
            return -1;
        }
        public static void addTask(string name, string description, DateTime deadline,int userId) 
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                using (mySqlConnection)
                {
                    string query = "INSERT INTO tasks (name, description, deadline, user_id, isDone) VALUES (@name, @description, @deadline, @user_id, @isDone)";

                    using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@deadline", deadline);
                        command.Parameters.AddWithValue("@user_id", userId);
                        command.Parameters.AddWithValue("@isDone", 0);

                        mySqlConnection.Open();
                        command.ExecuteNonQuery();
                        mySqlConnection.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        public static void updateTaskAmount(int userId,int value)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                string query = $"UPDATE users SET taskamount = taskamount + {value} WHERE id = @userId";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@userId", userId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        public static void updateDoneTaskAmount(int userId)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                string query = $"UPDATE users SET tasksDone = tasksDone + 1 WHERE id = @userId";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@userId", userId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        public static void removeTask(int taskId)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();

                string query = "DELETE FROM tasks WHERE id = @taskId";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@taskId", taskId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        public static void taskIsDone(int taskId) 
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                string query = $"UPDATE tasks SET isDone = 1 WHERE id = @taskId";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@taskId", taskId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        public static bool Register(string newName, string password)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();

                string query = "SELECT COUNT(*) FROM users WHERE UPPER(name) = @newName";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                command.Parameters.AddWithValue("@newName", newName.ToUpper());
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Name already exists in database.");
                    return false;
                }
                else
                {
                    query = "INSERT INTO users (name, password, taskamount, tasksDone) VALUES (@newName, @password, 0, 0)";
                    command = new MySqlCommand(query, mySqlConnection);
                    command.Parameters.AddWithValue("@newName", newName);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }
}
