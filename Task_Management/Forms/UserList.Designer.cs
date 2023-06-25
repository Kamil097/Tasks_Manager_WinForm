namespace Task_Management.Forms
{
    partial class UserList
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
            userDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userDataGridView
            // 
            userDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(21, 12);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowTemplate.Height = 25;
            userDataGridView.Size = new Size(767, 426);
            userDataGridView.TabIndex = 0;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userDataGridView);
            Name = "UserList";
            Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userDataGridView;
    }
}