using CompoundPattern.quackables;

namespace CompoundPattern.goosefactories
{
    public class GooseDecoratorFactory : AbstractGooseFactory
    {
        public override GooseAdapter CreateGoose() => new GooseAdapter(new Goose());
    }
}
