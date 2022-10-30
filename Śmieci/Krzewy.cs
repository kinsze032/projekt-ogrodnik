using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Krzewy: Towary
    {

        public Krzewy(string nazwaKrzewu, int iloscSztuk)
        {
            nazwa = nazwaKrzewu;
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


