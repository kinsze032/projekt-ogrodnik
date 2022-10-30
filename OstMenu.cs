using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class OstMenu
    {
            
        public static void StartOstMenu()
        {
            Console.Title = "Proste menu";  //przypisanie tytułu 
            while (true)             // pętla nieskończona, o jej skończoności decyduje wciśnięcie klawisza
            {
                Console.Clear();
                Console.WriteLine("Czy chcesz zagrać jeszcze raz?");
                Console.WriteLine("Y/N");
                Console.WriteLine();


                ConsoleKeyInfo klawisz3 = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza
                switch (klawisz3.Key)
                {
                    case ConsoleKey.Y:   //ConsoleKey  Y, Enter - celem zatwierdzenia powrotu do menu głównego / N, Esc, Q - celem wyjścia z konsoli
                    case ConsoleKey.Enter:
                        Console.Clear();
                        ProsteMenu.StartProsteMenu();
                        break;
                    case ConsoleKey.N:
                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;//metoda powoduje zakończenie procesu (wyjście z programu)
                    default: break;
                }
            }
        }
    }
}

