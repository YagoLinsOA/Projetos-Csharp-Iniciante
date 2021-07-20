using System;
using System.Globalization;

namespace Uri_test_Gasto_de_Combustível
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidadeMedia;
            double litros;
            tempo = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            litros = (tempo * velocidadeMedia) / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
