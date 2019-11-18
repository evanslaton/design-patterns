using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetInstance();
            ChocolateBoiler chocolateBoiler2 = ChocolateBoiler.GetInstance();

            Console.WriteLine("ChocolateBoiler:" + chocolateBoiler);
            Console.WriteLine("ChocolateBoiler2:" + chocolateBoiler2);

            chocolateBoiler.Fill();

            Console.WriteLine("\nFILL:");
            Console.WriteLine("ChocolateBoiler:" + chocolateBoiler);
            Console.WriteLine("ChocolateBoiler2:" + chocolateBoiler2);

            chocolateBoiler2.Boil();

            Console.WriteLine("\nBOIL:");
            Console.WriteLine("ChocolateBoiler:" + chocolateBoiler);
            Console.WriteLine("ChocolateBoiler2:" + chocolateBoiler2);

            chocolateBoiler.Drain();

            Console.WriteLine("\nDRAIN:");
            Console.WriteLine("ChocolateBoiler:" + chocolateBoiler);
            Console.WriteLine("ChocolateBoiler2:" + chocolateBoiler2);
        }
    }
}
