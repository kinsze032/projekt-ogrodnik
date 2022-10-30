using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Loteria
    {
        public static void StartLoteria()
        {

            while (true)
            {
                int losuj_liczbe, zgadnij_liczbe;

                Console.Clear();
                Console.Title = "LOTERIA"; // tytuł konsoli
                                           // double losuj_liczbe, zgadnij_liczbe;

                Console.WriteLine("Program losuje cyfrę od 0 do 9. Zgadnij ją zatwierdzając przyciskiem ENTER.");
                Random zmienna = new Random();

                losuj_liczbe = zmienna.Next(0, 9); //podajemy najmniejszą i największą wartość na calkowitych
                if (Int32.TryParse(Console.ReadLine(), out zgadnij_liczbe)) //konwertuje tekst do liczby
                {


                    if (zgadnij_liczbe == losuj_liczbe)
                    {
                        Console.WriteLine("Gratulację! Odgadłeś cyfrę!");
                        Console.WriteLine();
                        Console.WriteLine("Zyskujesz 5 punktów doświadczenia");
                        ProsteMenu.LP += 5;
                    }
                    else
                    {
                        Console.WriteLine("Przykro mi, ale wylosowana cyfra to {0}.", losuj_liczbe);
                        Console.WriteLine();
                        Console.WriteLine("Tracisz -2 pkt doświadczenia");
                        ProsteMenu.LP -= 2;
                        
                    }
                    Console.Read();
                    Console.WriteLine("Wciśnij dowolny klawisz");

                    while (true)             // pętla nieskończona, o jej skończoności decyduje wciśnięcie klawisza
                    {
                        Console.Clear();
                        Console.WriteLine("Czy chcesz zagrać jeszcze raz?");
                        Console.WriteLine("Y/N");
                        Console.WriteLine();


                        ConsoleKeyInfo klawisz1 = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza
                        switch (klawisz1.Key)
                        {
                            case ConsoleKey.Y:   //ConsoleKey  Y, Enter - celem zatwierdzenia powrotu do menu głównego / N, Esc, Q - celem wyjścia z konsoli
                            case ConsoleKey.Enter:
                                Console.Clear();
                                Loteria.StartLoteria();
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
    }
}
