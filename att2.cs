using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz= new int[10, 10];


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        matriz[i, j] = 2 * i + 7 * j;
                    }

                    else if(i == j )
                    {
                        matriz[i, j] = 3 * (i * i) - 1;
                    }

                    else
                    {
                        matriz[i, j] = 4 * (i * i * i) - 5 * (j * j) + 1 ;
                    }
          
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {


                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");


                }

                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
