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
    public partial class DoneTaskList : Form
    {
        public DoneTaskList()
        {
            InitializeComponent();
            listaZadan = ConnectDb.getTasks(userIndex, userName, 1);
            doneTaskAmountLabel.Text = $"Amount of tasks done: {ConnectDb.getDoneTaskAmount(userIndex)}";
            GenerujZadania();
            doneTasksDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private List<Task> listaZadan; // Lista obiektów zadania
        private int userIndex = Home.userIndex; // logged in user
        private string userName = Home.userName; // logged user name
        private void GenerujZadania()
        {
            doneTasksDataGridView.AutoGenerateColumns = false;
            doneTasksDataGridView.Columns.Clear();

            // Tworzenie kolumn dla poszczególnych właściwości zadania
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.HeaderText = "Description";
            descriptionColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            //DataGridViewTextBoxColumn deadlineColumn = new DataGridViewTextBoxColumn();
            //deadlineColumn.DataPropertyName = "Deadline";
            //deadlineColumn.HeaderText = "Deadline";



            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Name = "Delete";

            // Dodawanie kolumn do DataGridView
            doneTasksDataGridView.Columns.Add(nameColumn);
            doneTasksDataGridView.Columns.Add(descriptionColumn);
            //doneTasksDataGridView.Columns.Add(deadlineColumn);
            doneTasksDataGridView.Columns.Add(deleteColumn);

            if (userName == "admin")
            {
                DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn();
                userIdColumn.DataPropertyName = "user_id";
                userIdColumn.HeaderText = "user_id";
                doneTasksDataGridView.Columns.Add(userIdColumn);
            }

            doneTasksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doneTasksDataGridView.CellContentClick += DataGridView_CellContentClick;

            // Przypisanie źródła danych
            doneTasksDataGridView.DataSource = listaZadan;
        }
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == doneTasksDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                ConnectDb.removeTask(listaZadan[rowIndex].Id);
                listaZadan.RemoveAt(rowIndex);
                doneTasksDataGridView.DataSource = null;
                doneTasksDataGridView.DataSource = listaZadan;
            }
            //else if (e.ColumnIndex == doneTasksDataGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            //{
            //    int rowIndex = e.RowIndex;
            //    ConnectDb.removeTask(listaZadan[rowIndex].Id); // remove from database
            //    Home.homeInstance.OpenChildForm(new Forms.AddTask());
            //    AddTask.nameTb.Text = listaZadan[e.RowIndex].Name;
            //    AddTask.descTb.Text = listaZadan[e.RowIndex].Description;
            //    AddTask.deadDT = listaZadan[e.RowIndex].Deadline;
            //}
        }
    }
}
