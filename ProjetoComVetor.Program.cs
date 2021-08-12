using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vet;
            
            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] aux = Console.ReadLine().Split(' ');

            for (int i=0; i<N; i++)
            {
                vet[i] = int.Parse(aux[i]);
            }
            for (int i=0; i<N; i++)
            {
                if(vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                }
            }
            Console.WriteLine();

            int cont = 0;
            for (int i=0; i<N; i++)
            {
                if ( vet[i] % 2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine(cont);

        }
    }
}