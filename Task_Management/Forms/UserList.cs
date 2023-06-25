using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management.Forms
{
    public partial class UserList : Form
    {
        List<User> userList = new List<User>();
        public int userIndex = Home.userIndex; // logged in user
        public string userName = Home.userName; // name of user
        public UserList()
        {
            InitializeComponent();
            userList = ConnectDb.getUsers();
            getUserData();    
        }

        public void getUserData()
        {
            userDataGridView.AutoGenerateColumns = false;
            userDataGridView.Columns.Clear();

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";

            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.DataPropertyName = "Password";
            passwordColumn.HeaderText = "Password";

            DataGridViewTextBoxColumn tasksAmountColumn = new DataGridViewTextBoxColumn();
            tasksAmountColumn.DataPropertyName = "TasksAmount";
            tasksAmountColumn.HeaderText = "TasksAmount";

            DataGridViewTextBoxColumn doneTasksAmountColumn = new DataGridViewTextBoxColumn();
            doneTasksAmountColumn.DataPropertyName = "TasksDone";
            doneTasksAmountColumn.HeaderText = "TasksDone";

            userDataGridView.Columns.Add(nameColumn); 
            userDataGridView.Columns.Add(tasksAmountColumn);
            userDataGridView.Columns.Add(passwordColumn);
            userDataGridView.Columns.Add(doneTasksAmountColumn);


            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Przypisanie źródła danych
            userDataGridView.DataSource = userList;
        }
    }
}
