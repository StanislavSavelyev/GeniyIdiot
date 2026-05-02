using System.Text;

namespace ClassLibrary
{
    public static class FileStorage
    {

        public static void Write(string path, string value)
        {
            using (var sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.WriteLine(value);
            }
        }

        public static string Get(string path)
        {
            using (var sr = new StreamReader(path, Encoding.Default))
            {
                var fileDatta = sr.ReadToEnd();
                return fileDatta;
            }
        }

        public static void CreatingSubdirectory(string path)
        {
            var dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }

        public static void Delete(string path)
        {
            var fileInfo = new FileInfo(path);
            fileInfo.Delete();
        }

    }
}
