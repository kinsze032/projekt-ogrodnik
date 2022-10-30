using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Sklep: Towary
    {

         public static void StartSklep()
         {            
             while (true)             // pętla nieskończona, o jej skończoności decyduje wciśnięcie klawisza
             {
                 Console.Clear();
                 Console.WriteLine("Co chcesz kupić?");
                 Console.WriteLine("1. Kosiarka (szt.)");
                 Console.WriteLine("2. Łopata (szt.)");
                 Console.WriteLine("3. Sekator (szt.)");
                 Console.WriteLine("4. Huśtawka dziecięca");
                 Console.WriteLine("5. Drzewo - orzech włoski (szt.)");
                 Console.WriteLine("6. Drzewo - wiśnia (szt.)");
                 Console.WriteLine("7. Trawa (kg)");
                 Console.WriteLine("8. Krzewy (szt.)");
                 Console.WriteLine();
                 Console.WriteLine("Q - wyjście");
                 Console.WriteLine("C - Wróć do Menu Głównego");
                 Console.WriteLine();

                 Console.Write("Wybierz jedną czynność: ");
                 ConsoleKeyInfo czynnosc = Console.ReadKey(); //czekam na wciśnięcie dowolnego klawisza z listy 1-4 oraz q
                 switch (czynnosc.Key)
                 {
                     case ConsoleKey.D1:   
                        if(ProsteMenu.kosiarka)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Posiadasz już kosiarkę");
                        }
                        else
                        {
                            ProsteMenu.kosiarka = true;
                            ProsteMenu.LP += 1;
                            Console.WriteLine();
                            Console.WriteLine("Kupiłeś kosiarkę");
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        if (ProsteMenu.lopata)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Posiadasz już łopatę");
                        }
                        else
                        {
                            ProsteMenu.lopata = true;
                            ProsteMenu.LP += 1;
                            Console.WriteLine();
                            Console.WriteLine("Kupiłeś łopatę");
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        if (ProsteMenu.sekator)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Posiadasz już sekator");
                        }
                        else
                        {
                            ProsteMenu.sekator = true;
                            ProsteMenu.LP += 1;
                            Console.WriteLine();
                            Console.WriteLine("Kupiłeś sekator. Nie potrzebujesz go, ale za to wyglądasz profesjonalnie");
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        if (ProsteMenu.hustawka)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Posiadasz już huśtawkę");
                        }
                        else
                        {
                            ProsteMenu.hustawka = true;
                            ProsteMenu.LP += 1;
                            Console.WriteLine();
                            Console.WriteLine("Kupiłeś huśtawkę dziecięcą");
                        }
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        ProsteMenu.drzewo_Orzech += 1;
                        ProsteMenu.LP += 1;
                        Console.WriteLine();
                        Console.WriteLine("Kupiłeś jedną sadzonkę orzecha włoskiego");
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D6:
                        ProsteMenu.drzewo_Wisnia += 1;
                        Console.WriteLine();
                        Console.WriteLine("Kupiłeś jedną sadzonkę wiśni");
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D7:
                        ProsteMenu.trawa += 1;
                        Console.WriteLine();
                        Console.WriteLine("Kupiłeś trawę");
                        Console.WriteLine("Obecnie posiadasz: " + ProsteMenu.trawa + " kg");
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D8:
                        ProsteMenu.krzewy += 1;
                        Console.WriteLine();
                        Console.WriteLine("Kupiłeś jedną sadzonkę krzewu \n Obecnie posiadasz: " + ProsteMenu.krzewy + " szt.");
                        Console.WriteLine("Wciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.C:
                         ProsteMenu.StartProsteMenu();
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
}
                           