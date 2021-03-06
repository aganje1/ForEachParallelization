using System;

namespace SequentialForEach
{
    public class Program
    {
        public const int N = 1000000000;
        static int Addition(int a)
        {
            int result = 1 + a;
            return result;
        }

        static void Main()
        {
            int[] array = new int[N];

            Random rand = new Random();
            int i;

            for (i = 0; i < N - 1; i++)
            {
                array[i] = rand.Next(0, 1001);
            }

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            foreach (int element in array)
            {
                 i = Addition(element);  
            }

            watch.Stop();

            Console.WriteLine($"QuickSort Execution Time: {watch.ElapsedMilliseconds} ms.");
            Console.WriteLine($"QuickSort Execution Time: {watch.ElapsedMilliseconds * 1000000} ns.");

            Console.WriteLine("Would you like to print array? Type Y/N.");
            string printVar = Console.ReadLine();
            if (printVar == "Y" || printVar == "y")
            {
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
