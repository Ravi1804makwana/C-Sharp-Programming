namespace Model
{
    public class SoftMedia : Media
    {
        public int Time;
        public static string HeaderLine;
        public SoftMedia(string title, string author, int stock, int isbnNo, int time)
            : base(title, author, stock, isbnNo)
        {
            Time = time;
        }
    }
}
