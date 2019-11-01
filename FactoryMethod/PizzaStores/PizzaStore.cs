namespace FactoryMethodPattern
{
    public abstract class PizzaStore
    {

        public Pizza OrderPizza(string typeOfPizza)
        {
            Pizza pizza = CreatePizza(typeOfPizza);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public abstract Pizza CreatePizza(string typeOfPizza);
    }
}
