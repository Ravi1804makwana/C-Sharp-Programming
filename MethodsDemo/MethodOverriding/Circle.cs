using System;

namespace MethodOverriding
{
    public class Circle:Shap
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
