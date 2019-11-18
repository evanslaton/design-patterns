using FactoryMethodPattern.IngedientsFactories;
using FactoryMethodPattern.Pizzas;
using FactoryMethodPattern.PizzaStores;

namespace FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string typeOfPizza)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (typeOfPizza.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }

            return pizza;
        }
    }
}
