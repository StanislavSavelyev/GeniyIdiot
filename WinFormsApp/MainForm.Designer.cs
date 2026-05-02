namespace WinFormsApp
{
    partial class MainForm
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
            StartGameButon = new Button();
            ExitButton = new Button();
            ShowResultButton = new Button();
            AddQuestionButton = new Button();
            DeleteQuestionButton = new Button();
            DeleteAllResultButton = new Button();
            SuspendLayout();
            // 
            // StartGameButon
            // 
            StartGameButon.Location = new Point(296, 12);
            StartGameButon.Name = "StartGameButon";
            StartGameButon.Size = new Size(182, 65);
            StartGameButon.TabIndex = 8;
            StartGameButon.Text = "Начать тест\r\n";
            StartGameButon.UseVisualStyleBackColor = true;
            StartGameButon.Click += StartGameButon_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(296, 296);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(182, 69);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ShowResultButton
            // 
            ShowResultButton.Location = new Point(296, 83);
            ShowResultButton.Name = "ShowResultButton";
            ShowResultButton.Size = new Size(182, 65);
            ShowResultButton.TabIndex = 10;
            ShowResultButton.Text = "Показать результаты";
            ShowResultButton.Click += ShowResultButton_Click;
            // 
            // AddQuestionButton
            // 
            AddQuestionButton.Location = new Point(296, 154);
            AddQuestionButton.Name = "AddQuestionButton";
            AddQuestionButton.Size = new Size(182, 65);
            AddQuestionButton.TabIndex = 11;
            AddQuestionButton.Text = "Добавить вопрос";
            AddQuestionButton.UseVisualStyleBackColor = true;
            AddQuestionButton.Click += AddQuestionButton_Click;
            // 
            // DeleteQuestionButton
            // 
            DeleteQuestionButton.Location = new Point(296, 225);
            DeleteQuestionButton.Name = "DeleteQuestionButton";
            DeleteQuestionButton.Size = new Size(182, 65);
            DeleteQuestionButton.TabIndex = 12;
            DeleteQuestionButton.Text = "Удалить вопрос";
            DeleteQuestionButton.UseVisualStyleBackColor = true;
            DeleteQuestionButton.Click += DeleteQuestionButton_Click;
            // 
            // DeleteAllResultButton
            // 
            DeleteAllResultButton.Location = new Point(559, 331);
            DeleteAllResultButton.Name = "DeleteAllResultButton";
            DeleteAllResultButton.Size = new Size(225, 29);
            DeleteAllResultButton.TabIndex = 13;
            DeleteAllResultButton.Text = "Очистить список результатов";
            DeleteAllResultButton.UseVisualStyleBackColor = true;
            DeleteAllResultButton.Click += DeleteAllResultButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 372);
            Controls.Add(DeleteAllResultButton);
            Controls.Add(ExitButton);
            Controls.Add(ShowResultButton);
            Controls.Add(DeleteQuestionButton);
            Controls.Add(StartGameButon);
            Controls.Add(AddQuestionButton);
            Name = "MainForm";
            Text = "Гений Идиот";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button StartGameButon;
        private Button ExitButton;
        private Button ShowResultButton;
        private Button AddQuestionButton;
        private Button DeleteQuestionButton;
        private Button DeleteAllResultButton;
    }
}
