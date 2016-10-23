using System;

namespace Variables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float price = 20.95f;
            char character = 'A';
            string sentence = "I love learning new code";
            bool isWorking = false;
            const float pi = 3.14f;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(price);
            Console.WriteLine(character);
            Console.WriteLine(sentence);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", number, count);
            Console.WriteLine(pi);
        }
    }
}
