using System;

namespace matrizNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanioMatriz;
            Console.Write("ingrese el tamanio de la matriz:");
            tamanioMatriz =int.Parse(Console.ReadLine());

           int[,]matriz =new int[tamanioMatriz, tamanioMatriz];
            mostrarMatriz(matriz,tamanioMatriz);


        }

        static void mostrarMatriz(int[,] matriz,int tamMatriz)
        {
            for (int i = 0; i < tamMatriz; i++)
            {
                for (int j = 0; j < tamMatriz; j++)
                {
                    Console.Write(i + 1+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
