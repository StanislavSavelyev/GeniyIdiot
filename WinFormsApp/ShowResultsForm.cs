using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ShowResultsForm : Form
    {
        private List<User> users;
        public ShowResultsForm(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void ShowResults_Load(object sender, EventArgs e)
        {
            ResultsDataGridView.AutoGenerateColumns = false;

            DataGridViewColumn columnName = new DataGridViewTextBoxColumn();
            columnName.HeaderText = "Имя";
            columnName.DataPropertyName = nameof(User.Name);
            ResultsDataGridView.Columns.Add(columnName);

            DataGridViewColumn columnAnswer = new DataGridViewTextBoxColumn();
            columnAnswer.HeaderText = "Правильные ответы";
            columnAnswer.DataPropertyName = nameof(User.RightAnswerCount);
            ResultsDataGridView.Columns.Add(columnAnswer);

            DataGridViewColumn columnDiagnos = new DataGridViewTextBoxColumn();
            columnDiagnos.HeaderText = "Диагноз";
            columnDiagnos.DataPropertyName = nameof(User.Diagnos);
            ResultsDataGridView.Columns.Add(columnDiagnos);

            ResultsDataGridView.DataSource = users;
        }
    }
}
