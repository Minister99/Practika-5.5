using System;

namespace Practika_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string inputDataUser = Console.ReadLine();
            string[] inputData = SplitText(inputDataUser);
        }

        static string[] SplitText(string text)
        {
            string[] word = text.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in word) 
            {
                Console.WriteLine(s);
            }

            return word;
        }
    }
}
