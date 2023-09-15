using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex. 1 - imprimir na tela diagonal principal e quantidade valores negativos da matriz

            //Console.WriteLine("Digite o tamanho da matriz: ");
            //int n = Convert.ToInt32((Console.ReadLine()));
            //int[,] mat = new int[n, n];

            //for (int linha = 0; linha < n; linha++)
            //{

            //    string[] linhavetor = Console.ReadLine().Split(' ');

            //    for (int coluna = 0; coluna < n; coluna++)
            //    {
            //        mat[linha, coluna] = Convert.ToInt32(linhavetor[coluna]);
            //    }

            //}

            //Console.WriteLine("Main Diagonal: ");

            //for (int i =0; i < n; i++) {
            //    Console.Write(mat[i, i] + " ");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("");
            ////Console.WriteLine("Negative numbers: ");

            //int count = 0;

            //for (int linha = 0; linha < n; linha++)
            //{

            //    for (int coluna = 0; coluna < n; coluna++)
            //    {
            //        if (mat[linha, coluna] < 0)
            //        {
            //            count++;
            //        }
            //    }

            //}

            //Console.WriteLine("Negative numbers = " + (count));

            //Console.ReadLine();


            //--------------------------------------------------------------------//
            //                        Exercicio fixação                           //

            Console.Write("Digite a matriz (linha): ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a matriz (coluna): ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[l, c];

            for (int linha = 0; linha < l; linha ++)
            {
                string[] vetor = Console.ReadLine().Split(' ');

                for (int coluna = 0; coluna < c; coluna++)
                {
                    matriz[linha, coluna] = Convert.ToInt32(vetor[coluna]);
                }
            }

            Console.Write("Selecione um número da matriz: ");
            int escolhanumero = Convert.ToInt32(Console.ReadLine());

            for (int linha = 0; linha < l; linha++)
            {
                for (int coluna = 0; coluna < c; coluna++)
                {
                    if (matriz[linha, coluna] == escolhanumero)
                    {
                        Console.WriteLine("Position: " + linha + ", " + coluna);

                        if (coluna > 0)
                        {
                            Console.WriteLine("Left: " + matriz[linha, (coluna - 1)]);
                        }
                        if (coluna < l - 1)
                        {
                            Console.WriteLine("Right: " + matriz[linha, (coluna + 1)]);
                        }
                        if (linha > 0)
                        {
                            Console.WriteLine("Up: " + matriz[(linha - 1), coluna]);
                        }
                        if (linha < c - 1)
                        {
                            Console.WriteLine("Down: " + matriz[(linha + 1), coluna]);
                        }

                    }

                }
            }

            Console.ReadLine();
        }
    }
}
