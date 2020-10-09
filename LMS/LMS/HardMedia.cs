namespace Model
{
    public class HardMedia:Media
    {
        public int PageNo;
        public static string HeaderLine;
        public HardMedia(string title, string author, int stock, int isbnNo,int pageNo)
            :base(title,author,stock,isbnNo)
        {
            PageNo = pageNo;
        }
    }
}
