using System;

namespace Euroogdkk
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sætter variabler
            string kurs, kroner;
            double euro, kurs1, kroner1;

            Console.Clear();
            // Indlæser antal af kroner
            Console.Write("Indtast antal kroner: ");

            kroner = Console.ReadLine();

            kroner1 = double.Parse(kroner);
            // Indlæser kursen
            Console.Write("Indtast kursen:");

            kurs = Console.ReadLine();

            kurs1 = double.Parse(kurs);

            // udregning

            euro = kroner1 / (kurs1 / 100);

            Console.WriteLine("Når kursen er {0:N2}, får du {1:N2} euro, når du veksler {2:N2} danske kroner", kurs1, euro, kroner1);

            Console.ReadKey();
        }
    }
}
