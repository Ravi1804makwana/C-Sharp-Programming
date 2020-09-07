using System;

namespace MethodOverriding
{
    public class Rectangle : Shap
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
