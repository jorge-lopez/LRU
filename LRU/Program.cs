using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRU
{
    class Program
    {
        static int[,] LRUMatrix = new int[4, 4];
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Enter the number of the recently used PageFrame");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    AdjustLRU(n);
                }
                catch
                {
                    Console.WriteLine("The value entered is out of bounds or is not a number.");
                }

            }

        }

        private static void AdjustLRU(int n)
        {

            for (int j = 0; j < 4; j++)
            {
                LRUMatrix[n, j] = 1;
            }
            for (int i = 0; i < 4; i++)
            {
                LRUMatrix[i, n] = 0;
            }
            ShowPageFrames();
            
        }

        private static void ShowPageFrames()
        {
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(LRUMatrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
