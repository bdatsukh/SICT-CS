using System;

namespace lab3_1
{
    class MyCalc
    {
        public static double option(int op, double a, double b)
        {
            double result = 0;

            switch (op)
            {
                case 1:
                    result = add(a, b);
                    break;
                case 2:
                    result = substract(a, b);
                    break;
                case 3:
                    result = multiple(a, b);
                    break;
                case 4:
                    result = divide(a, b);
                    break;
                default:
                    break;
            }

            return result;
        }

        static double add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        static double substract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        static double multiple(double a, double b)
        {
            double result = a * b;
            return result;
        }

        static double divide(double a, double b)
        {
            double result = a / b;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("a, b too oruulna uu");

                Console.Write("A: ");
                string numA = Console.ReadLine();
                double cleanA = 0;
                while (!double.TryParse(numA, out cleanA))
                {
                    Console.Write("Temdegt oruulj bolohgui. Too oruulna uu. A: ");
                    numA = Console.ReadLine();
                }

                Console.Write("B: ");
                string numB = Console.ReadLine();
                double cleanB = 0;
                while (!double.TryParse(numB, out cleanB))
                {
                    Console.Write("Temdegt oruulj bolohgui. Too oruulna uu. B: ");
                    numB = Console.ReadLine();
                }

                bool sw = true;

                while (sw)
                {
                    Console.Clear();
                    Console.WriteLine("A: " + cleanA + "\nB: " + cleanB);
                    Console.WriteLine("1. add(a, b)\n2. substract(a, b)\n3. multiple(a, b)\n4. divide(a, b)");
                    Console.WriteLine("1, 2 ,3 ,4 -ees songon uu");

                    Console.Write("Songolt ???: ");
                    string op = Console.ReadLine();
                    int cleanOp = 0;
                    while (!int.TryParse(op, out cleanOp) || !(0 < cleanOp && cleanOp < 5))
                    {
                        Console.Clear();
                        Console.WriteLine("A: " + cleanA + "\nB: " + cleanB);
                        Console.WriteLine("1. add(a, b)\n2. substract(a, b)\n3. multiple(a, b)\n4. divide(a, b)");
                        Console.WriteLine("1, 2 ,3 ,4 -ees songon uu");
                        Console.Write("Temdegt oruulj bolohgui. 1 - 4 dotoroos songono uu. Songolt ???: ");
                        op = Console.ReadLine();

                    }

                    Console.WriteLine(op + ": " + MyCalc.option(cleanOp, cleanA, cleanB));
                    
                    Console.WriteLine("--------------------");
                    Console.WriteLine("1 - Duusgah\n2 - Oor too oruulah\n3 - Busad uildliig uzeh");
                    op = Console.ReadLine();
                    while (!int.TryParse(op, out cleanOp) || !(0 < cleanOp && cleanOp < 4))
                    {
                        Console.Clear();
                        Console.WriteLine("1 - Duusgah\n2 - Oor too oruulah\n3 - Busad uildliig uzeh");
                        Console.Write("Temdegt oruulj bolohgui. 1 - 3 hoorond songon uu. Songolt ???: ");
                        op = Console.ReadLine();
                    }

                    switch (cleanOp)
                    {
                        case 1:
                            return;
                        case 2:
                            sw = false;
                            break;
                        default:
                            break;
                    }

                    Console.Clear();
                }
            }
        }
    }
}
