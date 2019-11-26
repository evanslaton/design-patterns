using System;

namespace TemplateMethod
{
    public class Tea : CaffeineBeverageWithHook
    {
        public override void Brew() => Console.WriteLine("Steeping tea");
        public override void AddCondiments() => Console.WriteLine("Adding lemon");
        public override bool CustomerWantsCondiments()
        {
            return GetUserInput().ToLower().StartsWith("y") ? true : false;
        }

        private string GetUserInput()
        {
            Console.WriteLine("\nLemon (y/n)?");
            return Console.ReadLine();
        }
    }
}
