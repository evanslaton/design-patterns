using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class CompositeIterator : IEnumerator
    {
        Stack<IEnumerator> Stack = new Stack<IEnumerator>();

        // Unused
        public object Current => throw new NotImplementedException();

        public CompositeIterator(IEnumerator iterator)
        {
            Stack.Push(iterator); 
        }
       
        public Object Next()
        { 
            if (HasNext())
            {
                IEnumerator iterator = (IEnumerator)Stack.Peek();
                iterator.MoveNext();
                MenuComponent menuComponent = (MenuComponent)iterator.Current;
                
                if (menuComponent is Menu)
                {
                    Stack.Push(menuComponent.CreateIterator());
                }
                return menuComponent;
            }
            else
            {
              return null;
            }
        }
        
        public bool HasNext()
        {
            if (Stack.Count == 0)
            {
                return false;
            }
            else
            {
                IEnumerator iterator = (IEnumerator)Stack.Peek();
                if (!iterator.MoveNext())
                {
                    Stack.Pop(); 
                    return HasNext();
                }
                else
                {
                    return true;
                }
            }
        }
       
        // Unused
        public void Remove() => throw new NotSupportedException();
        public bool MoveNext() => throw new NotImplementedException();
        public void Reset() => throw new NotImplementedException();
    }
}
