using System;
using System.Globalization;
namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] Mat;
            N = int.Parse(Console.ReadLine());

            Mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    Mat[i, j] = int.Parse(s[j]);

                }
            }
            for (int i = 0; i < N; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + Mat[i, j];
                }
                Console.WriteLine(soma);

            }
        }
    }
}
