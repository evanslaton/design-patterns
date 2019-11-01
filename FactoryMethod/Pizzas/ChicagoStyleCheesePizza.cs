namespace FactoryMethodPattern
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago style deep dish cheese pizza.";
            Dough = "Extra thick crust dough.";
            Sauce = "Plum tomato Sauce.";
            Toppings.Add("Shredded Mozzarella cheese");
        }
    }
}
