using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размер массива: ");
            int n = int.Parse(ReadLine());
            float sr = 0, s = 0;
            float[] a = new float[n];
            float[] b = new float[n];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = float.Parse(ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sr = 0;
                s = 0;
                b[i] = 0;
                for (int j = 0; j <= i; j++)
                {
                    s += a[j];
                    sr++;
                }
                b[i] = s / sr;
            }

            foreach (float x in a) { Write(x + " "); }
            WriteLine();
            foreach (float x in b) { Write(x + " "); }
        }
    }
}
