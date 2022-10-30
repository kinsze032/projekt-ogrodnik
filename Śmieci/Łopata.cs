using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Lopata: Towary
    {
        public Lopata (string nazwaLopaty, int iloscSztuk)
        {
            nazwa = nazwaLopaty;
            liczba = iloscSztuk;
        }
        public override void kopie()
        {
            Console.WriteLine( "Trzymasz w ręku: " + nazwa + "Możesz zacząć kopać");
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
