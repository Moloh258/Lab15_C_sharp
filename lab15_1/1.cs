using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace lab15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите размер массивов: ");
           
            int n = int.Parse(ReadLine());
            int t;
            int[] a = new int[n];
            int[] b = new int[n];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Write("B[{0}] = ", i);
                b[i] = int.Parse(ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                t = a[i];
                a[i] = b[i];
                b[i] = t;
            }

            foreach (int x in a)
            { Write(x + " "); }

            WriteLine();

            foreach (int x in b)
            { Write(x + " "); }
        }
    }
}
