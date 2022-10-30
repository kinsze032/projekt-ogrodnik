using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class StanGry
    {
        public static void CalaSzerokosc(string value)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;    //ustawia kolor tła konsoli.
            Console.ForegroundColor = ConsoleColor.Green;       // ustawia kolor czcionki
            Console.WriteLine(value.PadRight(Console.WindowWidth));  //wyświetla pas na całej szerokości konsoli od lewej strony)
            Console.ResetColor();       // kasuje ustawione wcześniej zmiany koloru i ustawia na domyślne
        } 
        
    }
}
