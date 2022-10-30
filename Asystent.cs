using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Asystent
    {
        

        
        public static void StartAsystent()
        {
            while (true)
            {
                Console.Clear();
                Console.Title = "Asystent"; //tytuł konsoli
                Console.WriteLine("Tutaj możesz zatrudnić asystenta");
                Console.WriteLine();
                Console.Write("Co chcesz zrobić");
                Console.WriteLine();
                Console.WriteLine("1. Zatrudnij pomocnika");
                Console.WriteLine("2. Wejdź na stronę Powiatowego Urzędu Pracy");
                Console.WriteLine();
                Console.WriteLine("Q - wyjście");
                Console.WriteLine();
                Console.Write("Wybierz co chcesz zrobić: ");

                ConsoleKeyInfo klawisz2 = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza
                switch (klawisz2.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Nie masz pieniędzy, by kogoś zatrudnić.");
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine();
                        PUP.StartPUP();
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Y:   //ConsoleKey  Y, Enter - celem zatwierdzenia powrotu do menu głównego / N, Esc, Q - celem wyjścia z konsoli
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Kret.StartPolowanie();
                        break;
                    case ConsoleKey.N:
                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        ProsteMenu.StartProsteMenu();
                        break;// wracamy do Menu głównego
                    default: break;                       
      
                    
                }
            }
        }

    }
}

