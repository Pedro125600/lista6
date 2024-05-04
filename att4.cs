namespace lista6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[500, 500];
            int[] somaLinha = new int[500];
            int[] somaColuna = new int[500];

            Random r = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
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
                    Console.Write(matriz[i, j] + " ");
                    somaL += matriz[i, j];

                }
                somaLinha[i] = somaL;
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
                somaColuna[i] = somaC;
            }


            int somaD = 0;
            for (int i = 0; i < 500; i++)
            {

                somaD += matriz[i, i];
            }

            Console.WriteLine("A soma da diagonal principal e " + somaD);

            int somaDS = 0;

            for (int i = 0, j = 500 - 1; i < 500; i++, j--)
            {
                somaDS += matriz[i, j];
            }

            Console.WriteLine("A soma da diagonal segundaria  e " + somaDS);

            int somaPadrao = somaLinha[0];
            for (int i = 1; i < somaLinha.Length; i++)
            {
                if (somaLinha[i] != somaPadrao || somaColuna[i] != somaPadrao )
                {
                    Console.WriteLine("Não e um Quadrado magico");
                }
            }

            if (somaD != somaPadrao || somaDS != somaPadrao)
            {
                Console.WriteLine("A matriz não é um quadrado mágico.");

            }
            else
            {
                Console.WriteLine("A matriz é um quadrado mágico.");
            }


        }
    }

}
    

