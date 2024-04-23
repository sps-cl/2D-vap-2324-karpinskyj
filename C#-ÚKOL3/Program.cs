using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Úkol3
{
    class Slovnik
    {
        private List<string> slova;
        private int index;
        public Slovnik()

        {
            slova = new List<string>();
            index = -1;
        }

        public void PridatSlovo(string slovo)
        {
            slova.Add(slovo);
            index = slova.Count - 1;
            Console.WriteLine(slovo);
        }

        public void Zpet()
        {
            if (index > 0)
            {
                index--;
                Console.WriteLine(slova[index]);
            }

            else
            {
                Console.WriteLine(slova[0]);
            }
        }

        public void Vpred()

        {

            if (index < slova.Count - 1)
            {
                index++;
                Console.WriteLine(slova[index]);
            }

            else
            {
                Console.WriteLine(slova[slova.Count - 1]);
            }
        }
    }

    class Program

    {

        static void ZpracujPrikaz(Slovnik slovnik, string prikaz)

        {

            if (prikaz.StartsWith("Pridat:"))
            {
                string slovo = prikaz.Substring(7);
                slovnik.PridatSlovo(slovo);
            }

            else if (prikaz == "Zpet")
            {
                slovnik.Zpet();
            }

            else if (prikaz == "Vpred")
            {
                slovnik.Vpred();
            }

            else
            {
                Console.WriteLine("Neznámý příkaz");
            }

        }

        static void Main(string[] args)

        {

            Slovnik slovnik = new Slovnik();
            while (true)
            {
                string prikaz = Console.ReadLine();
                ZpracujPrikaz(slovnik, prikaz);
            }
        }
    }
}
