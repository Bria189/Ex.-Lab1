using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1_ASC
{
    class Program
    {
        //dupa cat timp vom avea o putere de calcul de 100 de ori mai mare fata de prezent daca se dubleaza la fiecare 18 luni?
        static void Main(string[] args)
        {
            //declaram variabilele
            int bn, n, m;
            float raspuns;

            //bn=ultimul an in care puterea a ajuns la x 100 fata de prezent, n=dupa cati ani
            Console.WriteLine("Problema 1");

            Console.WriteLine("Introduceti o valoare pentru bn");

            bn =int.Parse(Console.ReadLine()); //obligatoriu sa fie putere a lui 2
            m = bn / 2;
            n = 0;

            //verificam puterea lui q din bn

            for (int i = 1; i <= m; i++)
                n = n++;

            // dupa ce am aflat n, calculam si afisam perioada de timp

            raspuns = (n + 1) * 18 / 12;

            Console.WriteLine("Puterea de calcul va fi de 100 de ori mai mare dupa:");
            Console.WriteLine(raspuns);



        }
    }
}
