    using System;
    using System.Globalization;


    namespace Teste
    {
        class Program
        {
            static void Main(string[] args)
            {
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double percentual;
                if (salario <= 400.0)
                {
                    percentual = 15.0;
                }
                else if (salario <= 800)
                {
                    percentual = 12.0;
                }
                else if (salario <= 1200)
                {
                    percentual = 10.0;
                }
                else if (salario <= 2000)
                {
                    percentual = 7.0;
                }
                else
                {
                    percentual = 4.0;
                }

                double reajuste = salario * percentual / 100.0;
                double Novosalario = salario + reajuste;

                Console.WriteLine("Novo salario: " + Novosalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
            }
        }
    }    


        
    

