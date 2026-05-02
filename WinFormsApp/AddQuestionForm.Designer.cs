namespace WinFormsApp
{
    partial class AddQuestionForm
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
            QuestionTexLabel = new Label();
            UserQuestionTextBox = new TextBox();
            AddButton = new Button();
            AnwerTextLabel = new Label();
            UserAnswerTextBox = new TextBox();
            BackMenuButton = new Button();
            SuspendLayout();
            // 
            // QuestionTexLabel
            // 
            QuestionTexLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuestionTexLabel.Location = new Point(272, 60);
            QuestionTexLabel.Name = "QuestionTexLabel";
            QuestionTexLabel.Size = new Size(234, 33);
            QuestionTexLabel.TabIndex = 0;
            QuestionTexLabel.Text = "Введите свой вопрос";
            QuestionTexLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserQuestionTextBox
            // 
            UserQuestionTextBox.Location = new Point(272, 115);
            UserQuestionTextBox.Name = "UserQuestionTextBox";
            UserQuestionTextBox.Size = new Size(234, 27);
            UserQuestionTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(257, 309);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(262, 119);
            AddButton.TabIndex = 2;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AnwerTextLabel
            // 
            AnwerTextLabel.AutoSize = true;
            AnwerTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AnwerTextLabel.Location = new Point(272, 169);
            AnwerTextLabel.Name = "AnwerTextLabel";
            AnwerTextLabel.Size = new Size(239, 28);
            AnwerTextLabel.TabIndex = 3;
            AnwerTextLabel.Text = "Введите ответ на вопрос";
            // 
            // UserAnswerTextBox
            // 
            UserAnswerTextBox.Location = new Point(272, 226);
            UserAnswerTextBox.Name = "UserAnswerTextBox";
            UserAnswerTextBox.Size = new Size(234, 27);
            UserAnswerTextBox.TabIndex = 4;
            // 
            // BackMenuButton
            // 
            BackMenuButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackMenuButton.Location = new Point(653, 380);
            BackMenuButton.Name = "BackMenuButton";
            BackMenuButton.Size = new Size(135, 58);
            BackMenuButton.TabIndex = 5;
            BackMenuButton.Text = "Меню";
            BackMenuButton.UseVisualStyleBackColor = true;
            BackMenuButton.Click += BackMenuButton_Click;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackMenuButton);
            Controls.Add(UserAnswerTextBox);
            Controls.Add(AnwerTextLabel);
            Controls.Add(AddButton);
            Controls.Add(UserQuestionTextBox);
            Controls.Add(QuestionTexLabel);
            Name = "AddQuestionForm";
            Text = "AddQuestionForm";
            FormClosed += AddQuestionForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionTexLabel;
        private TextBox UserQuestionTextBox;
        private Button AddButton;
        private Label AnwerTextLabel;
        private TextBox UserAnswerTextBox;
        private Button BackMenuButton;
    }
}