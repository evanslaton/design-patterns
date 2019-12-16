using System;

namespace Iterator
{
    public interface IIterator
    {
        Object Next();
        bool HasNext();
    }
}
