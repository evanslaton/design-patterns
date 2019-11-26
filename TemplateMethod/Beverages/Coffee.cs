using System;

namespace TemplateMethod
{
    public class Coffee : CaffeineBeverageWithHook
    {
        public override void Brew() => Console.WriteLine("Dripping coffee through filter");
        public override void AddCondiments() => Console.WriteLine("Adding sugar and milk");
        public override bool CustomerWantsCondiments()
        {
            return GetUserInput().ToLower().StartsWith("y") ? true : false;
        }

        private string GetUserInput()
        {
            Console.WriteLine("\nMilk and sugar (y/n)?");
            return Console.ReadLine();
        }
    }
}
