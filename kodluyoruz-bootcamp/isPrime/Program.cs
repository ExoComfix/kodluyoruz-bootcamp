using System;

namespace isPrime
{
    class Program
    {
        static void isPrime(string[] args)
        {
            int number = 0;
            bool isPrime = true;
            Console.Write("Please Enter Number:");
            try
            {
                number = Convert.ToInt16(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter digits.");
            };
            
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if(number%i == 0)
                    prime = false;
            }

            if (number == 1)
                prime = false;

            if (prime)
                Console.WriteLine("Prime!");
            else
                Console.WriteLine("Not prime!");
        }
    }
}