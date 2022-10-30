using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class WWW
    {
        public static void StartWWW()
        {
            string haslo = "KINGA";
            string imie;           
            
                Console.Write(" Witaj na stronie Powiatowego Urzędu Pracy.\n Zaloguj się: ");
                imie = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Użytkownik " + imie + " podaj hasło: ") ;
                Console.WriteLine();
                haslo = Console.ReadLine();
                
                if (haslo == "kinga")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("MASZ 1 NOWĄ WIADOMOŚĆ:");
                    Console.ResetColor();
                    Console.WriteLine("Zgłosił się do pracy nowy pracownik. Od dzisiaj jest u Ciebie na stażu. Jego nazwisko to Marian Wiaderko.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Brawo! Zyskałeś 50 pkt doświadczenia oraz stażystę!");
                    Console.ResetColor();
                    ProsteMenu.LP =50;
                    ProsteMenu.asystent = true;
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Błąd logowania");
                    Console.Read();
                }

            Console.Clear();
            Console.WriteLine("Czy chcesz zalogować się ponownie?");
            Console.WriteLine("Y/N");
            Console.WriteLine();


            ConsoleKeyInfo klawisz5 = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza
            switch (klawisz5.Key)
            {
                case ConsoleKey.Y:   //ConsoleKey  Y, Enter - celem zatwierdzenia powrotu do menu głównego / N, Esc, Q - celem wyjścia z konsoli
                case ConsoleKey.Enter:
                    Console.Clear();
                    WWW.StartWWW();
                    Console.Clear();
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
