using MySqlX.XDevAPI.Common;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (passwordRegTextBox.Text == confPasswordTextBox.Text)
            {

                bool isAvailable = ConnectDb.Register(nameRegTextBox.Text, passwordRegTextBox.Text);

                if (isAvailable)
                {
                    MessageBox.Show("User has been added!");
                    Home.homeInstance.OpenChildForm(new Forms.LogIn());
                }
            }
            else
                MessageBox.Show("Passwords don't match!");
        }
    }
}
