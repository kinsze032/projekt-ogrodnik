using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Kosiarka : Towary
    {
        public Kosiarka(string nazwaKosiarki, int iloscSztuk)
        {
            nazwa = nazwaKosiarki;
            liczba = iloscSztuk;
        }
        public override void kosi()
        {
            Console.WriteLine("Trzymasz w ręku: " + nazwa + "Możesz zacząć kosić trawnik");
        }
        public override void kupuje()
        {
            Console.WriteLine("Kupiłeś: " + nazwa + ", sztuk: " + liczba);
        }
        public override void zniszczyc()
        { 
            Console.WriteLine("Zniszczyłeś: " + nazwa + ", sztuk: " + liczba);
        }

    }
}
    

