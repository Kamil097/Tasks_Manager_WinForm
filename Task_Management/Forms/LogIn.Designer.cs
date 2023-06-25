namespace Task_Management.Forms
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logInButton = new Button();
            nameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // logInButton
            // 
            logInButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logInButton.Location = new Point(255, 225);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(287, 44);
            logInButton.TabIndex = 3;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(222, 113);
            nameTextBox.Margin = new Padding(3, 0, 3, 0);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Username";
            nameTextBox.Size = new Size(375, 23);
            nameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(222, 157);
            passwordTextBox.Margin = new Padding(3, 0, 3, 0);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(375, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(passwordTextBox);
            Controls.Add(logInButton);
            Controls.Add(nameTextBox);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button logInButton;
        private TextBox nameTextBox;
        private TextBox passwordTextBox;
    }
}