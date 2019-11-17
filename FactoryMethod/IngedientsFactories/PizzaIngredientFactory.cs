using FactoryMethodPattern.Ingredients.Cheese;
using FactoryMethodPattern.Ingredients.Clams;
using FactoryMethodPattern.Ingredients.Dough;
using FactoryMethodPattern.Ingredients.Pepperoni;
using FactoryMethodPattern.Ingredients.Sauce;
using FactoryMethodPattern.Ingredients.Veggies;

namespace FactoryMethodPattern.PizzaStores
{
    interface PizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggies[] CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClams();
    }
}
