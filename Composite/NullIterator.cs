using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class NullIterator : IEnumerator
    {
        public Object Next() => null;
        public bool HasNext() => false;
        public void Remove() => throw new NotSupportedException();

        // Unused
        public object Current => throw new NotImplementedException();
        public bool MoveNext() => throw new NotImplementedException();
        public void Reset() => throw new NotImplementedException();
    }
}
