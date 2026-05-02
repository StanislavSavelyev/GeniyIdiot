namespace ClassLibrary
{
    public static class Helper
    {

        public static string GetDiagnos(User user, int countQuestions)
        {
            var rightAnswerPercent = ((double)user.RightAnswerCount / countQuestions) * 100;

            return rightAnswerPercent >= 90 ? "Гений" :
                   rightAnswerPercent >= 70 ? "Талант" :
                   rightAnswerPercent >= 50 ? "Нормальный" :
                   rightAnswerPercent >= 30 ? "Дурак" :
                   rightAnswerPercent >= 10 ? "Кретин" : "Идиот";
        }

        public static List<int> GetRandomQuestionsIndexes(int questionsCount)
        {
            Random random = new Random();
            var randomQuestionIndex = new List<int>();
            for (int i = 0; i < questionsCount; i++)
            {
                while (true)
                {
                    var num = random.Next(0, questionsCount);
                    if (!randomQuestionIndex.Contains(num))
                    {
                        randomQuestionIndex.Add(num);
                        break;
                    }
                }
            }

            return randomQuestionIndex;
        }
    }
}
