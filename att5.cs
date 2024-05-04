namespace lista6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[4, 4];

            Random r = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = r.Next(0, 10);
                }
            }

            Console.WriteLine("\n");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");

                }
            
                Console.WriteLine("\n");
            }

            if (matriz[1,0] == 0 && matriz[2,0] == 0 && matriz[2,1] == 0 && matriz[3,0] == 0 && matriz[3,1] == 0 && matriz[3, 2] == 0 )
            {
                Console.WriteLine("A matriz e Matriz triangular superior");
            }
            else
            {
                Console.WriteLine("A matriz não e Matriz triangular superior");
            }


        }
    }

}
    

