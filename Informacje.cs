using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Informacje
    {
    
        public static void StartInformacje()
        {
                       
            
            Console.Clear();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Kupiłeś: ");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Ilość posiadanych drzew Orzech włoski: " + ProsteMenu.drzewo_Orzech);
            Console.WriteLine("Ilość posiadanych drzew Wiśnia: " + ProsteMenu.drzewo_Wisnia);
            Console.WriteLine("Ilość posiadanej trawy: " + ProsteMenu.trawa);
            Console.WriteLine("Ilość posiadanych krzewów: " + ProsteMenu.krzewy);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sprzęt:");    //Sprzęt
            Console.ResetColor();

            Console.WriteLine();
            if (ProsteMenu.kosiarka == false)
                Console.WriteLine("Kosiarka: brak");
            else
                Console.WriteLine("Kosiarka: zakupiona");


            if (ProsteMenu.lopata == false)
                Console.WriteLine("Łopata: brak");
            else
                Console.WriteLine("Łopata: zakupiona");


            if (ProsteMenu.sekator == false)
                Console.WriteLine("Sekator: brak");
            else
                Console.WriteLine("Sekator: zakupiony");
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Wykonane zadania: ");  // Zadania
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Zadanie 1:");
            if (ProsteMenu.skoszenieTrawnika == false)
                Console.WriteLine("Zadanie nie wykonane");
            else
                Console.WriteLine("Zadanie wykonane.");
            Console.WriteLine();

            Console.WriteLine("Zadanie 2");            //aby zamontować huśtawkę dziecięcą musisz posiadać: łopatę, drzewo orzecha włoskiego i huśtawkę");
            if (ProsteMenu.zamontowanieHustawki)
                Console.WriteLine("Zadanie wykonane");
            else
                Console.WriteLine("Zadanie nie wykonane");
            Console.WriteLine();
            Console.WriteLine("Zadanie 3"); //Chociaż raz musisz wyplewić jakiś trawnik");
            if (ProsteMenu.usuniecieChwastow == false)
                Console.WriteLine("Zadanie nie wykonane");
            else
                Console.WriteLine("Zadanie wykonane");
            Console.WriteLine();
            Console.WriteLine("Zadanie 4"); //"Aby zasadzić krzewy musisz posiadać: krzewy i łopatę");
            if (ProsteMenu.zasadzenieKrzewow)
                Console.WriteLine("Zadanie wykonane");
            else
                Console.WriteLine("Zadanie nie wykonane");
            Console.WriteLine();
            Console.WriteLine("Zadanie 5"); //Chociaż raz musisz zapolować na krety");
            if (ProsteMenu.polowanieNaKreta)
                Console.WriteLine("Zadanie wykonane");
            else
                Console.WriteLine("Zadanie nie wykonane");
            Console.WriteLine();
            Console.WriteLine("Zadanie 6"); //musisz zagrać w krety i potem zalogować się na WWW PUP");
            if (ProsteMenu.zatrudnienieAsystenta)
                Console.WriteLine("Zadanie wykonane");
            else
                Console.WriteLine("Zadanie nie wykonane");
            Console.WriteLine();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Zatrudnieni pomocnicy: ");   //pomocnicy
            Console.ResetColor();

            if (ProsteMenu.asystent == false)
                Console.WriteLine("Nie masz zatrudnionych pomocników");
            else
                Console.WriteLine("Masz pomocnika. Marian Wiaderko jest u Ciebie na stażu.");

            
            // nie da się zatrudnić nikogo. Po odganięciu hasła z liter przypisanych kretom
            // w grze KRET, po wpisaniu HASŁA: na stronie WWW pojawia się asystent Marian Wiaderko
            
            Console.WriteLine();                                 
            Console.ReadLine();
           
            

        } 
    }
}
