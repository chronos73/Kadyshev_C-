using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            
            int[,] mass = new int[n, n];


            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = -1;
                    //mass[i, j] = 0;
                    Console.Write("{0,3}", mass[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
