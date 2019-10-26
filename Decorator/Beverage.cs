namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string Description { get; set; }

        public virtual string GetDescription() => Description;

        public abstract double Cost();
    }
}
