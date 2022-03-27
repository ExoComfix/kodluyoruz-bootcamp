using System;

namespace isPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool isPrime = true;
            Console.Write("Please enter number : ");
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
                if(number%i == 0 || number == 1)
                    isPrime = false;
            }
            
            if (isPrime)
                Console.WriteLine("Number is prime!");
            else
                Console.WriteLine("Number is not prime!");
        }
    }
}