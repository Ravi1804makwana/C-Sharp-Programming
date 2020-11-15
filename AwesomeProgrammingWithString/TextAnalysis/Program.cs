using System;

namespace TextAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Text : ");
            var text = Console.ReadLine();
            int characters = 0, words = 0, s=int.MaxValue, l=int.MinValue;
            string longestWord = null, smallestWord = null;

            for(int i=0;i<text.Length;i++)
            {
                characters++;
                if(text[i]==' ')
                {
                    characters--;
                    words++;
                }
            }

            var parts = text.Split(' ');
            foreach (var part in parts)
            {
                if (s > part.Length)
                    s = part.Length;
                if (l < part.Length)
                    l = part.Length;
            }

            foreach (var part in parts)
            {
                if (s == part.Length)
                    smallestWord = part;
                if (l == part.Length)
                    longestWord = part;
            }

            Console.WriteLine();
            Console.WriteLine("*** Text Analysis ***");
            Console.WriteLine("Length of Text : "+text.Length);
            Console.WriteLine("Number of Characters : "+characters);
            Console.WriteLine("Number of Words : "+(words+1));
            Console.WriteLine("Longest Word : "+longestWord);
            Console.WriteLine("Smallest Word : "+smallestWord);
            Console.ReadKey();
        }
    }
}
