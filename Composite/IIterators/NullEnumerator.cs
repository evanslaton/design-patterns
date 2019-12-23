using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class NullEnumerator : IEnumerator
    {
        public object Current => throw new NotImplementedException();
        public Object Next() => null;
        public bool MoveNext() => false;
        public void Reset() => throw new NotImplementedException();
    }
}
