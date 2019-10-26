namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        public Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost() => .15 + beverage.Cost();

        public override string GetDescription() => $"{beverage.GetDescription()}, Soy";
    }
}
