namespace Task_Management.Forms
{
    partial class DoneTaskList
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
            doneTasksDataGridView = new DataGridView();
            doneTaskAmountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)doneTasksDataGridView).BeginInit();
            SuspendLayout();
            // 
            // doneTasksDataGridView
            // 
            doneTasksDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            doneTasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doneTasksDataGridView.Location = new Point(21, 12);
            doneTasksDataGridView.Name = "doneTasksDataGridView";
            doneTasksDataGridView.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            doneTasksDataGridView.RowTemplate.Height = 25;
            doneTasksDataGridView.RowTemplate.Resizable = DataGridViewTriState.True;
            doneTasksDataGridView.Size = new Size(767, 378);
            doneTasksDataGridView.TabIndex = 1;
            // 
            // doneTaskAmountLabel
            // 
            doneTaskAmountLabel.Anchor = AnchorStyles.Bottom;
            doneTaskAmountLabel.AutoSize = true;
            doneTaskAmountLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            doneTaskAmountLabel.Location = new Point(301, 408);
            doneTaskAmountLabel.Name = "doneTaskAmountLabel";
            doneTaskAmountLabel.Size = new Size(193, 19);
            doneTaskAmountLabel.TabIndex = 2;
            doneTaskAmountLabel.Text = "Done amount of tasks:";
            // 
            // DoneTaskList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(doneTaskAmountLabel);
            Controls.Add(doneTasksDataGridView);
            Name = "DoneTaskList";
            Text = "DoneTaskList";
            ((System.ComponentModel.ISupportInitialize)doneTasksDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView doneTasksDataGridView;
        private Label doneTaskAmountLabel;
    }
}