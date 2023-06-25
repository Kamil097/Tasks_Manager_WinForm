namespace Task_Management
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            logInButton = new Button();
            registerButton = new Button();
            logOutButton = new Button();
            addTaskButton = new Button();
            doneTaskList = new Button();
            userListButton = new Button();
            taskListButton = new Button();
            logoPanel = new Panel();
            label1 = new Label();
            titleBarPanel = new Panel();
            lblTitle = new Label();
            mainPanel = new Panel();
            panelMenu.SuspendLayout();
            logoPanel.SuspendLayout();
            titleBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(logInButton);
            panelMenu.Controls.Add(registerButton);
            panelMenu.Controls.Add(logOutButton);
            panelMenu.Controls.Add(addTaskButton);
            panelMenu.Controls.Add(doneTaskList);
            panelMenu.Controls.Add(userListButton);
            panelMenu.Controls.Add(taskListButton);
            panelMenu.Controls.Add(logoPanel);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 489);
            panelMenu.TabIndex = 0;
            // 
            // logInButton
            // 
            logInButton.Dock = DockStyle.Top;
            logInButton.FlatAppearance.BorderSize = 0;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.ForeColor = SystemColors.Control;
            logInButton.Location = new Point(0, 440);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(220, 60);
            logInButton.TabIndex = 10;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // registerButton
            // 
            registerButton.Dock = DockStyle.Top;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = SystemColors.Control;
            registerButton.Location = new Point(0, 380);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(220, 60);
            registerButton.TabIndex = 9;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Dock = DockStyle.Top;
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.ForeColor = SystemColors.Control;
            logOutButton.Location = new Point(0, 320);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(220, 60);
            logOutButton.TabIndex = 8;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // addTaskButton
            // 
            addTaskButton.Dock = DockStyle.Top;
            addTaskButton.FlatAppearance.BorderSize = 0;
            addTaskButton.FlatStyle = FlatStyle.Flat;
            addTaskButton.ForeColor = SystemColors.Control;
            addTaskButton.Location = new Point(0, 260);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(220, 60);
            addTaskButton.TabIndex = 7;
            addTaskButton.Text = "Add Task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // doneTaskList
            // 
            doneTaskList.Dock = DockStyle.Top;
            doneTaskList.FlatAppearance.BorderSize = 0;
            doneTaskList.FlatStyle = FlatStyle.Flat;
            doneTaskList.ForeColor = SystemColors.Control;
            doneTaskList.Location = new Point(0, 200);
            doneTaskList.Name = "doneTaskList";
            doneTaskList.Size = new Size(220, 60);
            doneTaskList.TabIndex = 6;
            doneTaskList.Text = "Done Tasks";
            doneTaskList.UseVisualStyleBackColor = true;
            doneTaskList.Click += doneTaskList_Click;
            // 
            // userListButton
            // 
            userListButton.Dock = DockStyle.Top;
            userListButton.FlatAppearance.BorderSize = 0;
            userListButton.FlatStyle = FlatStyle.Flat;
            userListButton.ForeColor = SystemColors.Control;
            userListButton.Location = new Point(0, 140);
            userListButton.Name = "userListButton";
            userListButton.Size = new Size(220, 60);
            userListButton.TabIndex = 3;
            userListButton.Text = "User List";
            userListButton.UseVisualStyleBackColor = true;
            userListButton.Click += userListButton_Click;
            // 
            // taskListButton
            // 
            taskListButton.Dock = DockStyle.Top;
            taskListButton.FlatAppearance.BorderSize = 0;
            taskListButton.FlatStyle = FlatStyle.Flat;
            taskListButton.ForeColor = SystemColors.Control;
            taskListButton.Location = new Point(0, 80);
            taskListButton.Name = "taskListButton";
            taskListButton.Size = new Size(220, 60);
            taskListButton.TabIndex = 2;
            taskListButton.Text = "Task List";
            taskListButton.UseVisualStyleBackColor = true;
            taskListButton.Click += taskListButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.FromArgb(39, 39, 58);
            logoPanel.Controls.Add(label1);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(220, 80);
            logoPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(59, 28);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Task Manager";
            // 
            // titleBarPanel
            // 
            titleBarPanel.BackColor = Color.FromArgb(0, 150, 136);
            titleBarPanel.Controls.Add(lblTitle);
            titleBarPanel.Dock = DockStyle.Top;
            titleBarPanel.ForeColor = SystemColors.ControlLightLight;
            titleBarPanel.Location = new Point(220, 0);
            titleBarPanel.Name = "titleBarPanel";
            titleBarPanel.Size = new Size(671, 80);
            titleBarPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(303, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home";
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(220, 80);
            mainPanel.MinimumSize = new Size(670, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(671, 409);
            mainPanel.TabIndex = 9;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 489);
            Controls.Add(mainPanel);
            Controls.Add(titleBarPanel);
            Controls.Add(panelMenu);
            Name = "Home";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            titleBarPanel.ResumeLayout(false);
            titleBarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button userListButton;
        private Button taskListButton;
        private Panel logoPanel;
        private Panel titleBarPanel;
        private Label lblTitle;
        private Label label1;
        private Panel mainPanel;
        private Button doneTaskList;
        private Button logOutButton;
        private Button addTaskButton;
        private Button logInButton;
        private Button registerButton;
    }
}