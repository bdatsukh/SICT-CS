using System;

namespace ConsoleApp2
{
    class Program
    {

        static bool isPalindrom(int n)
        {
            bool result;
            int m = n, n1 = 0;

            while (n > 0)
            {
                n1 = n1 * 10 + n % 10;
                n /= 10;
            }

            result = (m == n1) ? true : false;

            return result;
        }

        static bool isPrime(int n)
        {
            bool result = true;

            for(int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static void isPP(int n)
        {
            if (isPalindrom(n))
            {
                if (isPrime(n))
                {
                    Console.WriteLine(n);
                }
            }
            return;
        }

        static void Main(string[] args)
        {

            int n = 1000000;

            Console.Write("2\n3\n");

            for (int i = 5; i < n; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    isPP(i);
                }
            }

            return;
        }
    }
}
