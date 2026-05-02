namespace WinFormsApp
{
    partial class StartGameForm
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
            QuestionNumberLabel = new Label();
            QuestionTextLabel = new Label();
            UserAnswerTextBox = new TextBox();
            SaveNameButton = new Button();
            NextButton = new Button();
            MenuButton = new Button();
            RepeatButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // QuestionNumberLabel
            // 
            QuestionNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuestionNumberLabel.Location = new Point(308, 91);
            QuestionNumberLabel.Name = "QuestionNumberLabel";
            QuestionNumberLabel.Size = new Size(178, 28);
            QuestionNumberLabel.TabIndex = 0;
            QuestionNumberLabel.Text = "Номер вопроса";
            QuestionNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuestionTextLabel
            // 
            QuestionTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuestionTextLabel.Location = new Point(12, 155);
            QuestionTextLabel.Name = "QuestionTextLabel";
            QuestionTextLabel.Size = new Size(776, 28);
            QuestionTextLabel.TabIndex = 1;
            QuestionTextLabel.Text = "Текст вопроса";
            QuestionTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserAnswerTextBox
            // 
            UserAnswerTextBox.Location = new Point(270, 236);
            UserAnswerTextBox.Name = "UserAnswerTextBox";
            UserAnswerTextBox.Size = new Size(262, 27);
            UserAnswerTextBox.TabIndex = 4;
            // 
            // SaveNameButton
            // 
            SaveNameButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SaveNameButton.Location = new Point(270, 319);
            SaveNameButton.Name = "SaveNameButton";
            SaveNameButton.Size = new Size(262, 119);
            SaveNameButton.TabIndex = 3;
            SaveNameButton.Text = "Начать";
            SaveNameButton.UseVisualStyleBackColor = true;
            SaveNameButton.Click += SaveNameButton_Click;
            // 
            // NextButton
            // 
            NextButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NextButton.Location = new Point(270, 319);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(262, 119);
            NextButton.TabIndex = 4;
            NextButton.Text = "Далее";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click_1;
            // 
            // MenuButton
            // 
            MenuButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuButton.Location = new Point(651, 371);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(135, 58);
            MenuButton.TabIndex = 5;
            MenuButton.Text = "Меню";
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // RepeatButton
            // 
            RepeatButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RepeatButton.Location = new Point(653, 307);
            RepeatButton.Name = "RepeatButton";
            RepeatButton.Size = new Size(135, 58);
            RepeatButton.TabIndex = 6;
            RepeatButton.Text = "Начать заново";
            RepeatButton.UseVisualStyleBackColor = true;
            RepeatButton.Click += RepeatButton_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(139, 30);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(539, 29);
            progressBar.TabIndex = 7;
            // 
            // StartGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            Controls.Add(RepeatButton);
            Controls.Add(MenuButton);
            Controls.Add(SaveNameButton);
            Controls.Add(UserAnswerTextBox);
            Controls.Add(QuestionTextLabel);
            Controls.Add(QuestionNumberLabel);
            Controls.Add(NextButton);
            Name = "StartGameForm";
            Text = "Гений Идиот";
            FormClosed += StartGameForm_FormClosed;
            Load += StartGameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionNumberLabel;
        private Label QuestionTextLabel;
        private TextBox UserAnswerTextBox;
        private Button SaveNameButton;
        private Button NextButton;
        private Button MenuButton;
        private Button RepeatButton;
        private System.Windows.Forms.Timer timer;
        private ProgressBar progressBar;
    }
}