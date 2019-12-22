using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            int min = a[0];

            for (int i = 0; i < n; i++)
            {
                if ((a[i] % 2 != 0) && (a[i] < min))
                {
                    min = a[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                a[i] += min;
            }

            foreach (int x in a) { Write(x + " "); }
        }
    }
}
