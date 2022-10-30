using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class PUP
    {
        public static void StartPUP()
        {


            while (true)
            {
                int losuj_numer;

                Console.Clear();
                Console.Title = "Powiatowy Urząd Pracy"; // tytuł konsoli
                                                         // double losuj_liczbe, zgadnij_liczbe;

                Console.WriteLine("Wylosuj swój numer w kolejce.");
                Thread.Sleep(3000);
                Random zmienna = new Random();

                losuj_numer = zmienna.Next(1, 20); //podajemy najmniejszą i największą wartość na calkowitych

                Console.WriteLine();
                if (losuj_numer < 10)
                {
                    Console.WriteLine(" Twój nr to {0}. Musisz chwilę poczekać", losuj_numer);
                    Thread.Sleep(7000);
                    Console.SetCursorPosition(28, 16);
                    Console.WriteLine("Prosze o chwilę cierpliwości, jesteś następny w kolejce");
                    Thread.Sleep(7000);
                    Console.WriteLine();
                    Console.WriteLine("Przykro mi, ale nie mamy nikogo do pomocy");
                    Thread.Sleep(3000);
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Przykro mi, ale wylosowany nr w kolejce to {0}. Przyjdź jutro", losuj_numer);
                    Thread.Sleep(3000);
                    Console.Read();
                }

                
                Console.WriteLine();
                while (true)             // pętla nieskończona, o jej skończoności decyduje wciśnięcie klawisza
                {
                    Console.Clear();
                    Console.WriteLine("Czy chcesz wyjść z budynku Powiatowego Urzędu Pracy czy zalogować się swoje konto PUP?");
                    Console.WriteLine("1. Wyjść z budynku");
                    Console.WriteLine("2. Zaloguj się");
                    Console.WriteLine();
             


                    ConsoleKeyInfo klawisz4 = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza
                    switch (klawisz4.Key)
                    {
                        case ConsoleKey.D1:   //ConsoleKey  1, celem przejścia do menu głównego
                            Console.Clear();
                            ProsteMenu.StartProsteMenu();
                            break;
                        case ConsoleKey.D2:   // 2 - zalogowanie się na stronie WWW
                            Console.Clear();
                            WWW.StartWWW();
                            break;                         
                        default: break;
                    }
                }
            }
        }
    }
}
