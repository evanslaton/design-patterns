namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        public Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost() => .10 + beverage.Cost();

        public override string GetDescription() => $"{beverage.GetDescription()}, Whip";
    }
}
