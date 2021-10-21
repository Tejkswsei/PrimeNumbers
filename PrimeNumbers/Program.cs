using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int data = Convert.ToInt32(Console.ReadLine());

                WriteNumbers(GetPrimeNumbers(data));
            }
        }

        static List<int> GetPrimeNumbers(int data)
        {
            int count = 0;
            List<int> primeNumbers = new();

            do
            {
                if (IsPrime(count)) primeNumbers.Add(count);

                count++;
            }
            while (primeNumbers.Count < data);

            return primeNumbers;
        }

        static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void WriteNumbers(List<int> primeNumbers)
        {
            foreach (int number in primeNumbers)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine("");
        }
    }
}
