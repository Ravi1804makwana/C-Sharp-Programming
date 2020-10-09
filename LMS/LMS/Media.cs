namespace Model
{
    public class Media
    {
        /**
        *
        *   Author : Ravikumar Makwana
        *   Aim : Base class for Hard and Soft materials
        *   
        */
        public string Title, Author;
        public int Stock;
        private int _isbnNo;

        public int IsbnNo
        {
            get { return _isbnNo; }
            set { _isbnNo = value; }
        }

        public Media(string title,string author,int stock,int isbnNo)
        {
            Title = title;
            Author = author;
            Stock = stock;
            _isbnNo = isbnNo;
        }

    }
}
