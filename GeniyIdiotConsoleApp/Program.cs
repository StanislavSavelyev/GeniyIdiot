
using ClassLibrary;
using ConsoleTables;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace GeniyIdiotConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите ваше имя: ");
                var user = new User(Console.ReadLine());

                var questions = QuestionsStorage.LoadData();

                RunGame(user, questions);

                Console.WriteLine("Количество правильных ответов: " + user.RightAnswerCount);
                Console.WriteLine(user.Name + ", ваш диагноз: " + user.Diagnos);

                Console.WriteLine("Хотите посмотреть прошлые результаты? Введите Да или Нет!");
                if (IsContinue())
                {
                    var users = UsersResultStorage.GetAll();

                    var table = new ConsoleTable("Имя:", "Правильные ответы:", "Диагноз:");

                    foreach (var item in users)
                    {
                        table.AddRow(item.Name, item.RightAnswerCount, item.Diagnos);
                    }

                    table.Write(Format.MarkDown);
                }

                Console.WriteLine("Хотите удалить прошлые результаты? Введите Да или Нет");
                if (IsContinue())
                {
                    UsersResultStorage.Delete();
                    Console.WriteLine("Удаление прошло успешно!");
                }

                Console.WriteLine("Хотите удалить или добавить вопрос? Введите Да или Нет");
                if (IsContinue())
                {
                    Console.WriteLine("Выберите что хотите сделать! Введите 1 или 2");
                    Console.WriteLine("1. Добавить вопрос");
                    Console.WriteLine("2. Удалить вопрос");
                    while (true)
                    {
                        var numberAnswer = Console.ReadLine();
                        if (numberAnswer == "1")
                        {
                            Add();
                            break;
                        }

                        if (numberAnswer == "2")
                        {
                            Remove();
                            break;
                        }

                        Console.WriteLine("Введены не верные данные! Попробуйте еще раз");
                    }
                }

                Console.WriteLine("Хотите пройти тест заново? Введите Да или Нет");
                if (!IsContinue())
                {
                    return;
                }
            }
        }

        public static string GetQuestionText()
        {
            while (true)
            {
                var answer = Console.ReadLine();
                if (!int.TryParse(answer, out _))
                {
                    return answer;
                }
                 
                Console.WriteLine("Нужно ввести вопрос, а не цифры! Попробуйте еще раз");
            }
        }

        public static int GetQuestionAnswer()
        {
            while (true)
            {
                var answer = Console.ReadLine();
                if (int.TryParse(answer, out int result))
                {
                    return result;
                }
                Console.WriteLine("Введенные данные не являются числом или слишком большое число, попробуйте еще раз!");
            }
        }

        public static bool IsContinue()
        {
            while (true)
            {
                var answer = Console.ReadLine().ToLower();
                if (answer == "да")
                {
                    return true;
                }
                
                if (answer == "нет")
                {
                    return false;
                }

                Console.WriteLine("Введены не верные данные! Введите да или нет");
            }
        }

        public static void Add()
        {
            Console.WriteLine("Введите свой вопрос");
            var questionText = GetQuestionText();

            Console.WriteLine("Введите ответ на ваш вопрос! Ответ должен быть числом");
            var questionsAnswer = GetQuestionAnswer();

            var question = new Question(questionText, questionsAnswer);
            QuestionsStorage.Add(question);

            Console.WriteLine("Вопрос успешно добавлен!");
        }

        public static void Remove()
        {
            Console.WriteLine("Список вопросов");
            var questions = QuestionsStorage.LoadData();
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].Text}");
            }

            Console.WriteLine("Введите номер вопроса, который хотите удалить!");
            int questionNumber;
            while (!int.TryParse(Console.ReadLine(), out questionNumber) || questionNumber < 1 || questionNumber > questions.Count)
            {
                Console.WriteLine("Вы ввели не верные данные! Попробуйте еще раз");
            }

            QuestionsStorage.Delete(questionNumber - 1, questions);

            Console.WriteLine("Удаление прошло успешно!");
        }

        public static void RunGame(User user, List<Question> questions)
        {
            var randomQuestionsIndexes = Helper.GetRandomQuestionsIndexes(questions.Count);

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine("Вопрос №" + (i + 1));
                Console.WriteLine(questions[randomQuestionsIndexes[i]].Text);

                var userAnswer = GetQuestionAnswer();
                var rightAnswer = questions[randomQuestionsIndexes[i]].Answer;
                user.RightAnswerCount += userAnswer == rightAnswer ? 1 : 0;
            }

            user.Diagnos = Helper.GetDiagnos(user, questions.Count);
            UsersResultStorage.Append(user);
        }
    }
}
