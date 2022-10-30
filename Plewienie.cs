using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Plewienie
    {
               

        public static void PlewienieThread()
        {
            Console.Clear();
            Console.Title = "PLEWIENIE";
            Console.WriteLine("Chwasty...sporo ich... chyba trochę to potrwa");
            Console.WriteLine();
            Thread.Sleep(6000);
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Wyrwałeś chwasta nr " + i );
                Thread.Sleep(10000);  // wątek zostanie zastrzymany na 10 sekund
            }
            Console.WriteLine();
            Console.WriteLine("Wciśnij dowolny klawisz");
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();    //czyszczenie konsoli
            Console.SetCursorPosition(30, 16); 
            Console.WriteLine("Hmmmm.... Chyba wszystkie wyrwane...");
            Console.ResetColor();  // kasowanie ustawionego koloru
            Console.WriteLine();
            Console.WriteLine("Wciśnij dowolny klawisz");
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;  //zmiana koloru czcionki na czerwony
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("Cholera! Widzę jeszcze kilka...");
            Console.ResetColor(); //kasowanie ustawionego koloru
            Console.WriteLine();
            Thread.Sleep(5000);

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Wyrwałeś chwasta nr " + i);
                Thread.Sleep(10000);  // wątek zostanie zastrzymany na 10 sekund
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gratulacje. Wyrwałeś wszystkie chwasty.");
            Console.WriteLine();
            Console.WriteLine("Straciłeś -20 punktów zdrowia oraz zdobyłeś +30 pkt doświadczenia");
            Console.ResetColor();
            Console.Read();
            ProsteMenu.usuniecieChwastow = true;
            ProsteMenu.HP -= 20;
            ProsteMenu.LP += 30;
            Console.WriteLine();
            Console.WriteLine("Wciśnij dowolny klawisz");
            Console.ReadKey();

        }
        
    }
}

