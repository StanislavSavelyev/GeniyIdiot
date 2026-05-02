using ClassLibrary;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void StartGameButon_Click(object sender, EventArgs e)
        {
            Hide();
            StartGameForm startGameForm = new StartGameForm();
            startGameForm.Location = this.Location;
            startGameForm.ShowDialog();
            Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowResultButton_Click(object sender, EventArgs e)
        {
            var users = UsersResultStorage.GetAll();

            if (users.Count == 0)
            {
                MessageBox.Show("Список пустой");
                return;
            }

            ShowResultsForm showResults = new ShowResultsForm(users);
            showResults.Show();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddQuestionForm addQuestionForm = new AddQuestionForm();
            addQuestionForm.Location = this.Location;
            addQuestionForm.ShowDialog();
            Show();
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            Hide();
            DeleteQuestionForm deleteQuestionForm = new DeleteQuestionForm();
            deleteQuestionForm.Location = this.Location;
            deleteQuestionForm.ShowDialog();
            Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DeleteAllResultButton_Click(object sender, EventArgs e)
        {
            UsersResultStorage.Delete();
            MessageBox.Show("Список очищен");
        }
    }
}
