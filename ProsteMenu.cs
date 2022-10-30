using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; // używany pogrubia się
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class ProsteMenu
    {

        
        public static int HP = 100; //punkty zdrowia
        public static int LP = 1; // punkty doświadczenia

        // Asortyment (rośliny)
        public static int drzewo_Orzech = 0;
        public static int drzewo_Wisnia = 0;
        public static int zasadzoneDrzewo_Orzech = 1;
        public static int zasadzoneDrzewo_Wisnia = 1;
        public static int krzewy = 0;
        public static int trawa = 0;

        // Asortyment (narzędzia)
        public static bool hustawka = false;
        public static bool sekator = false;
        public static bool lopata = false;
        public static bool kosiarka = false;

        // pomocnik
        public static bool asystent = false;

        //wykonanie czynnośći
        public static bool skoszenieTrawnika = false;
        public static bool zamontowanieHustawki = false;
        public static bool usuniecieChwastow = false;
        public static bool zasadzenieKrzewow = false;
        public static bool polowanieNaKreta = false;
        public static bool zatrudnienieAsystenta = false;


        public static void StartProsteMenu()
        {
          
            Console.Title = "WITAJ W SYMULATORZE PRACY OGRODNIKA";  //przypisanie tytułu 
            while (true)             // pętla nieskończona, o jej skończoności decyduje wciśnięcie klawisza
            {
                if (SprawdzWygrana())
                {
                    Console.Clear();
                    StanGry.CalaSzerokosc($"           Energia(HP): {HP}       Doświadczenie(LP): {LP}       "); //$ - istotny , bez niego nie ma {HP} oraz {LP} = Interpolacja $-String (C# odwołanie)
                    Console.ResetColor();                                                                        
                    Console.WriteLine("Gratulacje!!! Wszystkie czynności zostały wykonane. Jesteś ZWYCIĘZCĄ.");
                    Thread.Sleep(3000);
                    Console.ReadLine();
                    return;

                }
                else if (HP <1)
                {
                    Console.Clear();
                    Console.WriteLine("Przepracowałeś się. Z wycięczenia padłeś. Koniec gry");
                    Thread.Sleep(3000);
                    Console.ReadLine();
                    return;
                }
                else
                {                                
                    Console.Clear();
                    StanGry.CalaSzerokosc($"           Energia(HP): {HP}       Doświadczenie(LP): {LP}       "); //$ - istotny , bez niego nie ma {HP} oraz {LP} = Interpolacja $-String (C# odwołanie)
                    Console.ResetColor();
                    Console.WriteLine();

                    Console.WriteLine("Założenia są proste. Aby skończyć grę musisz zrealizować WSZYSTKIE zadania. \n\n Co chcesz zrobić? \n\n Wybierz jedną z opcji\n");
                    Console.WriteLine("1. Wyświetl zadania");
                    Console.WriteLine("2. Wyświetl informacje o graczu");                                           // \n  - sekwencja znakowa oznaczająca nową linię
                    Console.WriteLine("3. SKLEP");
                    Console.WriteLine("4. Polowanie na krety");
                    Console.WriteLine("5. Plewienie");
                    Console.WriteLine("6. Zatrudnienie pomocnika");
                    Console.WriteLine("7. Rozrywka i regeneracja");
                    Console.WriteLine();
                    Console.WriteLine("Q - wyjście");
                    Console.WriteLine();
                    Console.Write("Wybierz co chcesz zrobić: ");

                    ConsoleKeyInfo klawisz1 = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza
                    switch (klawisz1.Key)
                    {
                        case ConsoleKey.D1:   //ConsoleKey enum D1 = 1, D2 =2, itd
                            ProsteMenu2.StartProsteMenu2();
                            Console.Clear();
                            break;
                        case ConsoleKey.D2:
                            Informacje.StartInformacje();
                            Console.Clear();
                            break;
                        case ConsoleKey.D3:
                            Sklep.StartSklep();
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                            Kret.StartPolowanie();
                            Console.Clear();
                            break;
                        case ConsoleKey.D5:
                            Plewienie.PlewienieThread();
                            Console.Clear();
                            break;
                        case ConsoleKey.D6:
                            Asystent.StartAsystent();
                            Console.Clear();
                            break;
                        case ConsoleKey.D7:
                            Console.Clear();
                            Console.WriteLine();
                            if (ProsteMenu.asystent == true)
                            {
                                Console.WriteLine("Razem z Marianem otwieracie PIWO i chwile rozmawiacie");
                                Thread.Sleep(5000);
                                HP += 10;
                                if (HP >100)    // HP nie może wzrosnąć powyżej 100 u gracza. 100% zdrowia to 100 %
                                {
                                    HP = 100;
                                }
                                LP += 20;
                                Console.WriteLine("Bla bla blaaaaaaaa.............hahaha ...... bla bla blaaaaa");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Uzyskałeś +10 pkt zdrowia oraz +20 pkt doświaczenia");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Otworzyłeś PIWO i siadasz na kanapie");
                                Thread.Sleep(6000);   // tutaj używamy wątku
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine();
                                Console.WriteLine("% % % % % % upiłeś się % % % % musisz chwilę odczekać, by wytrzeźwieć");
                                Console.WriteLine();
                                Console.WriteLine("Picie w samotności Ci nie służy... tracisz -10 pkt zdrowia");
                                Console.ResetColor();
                                Thread.Sleep(10000);
                                HP -= 10;                                
                                Console.WriteLine();
                                Console.Write("Czujesz się już lepiej, ale znalazłeś kupon miniLOTTO i postanowiłeś zagrać");
                                Thread.Sleep(4000);                               
                                Console.Read();
                                Loteria.StartLoteria();
                                Console.Clear();
                            }
                            break;
                        case ConsoleKey.Escape:
                        case ConsoleKey.Q:
                            Environment.Exit(0);
                            break;//metoda powoduje zakońćzenie procesu (wyjście z programu)
                        default: break;
                    }


                }
            }

        }

        private static bool SprawdzWygrana()
        {
            return skoszenieTrawnika && zamontowanieHustawki && usuniecieChwastow && zasadzenieKrzewow && polowanieNaKreta && zatrudnienieAsystenta;
        }
    }
}