using System;

namespace csharp_monads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var intMonoid = new IntMonoid();
            Console.WriteLine(intMonoid.Combine(1, 2));
            Console.WriteLine(intMonoid.Combine(1, intMonoid.Combine(1, 1)));
            Console.WriteLine(intMonoid.Empty());
        }
    }

}
