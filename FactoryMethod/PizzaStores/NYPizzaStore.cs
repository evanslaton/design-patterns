namespace FactoryMethodPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string typeOfPizza)
        {
            switch (typeOfPizza)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "veggie":
                    return new NYStyleVeggiePizza();
                case "pepperoni":
                    return new NYStylePepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
