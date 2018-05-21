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
            
            Console.Write("Введите размерность матрицы: ");
            int n = int.Parse(Console.ReadLine());
            int k = 0;//счетчик
            int[,] mat = new int[n, n];// объявление массива
            //Иницилизация массива
            for (int i = 0; i < mat.GetLength(0); ++i)
                for (int j = 0; j < mat.GetLength(1); ++j)
                    mat[i, j] = -1;
            //printMat(ref mat);
            while (k != n * n)
            {
                try
                {
                    Console.Write("Введите координаты ячейки матрицы по горизонтали от 0 до {0,1}: ", n - 1);
                    int i = int.Parse(Console.ReadLine());
                    Console.Write("Введите координаты ячейки матрицы по вертикали  от 0 до {0,1}: ", n - 1);
                    int j = int.Parse(Console.ReadLine());
                    Console.Write("Введите значение ячейки матрицы 0 или 1: ");
                    int z = int.Parse(Console.ReadLine());
                    while (z != 0 && z != 1)
                    {
                        Console.Write("Значение некорректно, введите значение ячейки матрицы 0 или 1: ");
                        z = int.Parse(Console.ReadLine());
                    }
                    mat[i, j] = z;
                    //Печать матрицы
                    printMat(ref mat);
                   // Console.WriteLine("K="+k);
                    if (k >= n - 1)
                    {
                        if (CheckMat(ref mat, n))
                        {
                            Console.ReadKey();
                            return;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введены некорректные значения, повторите!");
                    continue;
                }
                ++k;
            }
            Console.ReadKey();
        }
        static bool CheckMat(ref int[,] mass, int n)
        {
            bool flagHorizontal = false;
            bool flagVertical = false;
            bool flagDiagonalMain = true;
            bool flagDiagonalDop = true;
            for (int i = 0; i < n; ++i)
            {
                flagHorizontal = true;
                flagVertical = true;
                for (int j = 0; j < n-1; ++j)
                {
                    // смотрим по горизонтали
                    if (mass[i, j] != mass[i, j + 1] || mass[i, j] == -1)
                        flagHorizontal = false;
                    // смотрим по вертикали
                    if (mass[j, i] != mass[j, i] || mass[j, i] == -1/*||*/)
                        flagVertical = false;
                    if (!flagHorizontal && !flagVertical)
                        continue;
                    if (flagHorizontal)
                    {
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!! Есть совпадение по горизонтали !!!!!!!!!!!!!!!!!!!!");
                        return true;
                    }
                    if ( flagVertical)
                    {
                        if (i == j)
                            continue;
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!! Есть совпадение по вертикали !!!!!!!!!!!!!!!!!!!!");
                        return true;
                    }
                    if (i < n - 1)
                    {
                        // смотрим по диагонали
                        if (mass[i, i] != mass[i + 1, i + 1] || mass[i, i] == -1)
                            flagDiagonalMain = false;
                        if (mass[i, n - 1 - i] != mass[i + 1, n - i - 2] || mass[i, n - 1 - i] == -1)
                            flagDiagonalDop = false;
                    }
                }
            }
            if(flagDiagonalMain || flagDiagonalDop)
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!! Есть совпадение по диагонали !!!!!!!!!!!!!!!!!!!!");
            return flagDiagonalMain || flagDiagonalDop;
        }
        static void printMat(ref int[,] mat)//Печать матрицы
        {
            Console.WriteLine("**************************************");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("{0,3}", mat[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************************************");
        }
    }
}
