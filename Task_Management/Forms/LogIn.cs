using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // podłączenie

namespace Task_Management.Forms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            int result = ConnectDb.logIn(nameTextBox.Text, passwordTextBox.Text);

            if (result >= 0)
            {
                MessageBox.Show($"{nameTextBox.Text} logged in!");
                Home.isLogged = true;
                Home.userIndex = result;
                Home.userName = nameTextBox.Text;
                Home.homeInstance.RefreshForm();
            }
            else
            {
                MessageBox.Show("Incorrect data");
            }

        }
    }

}
