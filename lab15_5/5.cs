using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab15_5
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
            for (int i = 1; i < n; i++)
            {
                if (a[i - 1] > a[i])
                {
                    a[i - 1] = a[i] + a[i - 1];
                    a[i] = a[i - 1] - a[i];
                    a[i - 1] = a[i - 1] - a[i];
                }
            }


            foreach (int x in a) { Write(x + " "); }
        }
    }
}
