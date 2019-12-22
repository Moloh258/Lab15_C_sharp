using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k1 = 0, k2 = 0;
            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            int max = a[0], min = a[0];

            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                    k1 = i;
                }
                else
                {
                    max = a[i];
                    k2 = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (i > k1 && i < k2 || i < k1 && i > k2)
                {
                    a[i] = 0;
                }
            }

            foreach (int x in a) { Write(x + " "); }
        }
    }
}
