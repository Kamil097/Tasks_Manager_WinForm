using Task_Management.Forms;

namespace Task_Management
{
    public partial class Home : Form
    {
        private Form activeForm;

        public static Home homeInstance;
        public static bool isLogged { get; set; } = false;
        public static int userIndex { get; set; } = -1;
        public static string userName { get; set; } = "default";

        public Home()
        {
            InitializeComponent();
            homeInstance = this;

            OpenChildForm(new Forms.LogIn());
            RefreshForm();
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(childForm);
            this.mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void hideButtons()
        {
            logInButton.Hide();
            addTaskButton.Hide();
            taskListButton.Hide();
            userListButton.Hide();
            logOutButton.Hide();
            doneTaskList.Hide();
        }
        private void showButtons()
        {

            logOutButton.Show();
            addTaskButton.Show();
            doneTaskList.Show();
            taskListButton.Show();

            if (userName == "admin")
                userListButton.Show();
        } // additionally we set order of buttons
        public void RefreshForm()
        {
            if (isLogged)
            {
                logInButton.Hide();
                registerButton.Hide();
                showButtons();
                OpenChildForm(new Forms.TaskList());
            }
            else
            {
                hideButtons();
                registerButton.Show();
            }
        }


        private void taskListButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TaskList());
        }

        private void userListButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserList());
        }
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AddTask());
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            logInButton.Show();
            registerButton.Hide();
            OpenChildForm(new Forms.Register());
        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            logInButton.Hide();
            registerButton.Show();
            OpenChildForm(new Forms.LogIn());
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            isLogged = false;
            userIndex = -1;
            OpenChildForm(new Forms.LogIn());
            RefreshForm();
            MessageBox.Show("Successfully logged out.");
        }

        private void doneTaskList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DoneTaskList());
        }

    }
}