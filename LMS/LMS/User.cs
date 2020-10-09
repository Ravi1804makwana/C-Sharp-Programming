namespace Model
{
    public class User
    {
        /**
        *
        *   Author : Ravikumar Makwana
        *   Aim : Base Class for Student and Staff
        *   
        */
        private string _name;
        private int _age;
        private int _userId;
        public User(string name,int age,int userId)
        {
            _name = name;
            _age = age;
            _userId = userId;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
    }
}
