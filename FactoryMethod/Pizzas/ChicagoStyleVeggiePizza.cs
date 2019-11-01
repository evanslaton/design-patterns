namespace FactoryMethodPattern
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago style deep dish cheese pizza with veggies.";
            Dough = "Extra thick crust dough.";
            Sauce = "Plum tomato Sauce.";
            Toppings.Add("Shredded Mozzarella cheese");
            Toppings.Add("Olives");
            Toppings.Add("Onions");
        }
    }
}
