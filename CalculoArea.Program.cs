using System;
using System.Globalization;

namespace Uri_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, At, Ac,Atrpz, Aq, Ar;
            double Pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');
             A = double.Parse(vet[0], CultureInfo.InvariantCulture);
             B = double.Parse(vet[1], CultureInfo.InvariantCulture);
             C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            At = A * C / 2;

            Ac = Pi * Math.Pow(C, 2);

            Atrpz = (A + B) * C / 2;

            Aq = Math.Pow(B, 2);

            Ar = A * B;

            Console.WriteLine("TRIANGULO: " + At.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + Ac.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + Atrpz.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + Aq.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + Ar.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
