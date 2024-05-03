using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De o valor de N");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            Random r = new Random();

            for(int i = 0; i < matriz.GetLength(0); i++ )
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = r.Next(10);
                }
            }

            Console.WriteLine("\n");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
  
                int somaL = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j] +" " );
                    somaL += matriz[i, j];
               
                }
                Console.Write("Soma Linha:" + somaL);
                Console.WriteLine("\n");
            }

            Console.WriteLine($"Soma de Colunas  ");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int somaC = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somaC += matriz[j, i];
                }
                Console.WriteLine($"Soma Coluna {i}:  " + somaC);
            }


            int somaD = 0;
            for (int i = 0; i < n; i++)
            {

                somaD += matriz[i, i];
            }

            Console.WriteLine("A soma da diagonal principal e " + somaD);

            int somaDS = 0;

            for(int i = 0 , j = n - 1; i < n; i++ , j--)
            {
                somaDS += matriz[i,j];
            }

            Console.WriteLine("A soma da diagonal segundaria  e " + somaDS);


            Console.ReadLine();
        }
    }
}
