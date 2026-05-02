using ClassLibrary;

namespace WinFormsApp
{
    public partial class StartGameForm : Form
    {
        private List<Question> questions;
        private User user;
        private Question currentQuestion;
        private int questionsNumber = 1;
        private List<int> randomQuestionsIndexes;
        bool isApplicationExit = true;
        public StartGameForm()
        {
            InitializeComponent();
            AcceptButton = SaveNameButton;
        }
        private void StartGameForm_Load(object sender, EventArgs e)
        {
            QuestionNumberLabel.Visible = false;
            MenuButton.Visible = false;
            RepeatButton.Visible = false;
            QuestionTextLabel.Text = "Введите свое Имя";
            questions = QuestionsStorage.LoadData();
            randomQuestionsIndexes = Helper.GetRandomQuestionsIndexes(questions.Count);
            progressBar.Visible = false;
        }

        private void SaveNameButton_Click(object sender, EventArgs e)
        {
            user = new User(UserAnswerTextBox.Text);
            QuestionNumberLabel.Visible = true;
            NextButton.Visible = true;
            AcceptButton = NextButton;
            SaveNameButton.Visible = false;
            UserAnswerTextBox.Clear();
            progressBar.Visible = true;

            ShowNextQuestion();
        }

        private int GetUserAnswer()
        {
            var answer = UserAnswerTextBox.Text;
            if (int.TryParse(answer, out int result))
            {
                return result;
            }

            return int.MinValue;
        }

        private void ShowNextQuestion()
        {
            timer.Stop();
            progressBar.Value = 0;

            var numberQuestion = randomQuestionsIndexes[0];
            currentQuestion = questions[numberQuestion];
            QuestionTextLabel.Text = currentQuestion.Text;
            QuestionNumberLabel.Text = $"Вопрос № {questionsNumber}";
            questionsNumber++;
            randomQuestionsIndexes.RemoveAt(0);

            timer.Start();
        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            var userAnswer = GetUserAnswer();
            if (userAnswer == int.MinValue)
            {
                MessageBox.Show("Введена строка или слишко большое число! Попробуйте еще раз");
                return;
            }

            var rightAnswer = currentQuestion.Answer;
            user.RightAnswerCount += userAnswer == rightAnswer ? 1 : 0;

            var endGame = randomQuestionsIndexes.Count == 0;
            if (endGame)
            {
                timer.Stop();
                EndGame();
                return;
            }

            ShowNextQuestion();

            UserAnswerTextBox.Clear();
        }

        private void EndGame()
        {
            user.Diagnos = Helper.GetDiagnos(user, questions.Count);
            UsersResultStorage.Append(user);
            MessageBox.Show($"Количество правильных ответов: {user.RightAnswerCount}\n {user.Name}, Ваш диагноз: {user.Diagnos}");

            MenuButton.Visible = true;
            RepeatButton.Visible = true;
            NextButton.Enabled = false;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            isApplicationExit = false;
            Close();
        }

        private void RepeatButton_Click(object sender, EventArgs e)
        {
            QuestionNumberLabel.Visible = true;
            MenuButton.Visible = false;
            RepeatButton.Visible = false;
            randomQuestionsIndexes = Helper.GetRandomQuestionsIndexes(questions.Count);
            questionsNumber = 1;
            user.RightAnswerCount = 0;
            NextButton.Enabled = true;
            ShowNextQuestion();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();

            if (progressBar.Value >= progressBar.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Время вышло!");

                if (randomQuestionsIndexes.Count > 0)
                {
                    ShowNextQuestion();
                    return;
                }

                EndGame();
            }
        }

        private void StartGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isApplicationExit)
            {
                Application.Exit();
            }            
        }
    }
}
