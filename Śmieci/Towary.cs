using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOgrodnik
{
    public class Towary
    {
        
        public int liczba;
        public string nazwa;


        virtual public void kopie()
        {
            Console.WriteLine("Ogrodnik kopie ");
        }

        virtual public void kupuje()
        {
            Console.WriteLine("Ogrodnik kupuje ");
        }

        virtual public void sadzi()
        {
            Console.WriteLine("Ogrodnik sadzi ");
        }

        virtual public void plewi()
        {
            Console.WriteLine("Ogrodnik plewi");
        }
        virtual public void przycinac()
        {
            Console.WriteLine("Ogrodnik przycina ");
        }
        virtual public void sieje()
        {
            Console.WriteLine("Ogrodnik sieje ");
        }
        virtual public void kosi()
        {
            Console.WriteLine("Ogrodnik kosi ");
        }
        virtual public void zniszczyc()
        {
            Console.WriteLine("Ogrodnik zniszczył ");
        }
    }
}
