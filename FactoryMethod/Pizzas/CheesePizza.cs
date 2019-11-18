using FactoryMethodPattern.PizzaStores;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Pizzas
{
    class CheesePizza : Pizza
    {
        PizzaIngredientFactory IngredientFactory { get; set; }

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
            Console.WriteLine($"Creating {Name}: {ToString()}");
        }
    }
}
