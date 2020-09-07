namespace OOP_Programs
{
    public class Calculator
    {
        public void Add(params int [] arr)
        {
            int sum=0;
            foreach (var n in arr)
            {
                sum += n;
            }
            System.Console.WriteLine(sum);
        }
    }
}
