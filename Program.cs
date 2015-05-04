using System;

namespace LambdaExpressions
{
    public delegate void DoWork(int duration);
    public delegate int DoCalculation(int val1, int val2);
    public delegate bool ProcessTask();

    public class Program
    {
        public static void Main(string[] args)
        {
            var doWorkHandler = new DoWork(d =>
            {
                if(d <= 0) return;

                for (int i = 0; i < d; i++)
                {
                    Console.WriteLine("Working");
                }
            });

            doWorkHandler(12);

            var doCalculationHandler = new DoCalculation((val1, val2) => val1 + val2);

            var sum = doCalculationHandler(2, 10);
            Console.WriteLine(sum);

            var processTaskHandler = new ProcessTask(() =>
            {
                Console.WriteLine("Do Some Work");
                return true;
            });

            processTaskHandler();

            Console.ReadKey();
        }
    }
}
