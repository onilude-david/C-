using System;

namespace Kaz
{
    class Program
    {
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please Kazzem Input Your Value: ");
            int count = Int32.Parse( Console.ReadLine());
            Console.Write(p1 + " " + p2);
            Fibonacci(count - 2);
            Console.WriteLine();
        }

        private static void Fibonacci(int count)
        {
           if(count>0)
           {
               p3 = p1 + p2;
               Console.Write(" " + p3);
               p1 = p2;
               p2 = p3;
               Fibonacci(count - 1);
           }
        }
    }
}
