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
            PrintWord(inputData);
        }

        static string[] SplitText(string text)
        {
            string[] word = text.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            return word;
        }

        static void PrintWord(string[] text)
        {
            foreach (string n in text) 
            {
                Console.WriteLine(n);
            }
        }
    }
}
