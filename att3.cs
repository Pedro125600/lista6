using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
        {
            int op , n = 0;


            Random r = new Random();
            int[,] m1;
            int[,] m2; 
            do
            {
                Console.WriteLine($"1. Soma matricial \n2.Subtração matricial \n3.Multiplicar uma matriz por um número real \n4.Sair");
                Console.Write($"Escolha a opção:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: Console.Write("De a dimenção das matrizes:");
                            n = int.Parse(Console.ReadLine());
                        m1 = new int[n, n];
                        m2 = new int[n, n];

                        Console.WriteLine("Matriz 1");
                        for (int i = 0; i < m1.GetLength(0); i++)
                        {


                            for (int j = 0; j < m1.GetLength(1); j++)
                            {
                                m1[i, j] = r.Next(10);
                                Console.Write(m1[i, j] + " ");
                            }

                            Console.WriteLine("\n");
                        }

                        Console.WriteLine("Matriz 2");
                        for (int i = 0; i < m2.GetLength(0); i++)
                        {


                            for (int j = 0; j < m2.GetLength(1); j++)
                            {
                                m2[i, j] = r.Next(10);
                                Console.Write(m2[i, j] + " ");
                            }

                            Console.WriteLine("\n");
                        }

                        Console.WriteLine("Soma");
                        for (int i = 0; i < m1.GetLength(0); i++)
                        {


                            for (int j = 0; j < m1.GetLength(1); j++)
                            {
                                Console.Write(m1[i, j] + m2[i,j] + " ");
                            }

                            Console.WriteLine("\n");
                        }

                        break;

                    case 2:
                        Console.Write("De a dimenção das matrizes:");
                        n = int.Parse(Console.ReadLine());

                        m1 = new int[n, n];
                        m2 = new int[n, n];


                        Console.WriteLine("Matriz 1");
                        for (int i = 0; i < m1.GetLength(0); i++)
                        {


                            for (int j = 0; j < m1.GetLength(1); j++)
                            {
                                m1[i, j] = r.Next(10);
                                Console.Write(m1[i, j] + " ");
                            }

                            Console.WriteLine("\n");
                        }

                        Console.WriteLine("Matriz 2");
                        for (int i = 0; i < m2.GetLength(0); i++)
                        {


                            for (int j = 0; j < m2.GetLength(1); j++)
                            {
                                m2[i, j] = r.Next(10);
                                Console.Write(m2[i, j] + " ");
                            }

                            Console.WriteLine("\n");
                        }

                        Console.WriteLine("Subtração");
                        for (int i = 0; i < m1.GetLength(0); i++)
                        {


                            for (int j = 0; j < m1.GetLength(1); j++)
                            {
                                Console.Write(m1[i, j] - m2[i, j] + " ");
                            }

                            Console.WriteLine("\n");
                        }

                        break;


                }



            } while (op != 4);


        }
    }
}
