namespace ClassLibrary
{
    public class User
    {
        public string Name {  get; set; }
        public string Diagnos { get; set; }
        public int RightAnswerCount { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
