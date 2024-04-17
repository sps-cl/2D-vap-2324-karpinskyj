using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Úkol2
{
    public class ComplexNumber
    {
        public double Real { get; set; } 
        public double Imaginary { get; set; } 

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            double realResult = Real + other.Real;
            double imaginaryResult = Imaginary + other.Imaginary;
            return new ComplexNumber(realResult, imaginaryResult);
        }

        public ComplexNumber Subtract(ComplexNumber other)
        {
            double realResult = Real - other.Real;
            double imaginaryResult = Imaginary - other.Imaginary;
            return new ComplexNumber(realResult, imaginaryResult);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej první komplexní číslo");
            Console.Write("Reálna část prvního čísla: ");
            double real1 = double.Parse(Console.ReadLine());
            Console.Write("Imaginarní část prvního čísla: ");
            double imaginary1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nZadej druhý komplexní číslo");
            Console.Write("Realná část druhého čísla: ");
            double real2 = double.Parse(Console.ReadLine());
            Console.Write("Imaginarní část druhého čísla: ");
            double imaginary2 = double.Parse(Console.ReadLine());

            ComplexNumber complex1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber complex2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber soucet = complex1.Add(complex2);
            ComplexNumber rozdil = complex1.Subtract(complex2);

            Console.WriteLine($"\nSoučet: {soucet.Real} + {soucet.Imaginary}i");
            Console.WriteLine($"Rozdíl: {rozdil.Real} + {rozdil.Imaginary}i");
            Console.ReadLine();
        }
    }
}
