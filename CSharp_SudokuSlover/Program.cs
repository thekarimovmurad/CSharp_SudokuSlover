using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_SudokuSlover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[,] array = new int[9, 9];
            array[0, 0] = 3;
            array[1, 1] = 4;
            //while (true)
            //{
            //    Console.Clear();
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        if (array[i - 1, j - 1] >= 1 && array[i - 1, j - 1] <= 9) { }
                        else
                        {
                            int number = random.Next(1, 10);
                            //if (number == )
                            array[i - 1, j - 1] = number;
                        }
                    }
                }
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        Console.Write(array[j - 1, i - 1]);
                    }
                    Console.WriteLine("\n");
                }
            //    Thread.Sleep(60000);
            //}

        }
    }
}
