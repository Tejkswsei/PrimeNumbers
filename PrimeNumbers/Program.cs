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

                GetPrimeNumbers1(data);
                WriteNumbers(GetPrimeNumbers2(data));
            }
        }

        static void GetPrimeNumbers1(int data)
        {
            int number = 2;
            int count = 0;

            do
            {
                if (IsPrime(number))
                {
                    Console.Write($"{number}, ");
                    count++;
                }
                number++;
            }
            while (count < data);
        }

        static List<int> GetPrimeNumbers2(int data)
        {
            int count = 2;
            List<int> primeNumbers = new();

            do
            {
                if (IsPrime(count)) primeNumbers.Add(count);

                count++;
            }
            while (primeNumbers.Count < data);

            return primeNumbers;
        }

        static void WriteNumbers(List<int> primeNumbers)
        {
            foreach (int number in primeNumbers)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine("");
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
    }
}
