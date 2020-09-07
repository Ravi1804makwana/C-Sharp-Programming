using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityControl
{
    public interface IActivity
    {
        void Execute();
    }
    public class TextView : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("TextView");
        }
    }
    public class ButtonView : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("ButtonView");
        }
    }
    public class ImageView : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("ImageView");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IActivity activity;
            TextView textView = new TextView();
            ButtonView buttonView = new ButtonView();
            ImageView imageView = new ImageView();

            activity = textView;
            activity.Execute();

            activity = buttonView;
            activity.Execute();

            activity = imageView;
            activity.Execute();

            Console.ReadKey();
        }
    }
}
