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

    public partial class TaskList : Form
    {
        private List<Task> listaZadan; // Lista obiektów zadania
        private int userIndex = Home.userIndex; // logged in user
        private string userName = Home.userName; // logged user name
        public TaskList()
        {
            InitializeComponent();
            listaZadan = ConnectDb.getTasks(userIndex, userName, 0);
            taskAmountLabel.Text = $"Current task amount: {ConnectDb.getTaskAmount(userIndex)}";
            GenerujZadania();
            tasksDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void GenerujZadania()
        {
            tasksDataGridView.AutoGenerateColumns = false;
            tasksDataGridView.Columns.Clear();
            tasksDataGridView.RowTemplate.Height = 30;

            // Tworzenie kolumn dla poszczególnych właściwości zadania
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.HeaderText = "Description";
            descriptionColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Deadline";
            dateColumn.HeaderText = "Deadline";
            dateColumn.Name = "Deadline";

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Name = "Edit";

            DataGridViewButtonColumn doneColumn = new DataGridViewButtonColumn();
            doneColumn.HeaderText = "Done";
            doneColumn.Text = "Done";
            doneColumn.UseColumnTextForButtonValue = true;
            doneColumn.Name = "Done";

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn(); // in case delete was needed
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Name = "Delete";

            // Dodawanie kolumn do DataGridView
            tasksDataGridView.Columns.Add(nameColumn);
            tasksDataGridView.Columns.Add(descriptionColumn);
            tasksDataGridView.Columns.Add(dateColumn);
            tasksDataGridView.Columns.Add(editColumn);
            tasksDataGridView.Columns.Add(doneColumn);
            tasksDataGridView.Columns.Add(deleteColumn);

            editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            doneColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            if (userName == "admin")
            {
                DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn();
                userIdColumn.DataPropertyName = "user_id";
                userIdColumn.HeaderText = "user_id";
                tasksDataGridView.Columns.Add(userIdColumn);
                userIdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            tasksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tasksDataGridView.CellContentClick += DataGridView_CellContentClick;

            // Przypisanie źródła danych
            tasksDataGridView.DataSource = listaZadan;
        }
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tasksDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                ConnectDb.removeTask(listaZadan[rowIndex].Id);
                ConnectDb.updateTaskAmount(userIndex, -1);          
                taskAmountLabel.Text = $"Current task amount: {ConnectDb.getTaskAmount(userIndex)}";
                listaZadan.RemoveAt(rowIndex);
                tasksDataGridView.DataSource = null;
                tasksDataGridView.DataSource = listaZadan;
            }
            else if (e.ColumnIndex == tasksDataGridView.Columns["Done"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                //modify database data
                ConnectDb.taskIsDone(listaZadan[rowIndex].Id);
                ConnectDb.updateTaskAmount(userIndex, -1);
                ConnectDb.updateDoneTaskAmount(userIndex);

                //update view
                taskAmountLabel.Text = $"Current task amount: {ConnectDb.getTaskAmount(userIndex)}";
                listaZadan.RemoveAt(rowIndex);
                tasksDataGridView.DataSource = null;
                tasksDataGridView.DataSource = listaZadan;
            }
            else if (e.ColumnIndex == tasksDataGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                ConnectDb.removeTask(listaZadan[rowIndex].Id); // remove from database in order to save newer version ( I know, someone might want to leave this field without saving changes, world needs decided people ok)
                ConnectDb.updateTaskAmount(userIndex, -1);
                Home.homeInstance.OpenChildForm(new Forms.AddTask());
                AddTask.nameTb.Text = listaZadan[e.RowIndex].Name;
                AddTask.descTb.Text = listaZadan[e.RowIndex].Description;
                AddTask.deadDT.Value = listaZadan[e.RowIndex].Deadline;
                //

                //DateTime dt; bool xd;
                //var isValidDate = DateTime.TryParse(listaZadan[e.RowIndex].Deadline.Date.ToString(), out dt);

                //if (isValidDate)
                //    MessageBox.Show(dt.ToString());
                //else
                //    MessageBox.Show("It's not a valid date string");

            }
        }

        private void tasksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tasksDataGridView.Columns["Deadline"].Index)
            {
                if (e.Value != null)
                {
                    DateTime deadline = (DateTime)e.Value;
                    DateTime currentDate = DateTime.Now.Date;

                    // Porównanie daty z bieżącą datą
                    int daysDifference = (deadline.Date - currentDate).Days;

                    // Ustawienie koloru tekstu w zależności od różnicy dni
                    if (daysDifference == 2)
                    {
                        e.CellStyle.ForeColor = Color.Gold;
                    }
                    else if (daysDifference == 1)
                    {
                        e.CellStyle.ForeColor = Color.Orange;
                    }
                    else if (daysDifference < 1)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }
    }

}
