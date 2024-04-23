using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Úkol3
{
    //Třídá slovník
    class Slovnik
    {
        private List<string> slova; //Seznam pro ukládání slov
        private int index; //Index aktuálního slova
        public Slovnik()

        {
            slova = new List<string>();
            index = -1;
        }

        //Metoda pro přidání slova do slovníku
        public void PridatSlovo(string slovo)
        {
            slova.Add(slovo); //Přidání slova do seznamu
            index = slova.Count - 1; //Nastavení inexu na poslední přidané slovo
            Console.WriteLine(slovo); //Výpis přidaného slova
        }

        //Metoda pro posunutí se zpět v seznamu slov
        public void Zpet()
        {
            if (index > 0)
            {
                index--;
                Console.WriteLine(slova[index]); //Výpis předchozího slova
            }

            else
            {
                Console.WriteLine(slova[0]); //Pokud jsme na začátku seznamu, vypíšeme první slovo
            }
        }

        //Metoda pro posunutí se vpřed v seznamu slov
        public void Vpred()

        {

            if (index < slova.Count - 1)
            {
                index++;
                Console.WriteLine(slova[index]); //Výpis následujícího slova
            }

            else
            {
                Console.WriteLine(slova[slova.Count - 1]); //Pokud jsme na konci seznamu, vypíšeme poslední slovo
            }
        }
    }

    class Program

    {

        //Metoda pro zpracování příkazu
        static void ZpracujPrikaz(Slovnik slovnik, string prikaz)

        {

            if (prikaz.StartsWith("Pridat:"))
            {
                string slovo = prikaz.Substring(7); //Získání slova ze vstupního řetězce
                slovnik.PridatSlovo(slovo); //Přidání slova do slovníku
            }

            else if (prikaz == "Zpet")
            {
                slovnik.Zpet(); //Posunutí se zpět v seznamu slov
            }

            else if (prikaz == "Vpred")
            {
                slovnik.Vpred(); //Posunutí se vpřed v seznamu slov
            }

            else
            {
                Console.WriteLine("Neznámý příkaz"); //Jestliže příkaz není rozpoznán, vypíše se "Neznámý příkaz"
            }

        }

        static void Main(string[] args)

        {

            Slovnik slovnik = new Slovnik(); //Vytvoření instance třídy Slovnik
            while (true)
            {
                string prikaz = Console.ReadLine(); //Načtení příkazu ze vstupu
                ZpracujPrikaz(slovnik, prikaz); //Zpracování příkazu
            }
        }
    }
}
