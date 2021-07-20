using System;
using System.Globalization;
namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("PROGRAMA DE CALCULO M² DE TERRENOS");
            Console.WriteLine("ENTRE COM O COMPRIMENTO DO SEU TERRENO: ");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTRE COM A LARGURA DO SEU TERRENO: ");
            double Y = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTRE COM O VALOR DO M² DA SUA REGIÃO: ");
            double valor = double.Parse(Console.ReadLine());

            double area = X * Y;
            double preco = area * valor;

            Console.WriteLine("A AREA DO SEU TERRENO É DE: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O PREÇO DO SEU TERRENO É DE: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            

            













        }
    }
}
