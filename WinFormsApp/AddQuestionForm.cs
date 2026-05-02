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
    public partial class AddQuestionForm : Form
    {
        bool isApplicationExit = true;

        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var questionText = GetQuestionText();
            if (questionText == null)
            {
                MessageBox.Show("Нужно ввести вопрос, а не цифры! Попробуйте еще раз");
                UserQuestionTextBox.Clear();
                return;
            }

            var questionAnswer = GetQuestionAnswer();
            if (questionAnswer == int.MinValue)
            {
                MessageBox.Show("Ответ не являются числом или слишком большое число, попробуйте еще раз!");
                UserAnswerTextBox.Clear();
                return;
            }

            QuestionsStorage.Add(new Question(questionText, questionAnswer));
            MessageBox.Show("Вопрос успешно добавлен!");
            isApplicationExit = false;
            Close();
        }

        private int GetQuestionAnswer()
        {
            var answer = UserAnswerTextBox.Text;

            if (int.TryParse(answer, out int result))
            {
                return result;
            }

            return int.MinValue;
        }

        private string GetQuestionText()
        {
            var answer = UserQuestionTextBox.Text;
            if (int.TryParse(answer, out _))
            {
                return null;
            }

            return answer;
        }

        private void BackMenuButton_Click(object sender, EventArgs e)
        {
            isApplicationExit = false;
            Close();
        }

        private void AddQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isApplicationExit)
            {
                Application.Exit();
            }            
        }
    }
}
