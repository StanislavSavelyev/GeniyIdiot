namespace WinFormsApp
{
    partial class ShowResultsForm
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
            ResultsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ResultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ResultsDataGridView
            // 
            ResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ResultsDataGridView.BackgroundColor = SystemColors.Control;
            ResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultsDataGridView.Dock = DockStyle.Fill;
            ResultsDataGridView.Location = new Point(0, 0);
            ResultsDataGridView.Name = "ResultsDataGridView";
            ResultsDataGridView.RowHeadersWidth = 51;
            ResultsDataGridView.Size = new Size(800, 450);
            ResultsDataGridView.TabIndex = 0;
            // 
            // ShowResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultsDataGridView);
            Name = "ShowResultsForm";
            Text = "ShowResults";
            Load += ShowResults_Load;
            ((System.ComponentModel.ISupportInitialize)ResultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ResultsDataGridView;
    }
}