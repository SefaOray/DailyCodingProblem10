using System;
using System.Threading;
using System.Threading.Tasks;

namespace DailyCodingProblem10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void CallWithDelay<T>(Func<T> func, int delay)
        {
            Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(delay));
                func();
            });
        }
    }
}
