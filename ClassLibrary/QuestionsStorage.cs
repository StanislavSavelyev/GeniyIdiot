using Newtonsoft.Json;

namespace ClassLibrary
{
    public static class QuestionsStorage
    {
        private static string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"GeniyIdiot\QuestionsAnswer.json");
        
        static QuestionsStorage()
        {
            CreatSubdirectory();

            if (!File.Exists(_path))
            {
                var questions = GetDefaultQuestions();
                SaveData(questions);
            }
        }
        public static List<Question> LoadData()
        {
            var fileData = FileStorage.Get(_path);
            return JsonConvert.DeserializeObject<List<Question>>(fileData) ?? [];
        }

        public static void Delete(int index, List<Question> questions)
        {
            questions.RemoveAt(index);
            SaveData(questions);
        }

        public static void Add(Question question)
        {
            var jsonQuestions = FileStorage.Get(_path);
            var questions = JsonConvert.DeserializeObject<List<Question>>(jsonQuestions);
            questions.Add(question);
            SaveData(questions);
        }
                
        private static List<Question> GetDefaultQuestions()
        {
            return new List<Question>
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей, сколько нужно сделать распилов?", 9),
                new Question("На двух руках 10 пальцев, сколько пальцев на пяти руках?", 25),
                new Question("Укол делают каждые полчаса, сколько нужно минут для 3х уколов?", 60),
                new Question("Пять свечей горело, 2 потухли, сколько свечей осталось?", 2)
            };
        }
        private static void CreatSubdirectory()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "GeniyIdiot");
            FileStorage.CreatingSubdirectory(path);
        }

        private static void SaveData(List<Question> questions)
        {
            var jsonQuestions = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileStorage.Write(_path, jsonQuestions);
        }
    }
}
