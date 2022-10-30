using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Trawa: Towary
    {
        
        public Trawa(string nazwaTrawy, int iloscSztuk)
        {
            nazwa = nazwaTrawy;
            liczba = iloscSztuk;
        }

        public override void kupuje()
        {
            Console.WriteLine("Kupiłeś: " + nazwa + ", sztuk: " + liczba);
        }
        public override void zniszczyc()
        {
            Console.WriteLine("Zniszczyłeś: " + nazwa + ", sztuk: " + liczba);
        }
        public override void sieje()
        {
            Console.WriteLine("Posiałeś: " + nazwa + ", sztuk: " + liczba);
        }
        public override void plewi()
        {
            Console.WriteLine("Wyplewiłeś " + nazwa + ", sztuk: " + liczba);
        }
    }
}
