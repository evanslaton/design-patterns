namespace FactoryMethodPattern
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY style sauce and cheese pizza with veggies.";
            Dough = "Thin crust dough.";
            Sauce = "Marinara Sauce.";
            Toppings.Add("Grated reggiano cheese");
            Toppings.Add("Olives");
            Toppings.Add("Onions");
        }
    }
}
