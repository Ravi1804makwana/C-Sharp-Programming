namespace SwapNumbers
{
    public class ComplexNumber
    {
        int r,i;
        public ComplexNumber(int r,int i)
        {
            this.r = r;
            this.i = i;
        }
        public ComplexNumber()
        {

        }
        public void Add(ComplexNumber complexNumber1,ComplexNumber complexNumber2)
        {
            this.r = complexNumber1.r + complexNumber2.r;
            this.i = complexNumber1.i + complexNumber2.i;
        }
        public void Multiply(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            this.r = complexNumber1.r * complexNumber2.r;
            this.i = complexNumber1.i * complexNumber2.i;
        }
        public void show()
        {
            System.Console.WriteLine(this.r+" + "+this.i+" i");
        }
    }
}
