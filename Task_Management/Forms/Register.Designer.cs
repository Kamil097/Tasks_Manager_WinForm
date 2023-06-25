namespace Task_Management.Forms
{
    partial class Register
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
            passwordRegTextBox = new TextBox();
            registerButton = new Button();
            nameRegTextBox = new TextBox();
            confPasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // passwordRegTextBox
            // 
            passwordRegTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordRegTextBox.Location = new Point(222, 157);
            passwordRegTextBox.Margin = new Padding(3, 0, 3, 0);
            passwordRegTextBox.Name = "passwordRegTextBox";
            passwordRegTextBox.PlaceholderText = "Password";
            passwordRegTextBox.Size = new Size(375, 23);
            passwordRegTextBox.TabIndex = 2;
            passwordRegTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerButton.Location = new Point(255, 277);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(287, 44);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // nameRegTextBox
            // 
            nameRegTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameRegTextBox.Location = new Point(222, 113);
            nameRegTextBox.Margin = new Padding(3, 0, 3, 0);
            nameRegTextBox.Name = "nameRegTextBox";
            nameRegTextBox.PlaceholderText = "Username";
            nameRegTextBox.Size = new Size(375, 23);
            nameRegTextBox.TabIndex = 1;
            // 
            // confPasswordTextBox
            // 
            confPasswordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            confPasswordTextBox.Location = new Point(222, 206);
            confPasswordTextBox.Margin = new Padding(3, 0, 3, 0);
            confPasswordTextBox.Name = "confPasswordTextBox";
            confPasswordTextBox.PlaceholderText = "Confirm Password";
            confPasswordTextBox.Size = new Size(375, 23);
            confPasswordTextBox.TabIndex = 3;
            confPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(confPasswordTextBox);
            Controls.Add(passwordRegTextBox);
            Controls.Add(registerButton);
            Controls.Add(nameRegTextBox);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordRegTextBox;
        private Button registerButton;
        private TextBox nameRegTextBox;
        private TextBox confPasswordTextBox;
    }
}