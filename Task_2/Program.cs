using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложения");


        }

        static string[] SplitText(string text) 
        {
            string[] word = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in word) 
            {
                Console.WriteLine(s);
            }
            return word;
        }
    }
}
