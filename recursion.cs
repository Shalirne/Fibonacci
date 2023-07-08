using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace fibonacci
{
    public class RecursionFibonacci
    {
        public void recursion()
        {
            var timer5 = new Stopwatch();
            var timer10 = new Stopwatch();
            var timer20 = new Stopwatch();

            int fibonacci (int n)
            {
                if (n== 0 || n == 1) 
                {
                    return n;
                }
                else
                {
                    return (fibonacci(n-1) + fibonacci(n - 2));
                }
            }
            timer5.Start();
            int fibonacci5 = fibonacci(5);
            timer5.Stop();

            timer10.Start();
            int fibonacci10 = fibonacci(10);
            timer10.Stop();


            timer20.Start();
            int fibonacci20 = fibonacci(20);
            timer20.Stop();
            Console.WriteLine($"Пятое число фибоначи = {fibonacci5} - время вычисления в рекурсии- {timer5.Elapsed.Microseconds} миллисекунды");
            Console.WriteLine($"Десятое число фибоначи = {fibonacci10} - время вычисления в рекурсии - {timer10.Elapsed.Microseconds} миллисекунды");
            Console.WriteLine($"Двадцатое число фибоначи = {fibonacci20} - время вычисления в рекурсии - {timer20.Elapsed.Microseconds} миллисекунды");
        }
    }
}