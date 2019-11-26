using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make Coffee:");
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.WriteLine("\nMake Tea:");
            Tea tea = new Tea();
            tea.PrepareRecipe();
        }
    }
}
