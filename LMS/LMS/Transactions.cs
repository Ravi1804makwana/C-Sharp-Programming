using Model;

namespace Controller
{
    /**
     * 
     *  Author : Ravikumar Makwana
     *  Aim : To perform every types of transactions
     * 
     */
    public class Transactions
    {
        static int userIndex;
        static int bookIndex;
        public string IssueBook(int userId, int isbnNo,string mediaType)
        {
            bool validUserId = false;
            int c=0;
            foreach (var item in DAO.student)
            {
                if(item.UserId==userId)
                {
                    userIndex = c;
                    validUserId = true;
                    break;
                }
                c++;
            }
            if(!validUserId)
                return "User Not Found : Invalid userId.";

            bool validIsbnNo = false;
            c = 0;
            if(mediaType=="softmedia")
            {
                foreach (var item in DAO.softMedia)
                {
                    if(item.IsbnNo==isbnNo)
                    {
                        bookIndex = c;
                        validIsbnNo = true;
                        break;
                    }
                    c++;
                }
            }
            else
            {
                foreach (var item in DAO.hardMedia)
                {
                    if (item.IsbnNo == isbnNo)
                    {
                        bookIndex = c;
                        validIsbnNo = true;
                        break;
                    }
                    c++;
                }
            }
            if (!validIsbnNo)
                return "Matrial Not Found : Wrong Isbn No.";

            if (DAO.student[userIndex].BookBalance <= 0)
                return "Insufficient Balance.";

            if(mediaType=="softmedia")
            {
                if (DAO.softMedia[bookIndex].Stock <= 0)
                    return "Your Material not available";

                DAO.student[userIndex].BookBalance--;
                DAO.softMedia[bookIndex].Stock--;
                return "Successful : Successfully your mateiral is issued. ";
            }
            else
            {
                if (DAO.hardMedia[bookIndex].Stock <= 0)
                    return "Your Material not available";

                DAO.student[userIndex].BookBalance--;
                DAO.hardMedia[bookIndex].Stock--;
                return "Successful : Successfully your mateiral is issued. ";
            }
        }
        public string ReturnBook(int userId, int isbnNo, string mediaType)
        {
            bool validUserId = false;
            int c = 0;
            foreach (var item in DAO.student)
            {
                if (item.UserId == userId)
                {
                    userIndex = c;
                    validUserId = true;
                    break;
                }
                c++;
            }
            if (!validUserId)
                return "User Not Found : Invalid userId.";

            bool validIsbnNo = false;
            c = 0;
            if (mediaType == "softmedia")
            {
                foreach (var item in DAO.softMedia)
                {
                    if (item.IsbnNo == isbnNo)
                    {
                        bookIndex = c;
                        validIsbnNo = true;
                        break;
                    }
                    c++;
                }
            }
            else
            {
                foreach (var item in DAO.hardMedia)
                {
                    if (item.IsbnNo == isbnNo)
                    {
                        bookIndex = c;
                        validIsbnNo = true;
                        break;
                    }
                    c++;
                }
            }
            if (!validIsbnNo)
                return "Matrial Not Found : Wrong Isbn No.";

            if (mediaType == "softmedia")
            {
                DAO.student[userIndex].BookBalance++;
                DAO.softMedia[bookIndex].Stock++;
                return "Successful : Successfully your material is returned. ";
            }
            else
            {
                DAO.student[userIndex].BookBalance++;
                DAO.hardMedia[bookIndex].Stock++;
                return "Successful : Successfully your mateiral is returned. ";
            }
        }
        public string CheckBalance(int userId)
        {
            bool validUserId = false;
            int c = 0;
            foreach (var item in DAO.student)
            {
                if (item.UserId == userId)
                {
                    userIndex = c;
                    validUserId = true;
                    break;
                }
                c++;
            }
            if (!validUserId)
                return "User Not Found : Invalid userId.";
            else
                return "Hello "+DAO.student[userIndex].Name+", \nYour Book Balance : " + DAO.student[userIndex].BookBalance;
        }
        public string SearchMaterial(string material)
        {
            string searchedItems = "";
            foreach (var item in DAO.softMedia)
            {
                if (item.Title.IndexOf(material) != -1)
                    searchedItems += "Type : Softmedia\nIsbn No. : " + item.IsbnNo + "\nTitle : " + item.Title + "\n\n";
            }

            foreach (var item in DAO.hardMedia)
            {
                if (item.Title.IndexOf(material) != -1)
                    searchedItems += "Type : Hardmedia\nIsbn No. : " + item.IsbnNo + "\nTitle : " + item.Title + "\n\n";
            }

            if (searchedItems != "")
                return searchedItems;
            else
                return "This Material not found in Library";
        }
    }
}
