using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);

            Console.ReadKey();
        }

        static void Fact(int n)
        {
            int s = 1;
            for (int i = 1; i < n; i++)
            {
                s *= i;
                Thread.Sleep(200);
            }
            Console.WriteLine(s);
        }

        static async void FactAsync(int n)
        {
            await Task.Run(() => Fact(n));
        }
    }
}
