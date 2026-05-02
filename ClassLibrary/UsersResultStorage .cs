using Newtonsoft.Json;

namespace ClassLibrary
{
    public static class UsersResultStorage
    {
        private static string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"GeniyIdiot\Result.json");

        public static void Delete()
        {
            FileStorage.Delete(_path);
        }

        public static void Append(User user)
        {
            var userResult = GetAll();
            userResult.Add(user);
            Save(userResult);
        }

        static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileStorage.Write(_path, jsonData);
        }

        public static List<User> GetAll()
        {
            CreatingSubdirectory();
            
            if (!File.Exists(_path))
            {
                return [];
            }

            var fileData = FileStorage.Get(_path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;
        }

        private static void CreatingSubdirectory()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "GeniyIdiot");
            FileStorage.CreatingSubdirectory(path);
        }
    }
}
