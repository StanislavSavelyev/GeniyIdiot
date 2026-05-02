namespace WinFormsApp
{
    partial class DeleteQuestionForm
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
            QuestionsGridView = new DataGridView();
            QuestionsNumberLabel = new Label();
            NumberTextBox = new TextBox();
            DeleteButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)QuestionsGridView).BeginInit();
            SuspendLayout();
            // 
            // QuestionsGridView
            // 
            QuestionsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            QuestionsGridView.BackgroundColor = SystemColors.Control;
            QuestionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionsGridView.Location = new Point(12, 12);
            QuestionsGridView.Name = "QuestionsGridView";
            QuestionsGridView.RowHeadersWidth = 51;
            QuestionsGridView.Size = new Size(776, 204);
            QuestionsGridView.TabIndex = 0;
            // 
            // QuestionsNumberLabel
            // 
            QuestionsNumberLabel.Location = new Point(217, 249);
            QuestionsNumberLabel.Name = "QuestionsNumberLabel";
            QuestionsNumberLabel.Size = new Size(367, 25);
            QuestionsNumberLabel.TabIndex = 1;
            QuestionsNumberLabel.Text = "Выберите номер вопроса который хотите удалить";
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(325, 287);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(125, 27);
            NumberTextBox.TabIndex = 2;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeleteButton.Location = new Point(281, 343);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(212, 95);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(653, 380);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(135, 58);
            BackButton.TabIndex = 4;
            BackButton.Text = "Меню";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // DeleteQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(DeleteButton);
            Controls.Add(NumberTextBox);
            Controls.Add(QuestionsNumberLabel);
            Controls.Add(QuestionsGridView);
            Name = "DeleteQuestionForm";
            Text = "DeleteQuestionForm";
            FormClosed += DeleteQuestionForm_FormClosed;
            Load += DeleteQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)QuestionsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView QuestionsGridView;
        private Label QuestionsNumberLabel;
        private TextBox NumberTextBox;
        private Button DeleteButton;
        private Button BackButton;
    }
}