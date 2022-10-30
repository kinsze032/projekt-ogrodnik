using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class ProsteMenu2
    {
        public static void StartProsteMenu2()
        {

            Console.Title = "Wybór zadań";  //przypisanie tytułu 
            while (true)             // pętla nieskończona, o jej skończoności decyduje wciśnięcie klawisza
            {
           
                Console.Clear();
                Console.WriteLine("Lista zadań do wykonania");
                Console.WriteLine("1. Skoś trawnik");
                Console.WriteLine("2. Zamontuj huśtawkę dziecięcą");
                Console.WriteLine("3. Wytnij chwasty");
                Console.WriteLine("4. Zasadź krzewy");
                Console.WriteLine("5. Zapoluj na krety");
                Console.WriteLine("6. Zatrudnij pomocnika");
                Console.WriteLine();
                Console.WriteLine("C - powrót do menu");
                Console.WriteLine();

                Console.Write("Wybierz jedno zadanie: ");

                ConsoleKeyInfo klawisz1 = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza
                switch (klawisz1.Key)
                {
                    case ConsoleKey.D1:   //ConsoleKey enum D1 = 1, D2 =2, itd
                        Console.Clear();
                        if (!ProsteMenu.kosiarka)
                        {
                            Console.WriteLine("Aby skosić trawę potrzebujesz kosiarkę => Kup KOSIARKĘ");
                            Console.WriteLine();
                        }
                        else if (ProsteMenu.trawa < 51)
                        {
                            Console.WriteLine("Aby skosić trawę potrzebujesz kupić trawę, ok.50 sztuk. Jeżdżąc kosiarką po betonie zniszczysz ją..... Heeeeloooouu");
                            Console.WriteLine();
                        }
                        else
                        { 
                            ProsteMenu.skoszenieTrawnika = true;
                            Console.WriteLine("Skoszone! Dobra robota!");
                            Console.WriteLine();
                            Console.WriteLine("LP: + 15, HP: -15");
                            Console.WriteLine();
                            Console.WriteLine("Trafiłeś na bardzo trudny grunt do kopania. ZŁAMAŁEŚ ŁOPATĘ. Kup nową.");
                            ProsteMenu.trawa -= 50;
                            ProsteMenu.LP += 50;
                            ProsteMenu.HP -= 15;
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        if (!ProsteMenu.lopata)
                        {
                            Console.WriteLine("Aby zamontować huśtawkę dziecięcą musisz posiadać: łopatę");
                            Console.WriteLine();
                        }
                        else if (ProsteMenu.zasadzoneDrzewo_Orzech < 1)
                        {
                            Console.WriteLine("Aby zamontować huśtawkę dziecięcą musisz posiadać: drzewo orzecha włoskiego");
                            Console.WriteLine();
                        }
                        else if (!ProsteMenu.hustawka)
                        {
                            Console.WriteLine("Aby zamontować huśtawkę dziecięcą musisz posiadać: huśtawkę");
                            Console.WriteLine();
                        }
                        else
                        {
                            ProsteMenu.zamontowanieHustawki = true;
                            Console.WriteLine("Udało się skompletować potrzebne elementy i zamontować hustawkę!");
                            Console.WriteLine();
                            Console.WriteLine("LP: + 40, HP: -20");
                            Console.WriteLine();
                            Console.WriteLine("Trafiłeś na bardzo trudny grunt do kopania. ZŁAMAŁEŚ ŁOPATĘ. Kup nową.");
                            ProsteMenu.hustawka = false;
                            ProsteMenu.lopata = false;
                            ProsteMenu.drzewo_Orzech = 0;
                            ProsteMenu.LP += 40;
                            ProsteMenu.HP -= 20;
                            Console.WriteLine();
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        if (ProsteMenu.usuniecieChwastow)
                        {
                            Console.WriteLine("Wyplewiłeś ogródek. Dobra robota!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Aby wyrwać chwasty trzeba się trochę napracować.");
                            Console.WriteLine();
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                       
                        if (!ProsteMenu.lopata)
                        {
                            Console.WriteLine("Aby zasadzić krzewy musisz posiadać: łopatę");
                            Console.WriteLine();
                        }
                        else if (ProsteMenu.krzewy < 6)
                        {
                            Console.WriteLine("Aby zasadzić krzewy musisz kupić odpowiednią ich ilość - min. 5 krzewów");
                            Console.WriteLine();
                        }
                       
                        else
                        {
                            ProsteMenu.zasadzenieKrzewow = true;
                            Console.WriteLine("Udało Ci się skompletować wymaganą ilość i zasadzić krzewy!");
                            Console.WriteLine();
                            Console.WriteLine("LP: + 20, HP: -10");
                            Console.WriteLine("Trafiłeś na bardzo trudny grunt do kopania. ZŁAMAŁEŚ ŁOPATĘ. Kup nową.");
                            ProsteMenu.LP += 20;
                            ProsteMenu.HP -= 10;
                            ProsteMenu.krzewy -= 5;
                            ProsteMenu.lopata = false;
                            Console.WriteLine();
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        if (ProsteMenu.polowanieNaKreta)
                        {
                            Console.WriteLine("Pozbyłeś się wszystkich kretów. Dobra robota!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Idź i zapoluj na krety.");
                            Console.WriteLine();
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        if (!ProsteMenu.asystent)
                        {   
                            Console.WriteLine("Najłatwiej kogoś znaleść korzystając z pomocy Powiatowego Urzędu Pracy. Udaj się tam.");
                            Console.WriteLine();
                            
                        }
                        else
                        {
                            ProsteMenu.zatrudnienieAsystenta = true;
                            Console.WriteLine("Zatudniłeś Asystenta. Dobra robota!");
                            Console.WriteLine();
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        ProsteMenu.StartProsteMenu();
                        break;//metoda powoduje zakońćzenie procesu (wyjście z programu)
                    default: break;


                }
            }

        }
    }
}
