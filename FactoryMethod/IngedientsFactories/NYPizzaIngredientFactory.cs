using FactoryMethodPattern.Ingredients.Cheese;
using FactoryMethodPattern.Ingredients.Clams;
using FactoryMethodPattern.Ingredients.Dough;
using FactoryMethodPattern.Ingredients.Pepperoni;
using FactoryMethodPattern.Ingredients.Sauce;
using FactoryMethodPattern.Ingredients.Veggies;
using FactoryMethodPattern.PizzaStores;

namespace FactoryMethodPattern.IngedientsFactories
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough() => new ThinCrustDough();
        public Sauce CreateSauce() => new MarinaraSauce();
        public Cheese CreateCheese() => new ReggianoCheese();
        public Pepperoni CreatePepperoni() => new SlicedPepperoni();
        public Clams CreateClams() => new FreshClams();
        public Veggies[] CreateVeggies()
        {
            return new Veggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }
}
