using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Drzewa:Towary
    {

        public Drzewa(string nazwaDrzewa, int iloscSztuk)
        {
            nazwa = nazwaDrzewa;
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
    }

}

