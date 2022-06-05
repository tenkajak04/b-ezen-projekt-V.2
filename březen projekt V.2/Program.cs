using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace březen_projekt_V._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //musíme načíst ty čísla
            Console.WriteLine("Zadej 1. číslo");
            string cislo1 = Console.ReadLine();
            Console.WriteLine("Zadej 2.číslo");
            string cislo2 = Console.ReadLine();
            //tady budem konvertovat ze string na int
            int con1 = Int32.Parse(cislo1);
            int con2 = Int32.Parse(cislo2);

            // tady to zjistí to nejmenší a největší číslo 
            int min = Math.Min(con1, con2);
            int max = Math.Max(con1, con2);

            if (con1 == con2)
            {
                Console.WriteLine("Čísla jsou shodná ");
            }

            else
            {
                // tady je ta finální fáze kde si vypíšou čísla 
                Console.WriteLine($" {min},{max}");
            }


            Console.ReadKey();
        }
    }
}
