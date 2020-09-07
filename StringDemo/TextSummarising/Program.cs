using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummarising
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = "Hi, I am Ravi.";
            var text2 = "Hi very very evry very evry ravi arvi arvia atvi arcvai ravi ara ravi ravi arvi arvvai arai arvi ari ravi ravi ravi ra ";
            var text3 = "beautututututu uhfef eei fenfzi teh i a ma aafdadhaddwdw";
            var text4 = "hi jello wwnw sdswjf  scjs sdsjdssdsms sss";
            var text5 = "hi helo dowdjw dwo  sfsf fsf eiee vdvndi";
            Console.WriteLine(SummarizeText(text2));
            Console.ReadKey();
        }
        public static String SummarizeText(String sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
                return sentence;

            var words = sentence.Split(' ');
            int totalCharacters = 0;
            var summaryWorld = new List<String>();
            foreach (var word in words)
            {
                summaryWorld.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            return String.Join(" ", summaryWorld) + " ...";
            
        }
    }
}
