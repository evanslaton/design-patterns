using CompoundPattern.quackables;

namespace CompoundPattern.goosefactories
{
    public abstract class AbstractGooseFactory
    {
        public abstract GooseAdapter CreateGoose();
    }
}
