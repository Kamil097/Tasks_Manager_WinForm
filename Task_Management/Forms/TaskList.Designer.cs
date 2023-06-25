namespace Task_Management.Forms
{
    partial class TaskList
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
            tasksDataGridView = new DataGridView();
            taskAmountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)tasksDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tasksDataGridView
            // 
            tasksDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tasksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasksDataGridView.Location = new Point(21, 12);
            tasksDataGridView.Name = "tasksDataGridView";
            tasksDataGridView.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tasksDataGridView.RowTemplate.Height = 25;
            tasksDataGridView.RowTemplate.Resizable = DataGridViewTriState.True;
            tasksDataGridView.Size = new Size(767, 378);
            tasksDataGridView.TabIndex = 0;
            tasksDataGridView.CellFormatting += tasksDataGridView_CellFormatting;
            // 
            // taskAmountLabel
            // 
            taskAmountLabel.Anchor = AnchorStyles.Bottom;
            taskAmountLabel.AutoSize = true;
            taskAmountLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            taskAmountLabel.Location = new Point(301, 408);
            taskAmountLabel.Name = "taskAmountLabel";
            taskAmountLabel.Size = new Size(213, 19);
            taskAmountLabel.TabIndex = 1;
            taskAmountLabel.Text = "Current amount of tasks:";
            // 
            // TaskList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(taskAmountLabel);
            Controls.Add(tasksDataGridView);
            Name = "TaskList";
            Text = "TaskList";
            ((System.ComponentModel.ISupportInitialize)tasksDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tasksDataGridView;
        private Label taskAmountLabel;
    }
}