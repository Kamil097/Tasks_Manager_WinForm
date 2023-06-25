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
    public partial class AddTask : Form
    {
        public int userIndex = Home.userIndex; // logged in user
        public static TextBox nameTb;
        public static TextBox descTb;
        public static DateTimePicker deadDT;
        public AddTask()
        {
            InitializeComponent();
            nameTb = nameTextBox;
            descTb = descriptionTextBox;
            deadDT = deadlineDay;
        }
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (deadlineDay.Value <= DateTime.Now.Date)
            {
                MessageBox.Show("Date unavailable");
            }
            else
            {
                foreach (TextBox tb in Controls.OfType<TextBox>()) // check if all boxes are filled
                {
                    if (string.IsNullOrEmpty(tb.Text.Trim()))
                    {
                        MessageBox.Show($"Text box {tb.Name} can't be empty");
                        break;
                    }
                }
                ConnectDb.addTask(nameTextBox.Text, descriptionTextBox.Text, deadlineDay.Value, userIndex);
                ConnectDb.updateTaskAmount(userIndex, 1);
                Home.homeInstance.OpenChildForm(new Forms.TaskList());
            }

        }
    }
}
