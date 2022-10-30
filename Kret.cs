using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Kret
    {
        public static string odkrytaLitera1 = "_";
        public static string odkrytaLitera2 = "_";
        public static string odkrytaLitera3 = "_";
        public static string odkrytaLitera4 = "_";
        public static string odkrytaLitera5 = "_";

        public static void StartPolowanie()
        {
            while (true)
            {
                if (SprawdzCzyOdkryteWszystkie())
                {
                    ProsteMenu.polowanieNaKreta = true;
                    ProsteMenu.HP -= 10;
                    ProsteMenu.LP += 50;
                    if (ProsteMenu.HP > 100)
                    {
                        ProsteMenu.HP = 100;
                    }
                    Console.Clear();
                    Console.WriteLine("GRATULACJĘ!");
                    Console.WriteLine();
                    Console.WriteLine("Zdobyłeś + 50 pkt doświadczenia i straciłeś -10 pkt zdrowia");
                    Console.WriteLine("Wciśnij dowolny klawisz aby ją odczytać");
                    Console.ReadKey();
                    Console.WriteLine(SprawdzOdkryteLitery());
                    Console.ReadKey();
                    return;

                }
                Console.Clear();
                Console.Title = "POLOWANIE NA KRETY"; //tytuł konsoli
                Console.WriteLine("KRETY... znalezienie ich nie będzie takie łatwe... postaraj się znaleźć wszystkie ukryte pod literami Twojej klawiatury: " + SprawdzOdkryteLitery());
                Console.WriteLine();
                Console.Write("Zacznij szukać:\n (naciśnij klawisz)");

                ConsoleKeyInfo klawisz2 = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza
                switch (klawisz2.Key)
                {
                    case ConsoleKey.K:
                        odkrytaLitera1 = "K";
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Złapałeś KRETA nr 1! Brawo");
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.I:
                        odkrytaLitera2 = "I";
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Złapałeś KRETA nr 2! Brawo");
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.N:
                        odkrytaLitera3 = "N";
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Złapałeś KRETA nr 3! Brawo");
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.G:
                        odkrytaLitera4 = "G";
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Złapałeś KRETA nr 4! Brawo");
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.A:
                        odkrytaLitera5 = "A";
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Złapałeś KRETA nr 5! Brawo");
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F1:
                        Console.Clear();
                        Console.WriteLine("POMOC: Każdy kret ma przypisaną pojedynczą literę.\nUłożone kolejno tworzą hasło.\n\nWarto je odgadnąć i zapamiętać ;)");
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("BYŁO BLISKO. Niestety uciekł...szukaj dalej");
                        Console.WriteLine();
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;

                }
                Console.WriteLine();

                Console.Clear();
                Console.WriteLine("Czy chcesz poszukać kolejnego kreta?");
                Console.WriteLine("Y/N");
                Console.WriteLine();


                ConsoleKeyInfo klawisz1 = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza
                switch (klawisz1.Key)
                {
                    case ConsoleKey.Y:   //ConsoleKey  Y, Enter - celem zatwierdzenia powrotu do menu głównego / N, Esc, Q - celem wyjścia z konsoli
                    case ConsoleKey.Enter:
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

        private static bool SprawdzCzyOdkryteWszystkie()
        {
            if (SprawdzOdkryteLitery() == "KINGA")
                return true;
            else
                return false;
        }

        private static string SprawdzOdkryteLitery()
        {
            return odkrytaLitera1 + odkrytaLitera2 + odkrytaLitera3 + odkrytaLitera4 + odkrytaLitera5;
        }
    }

}
