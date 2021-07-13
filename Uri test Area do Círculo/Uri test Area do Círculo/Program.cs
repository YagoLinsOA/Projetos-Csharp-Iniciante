using System;
using System.Globalization;

namespace Uri_test_Area_do_Círculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio, Pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = Pi * raio * raio;

            Console.WriteLine("A =" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
