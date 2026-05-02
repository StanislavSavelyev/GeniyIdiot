using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class DeleteQuestionForm : Form
    {
        List<Question> questions;

        bool isApplicationExit = true;

        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            QuestionsGridView.AutoGenerateColumns = false;

            questions = QuestionsStorage.LoadData();

            DataGridViewColumn columnText = new DataGridViewTextBoxColumn();
            columnText.HeaderText = "Вопрос";
            columnText.DataPropertyName = nameof(Question.Text);
            QuestionsGridView.Columns.Add(columnText);

            DataGridViewColumn columnAnswer = new DataGridViewTextBoxColumn();
            columnAnswer.HeaderText = "Ответ";
            columnAnswer.DataPropertyName = nameof(Question.Answer);
            QuestionsGridView.Columns.Add(columnAnswer);

            QuestionsGridView.DataSource = questions;

            var rows = QuestionsGridView.RowCount;
            for (int i = 0; i < rows; i++)
            {
                QuestionsGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var number = GetNumber();
            if (number == int.MinValue)
            {
                MessageBox.Show("Веденные данные не верны! Попробуйте еще раз");
                NumberTextBox.Clear();
                return;
            }
            QuestionsStorage.Delete(number - 1, questions);
            MessageBox.Show("Удаление прошло успешно!");
            isApplicationExit = false;
            Close();
        }

        private int GetNumber()
        {
            var number = NumberTextBox.Text;
            if (int.TryParse(number, out int result) && result <= QuestionsGridView.RowCount && result >= 0)
            {
                return result;
            }

            return int.MinValue;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            isApplicationExit = false;
            Close();
        }

        private void DeleteQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isApplicationExit)
            {
                Application.Exit();
            }
        }
    }
}
