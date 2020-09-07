using System;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Shap shaps=new Shap();
            
            Shap shap = new Shap();
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();

            shaps = shap;
            shaps.Draw();

            Console.WriteLine();
            
            shaps = rectangle;
            shaps.Draw();

            Console.WriteLine();
            
            shaps = circle;
            shaps.Draw();

            Console.WriteLine();

            shaps = triangle;
            shaps.Draw();

            Console.ReadKey();
        }
    }
}
