using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Witaj w symulatorze pracy ogrodnika\n\n Na początek może poznajmy Twoje imię. Przedstaw się: ");
            string imie = Console.ReadLine();               // podaj swoje imię jako ogrodnik
            Console.WriteLine();
            Console.WriteLine("Cześć " + imie + "! Poznaj z nami pracę ogrodnika.");
            Console.WriteLine();
            Console.Read();
            ProsteMenu.StartProsteMenu();
        }
    }
}
