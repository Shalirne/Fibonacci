using System.Diagnostics;

namespace fibonacci
{
    internal class Call
    {
        public static void Main(string[] args)
        {
            RecursionFibonacci recursion = new RecursionFibonacci();
            recursion.recursion();

            CycleFibonacci cycle = new CycleFibonacci();
            cycle.Call();
        }
    }
}