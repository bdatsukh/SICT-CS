using System;
using System.IO.Pipes;

namespace Lab1_2
{

    class Program
    {

        static double option(char op, int n)
        {
            double result = -1;
            switch (op)
            {
                case '1':
                    result = option1(n);
                    break;
                case '2':
                    result = option2(n);
                    break;
                case '3':
                    result = n / option1(n);
                    break;
                default:
                    break;
            }

            return result;
        }

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

        static double option1(int n)
        {
            int result = 0;

            while (n > 0)
            {
                result += n % 10;
                n /= 10;
            }

            return result;
        }

        static double option2(int n)
        {
            int result = 1;

            while (n > 0)
            {
                result *= (n % 10);
                n /= 10;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (isPalindrom(n))
            {
                Console.WriteLine(n + " is palindrom");
            }
            else
            {
                Console.WriteLine(n + " is not palindrom. Doorh uildluudees songon uu.");
                Console.WriteLine("1 - Tsifruudiin niilber\n2 - Tsifruudiin urjver\n"
                    + "3 - Tuhain toog tsifruudiin niilbert huwaasnii uldegdel");
                Console.Write("Option: ");
                char op = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(op + ": " + option(op, n));
            }

        }
    }
}
