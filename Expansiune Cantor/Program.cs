using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansiune_Cantor
{
    class Program
    {
        private static List<int> DTC(int x)
        {
            List<int> result = new List<int>();
            int y = x;
            int n = 0;

            while (y != 0)
            {
                int a;
                a = y % (n + 1);
                y = (y - a) / (n + 1);
                result.Add(a);
                n++;
            }
            return result;
        }

        static int CTD(List<int> cantor)
        {
            int result = 0;
            int n = cantor.Count;
            for (int i = n - 1; i > 0; i--)
            {
                result = result + cantor[i];
                result = result * i;
            }
            return result;
        }

        static void View(List<int> result)
        {
            int n = result.Count;
            for (int i = n - 1; i > 0; i--)
            {
                if (result[i] != 0)
                {
                    if (i != n - 1)
                        Console.Write(" + ");
                    Console.Write($"{result[i]} * {i}!");
                }
            }
            Console.WriteLine();
        }
        static List<int> Suma(List<int> cantor1, List<int> cantor2)
        {
            List<int> result = new List<int>();

            int min = Math.Min(cantor1.Count, cantor2.Count);
            int max = Math.Max(cantor1.Count, cantor2.Count);

            for (int i = 0; i < min; i++)
            {
                int sum = cantor1[i] + cantor2[i];
                result.Add(sum);
            }

            if (cantor1.Count == min)
                for (int i = min; i < max; i++)
                    result.Add(cantor2[i]);
            else
                if (cantor2.Count == min)
                for (int i = min; i < max; i++)
                    result.Add(cantor1[i]);

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("2 = ");
            View(DTC(2));
            Console.Write("7 = ");
            View(DTC(7));
            Console.Write("19 = ");
            View(DTC(19));
            Console.Write("87 = ");
            View(DTC(87));
            Console.Write("1000 = ");
            View(DTC(1000));
            Console.Write("1000000 = ");
            View(DTC(1000000));
            Console.WriteLine();

            Console.Write("Cititi un numar de la tastatura: ");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Expansiunea cantor a numarului {x} este: ");

            View(DTC(x));

            View(Suma(DTC(1000), DTC(19)));

            Console.WriteLine(CTD(Suma(DTC(1000), DTC(19))));
        }
    }
}

