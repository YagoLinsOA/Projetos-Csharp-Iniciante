using System;
using System.Globalization;
namespace Uri_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, volume;
            double pi = 3.14159;

            R = double.Parse(Console.ReadLine());

            volume = (4.0 / 3) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
