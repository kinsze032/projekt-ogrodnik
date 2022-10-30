using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    class Sekator : Towary
    {

        public Sekator(string nazwaSekatora, int iloscSztuk)
        {
            nazwa = nazwaSekatora;
            liczba = iloscSztuk;
        }
        public override void przycinac()
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
