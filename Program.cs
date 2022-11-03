using System;

namespace Задание_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
                        
            ReverseSentense(sentence);

            Console.ReadKey();
        }

        static string[] SplitSentence(string text)
        {
            string[] wordsArray = text.Split(' ');
            return wordsArray;
        }

        static void ReverseSentense(string text)
        {
            string[] wordsArray = SplitSentence(text);
                       
            Array.Reverse(wordsArray);
            int i = 0;
            while (i++ < wordsArray.Length)
            {
                Console.Write($"{wordsArray[i - 1]} ");
            }
        }
    }
}
