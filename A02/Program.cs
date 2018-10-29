using System;

namespace A02
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 42;
            var pi = 3.141592f;
            var salute = "Hellouw ♥";
            
            Console.WriteLine(i.GetType());
            Console.WriteLine(pi.GetType());
            Console.WriteLine(salute.GetType());
        }
    }
}
