/* using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10, M = 10;
            var a = CreateSnakeArrayVsClock(N, M);
 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
 
 
            Console.ReadKey();
        }
 
        private static int[,] CreateSnakeArrayVsClock(int n, int m)
        {
            var arr = CreateSnakeArray(n, m);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n/2; j++)
                {
                    var tmp = arr[i, j];
                    arr[i, j] = arr[i, m - j - 1];
                    arr[i, m - j - 1] = tmp;
                }
            }
            return arr;
        }
  */
int[,] CreateSnakeArray(int n, int m)
{
    int[,] A = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for (int i = 0; i < A.Length; i++)
    {
        A[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return A;
}
void PrintArray(int[,] args)
{
    for (int i = 0; i < args.GetLength(0); i++)
    {
        for (int j = 0; j < args.GetLength(1); j++)
        {
            Console.Write(args[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] mass = CreateSnakeArray(4, 4);
PrintArray(mass);