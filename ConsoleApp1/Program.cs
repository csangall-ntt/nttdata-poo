using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
                Console.WriteLine("Hello world");

#if DEBUG
            Console.WriteLine("Debug version");
#endif

#else
            Console.WriteLine("Release version");
#endif

            if (i == 1)
                Console.WriteLine("Hello moon");
        }
    }
}
