using System;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Too: ");
                string num = Console.ReadLine();
                int cleanNum = 0;

                while (!int.TryParse(num, out cleanNum) || cleanNum < 1 || cleanNum > 108)
                {
                    Console.WriteLine("Temdegt, butarhai, sorog esvel baighui toot oruulsan baina, Natural too oruulna uu. Too:");
                    num = Console.ReadLine();
                }

                int o, d;
                o = (cleanNum % 36 == 0) ? cleanNum / 36 - 1 : cleanNum / 36;
                cleanNum = cleanNum - o * 36;
                d = (cleanNum % 4 == 0) ? cleanNum / 4 - 1 : cleanNum / 4;
                cleanNum = cleanNum - d * 4;

                Console.WriteLine("Orts: " + (o + 1) + "\nDawhar: " + (d + 1) + "\nToot: " + cleanNum);
                Console.WriteLine("Exit - x\nContinue - other");
                string x = Console.ReadLine();
                if (x == "x") return;
                Console.WriteLine("-------------");
            }
        }
    }

}
