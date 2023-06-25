namespace Task_Management.Forms
{
    partial class AddTask
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
            components = new System.ComponentModel.Container();
            nameTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            descriptionTextBox = new TextBox();
            addTaskButton = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            deadlineDay = new DateTimePicker();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(159, 5);
            nameTextBox.Margin = new Padding(3, 0, 3, 0);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Enter task name";
            nameTextBox.Size = new Size(314, 23);
            nameTextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(159, 31);
            descriptionTextBox.Margin = new Padding(3, 0, 3, 0);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Enter Task Description";
            descriptionTextBox.Size = new Size(314, 191);
            descriptionTextBox.TabIndex = 4;
            // 
            // addTaskButton
            // 
            addTaskButton.Anchor = AnchorStyles.Bottom;
            addTaskButton.Location = new Point(180, 253);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(266, 35);
            addTaskButton.TabIndex = 6;
            addTaskButton.Text = "Add Task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // deadlineDay
            // 
            deadlineDay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deadlineDay.CustomFormat = "dd.mm.yyyy hh:mm:ss";
            deadlineDay.Format = DateTimePickerFormat.Short;
            deadlineDay.Location = new Point(233, 224);
            deadlineDay.Margin = new Padding(0, 3, 3, 3);
            deadlineDay.Name = "deadlineDay";
            deadlineDay.Size = new Size(160, 23);
            deadlineDay.TabIndex = 8;
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 317);
            Controls.Add(deadlineDay);
            Controls.Add(addTaskButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Name = "AddTask";
            Text = "AddTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox descriptionTextBox;
        private Button addTaskButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DateTimePicker deadlineDay;
    }
}