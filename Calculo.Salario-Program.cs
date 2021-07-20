using System;
using System.Globalization;

namespace Uri_teste_Calcuo_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER = int.Parse(Console.ReadLine());
            int TimeWorked = int.Parse(Console.ReadLine());
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = TimeWorked * priceHour;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
