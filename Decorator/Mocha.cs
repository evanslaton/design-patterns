namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        public Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost() => .20 + beverage.Cost();

        public override string GetDescription() => $"{beverage.GetDescription()}, Mocha";
    }
}
