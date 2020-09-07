namespace InterfaceDemo
{
    public class Members
    {
        private readonly IPerson person;

        public Members(IPerson person)
        {
            this.person = person;
        }
        public void Show()
        {
            person.ShowInfo();
        }
    }
}
