using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class CycleFibonacci
    {
        public Stopwatch Timer5 = new Stopwatch();
        public Stopwatch Timer10 = new Stopwatch();
        public Stopwatch Timer20 = new Stopwatch();


        public void Call()
        {
            Console.WriteLine($"Пятое число фибоначи = {Cycle5()} - время вычисления в цикле - {Timer5.Elapsed.Nanoseconds} наносекунд");
            Console.WriteLine($"Десятое число фибоначи = {Cycle10()} - время вычисления в цикле - {Timer10.Elapsed.Nanoseconds} наносекунд");
            Console.WriteLine($"Двадцатое число фибоначи = {Cycle20()} - время вычисления в цикле - {Timer20.Elapsed.Nanoseconds} наносекунд");
        }
        public int Cycle5()
        {
            Timer5.Start();
            int x1 = 1;
            int x2 = 1;
            int fibonacci;
            for (int i = 2; i < 5; i++)
            {
                int sum = x1 + x2;
                x1 = x2;
                x2 = sum;
            }
            Timer5.Stop();
            return x2;
        }

        public int Cycle10()
        {
            Timer10.Start();
            int x1 = 1;
            int x2 = 1;
            int fibonacci;
            for (int i = 2; i < 10; i++)
            {
                int sum = x1 + x2;
                x1 = x2;
                x2 = sum;
            }
            Timer10.Stop();
            return x2;
        }

        public int Cycle20()
        {
            Timer20.Start();
            int x1 = 1;
            int x2 = 1;
            int fibonacci;
            for (int i = 2; i < 20; i++)
            {
                int sum = x1 + x2;
                x1 = x2;
                x2 = sum;
            }
            Timer20.Stop();
            return x2;
        }

    }
}