using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public class CompositeEnumerator : IEnumerator
    {
        Stack<IEnumerator> Stack = new Stack<IEnumerator>();

        public object Current => Stack.Peek().Current;

        public CompositeEnumerator(IEnumerator enumerator)
        {
            Stack.Push(enumerator); 
        }
       
        public bool MoveNext()
        {
            if (HasNext())
            {
                IEnumerator enumerator = Stack.Peek();
                enumerator.MoveNext();
                MenuComponent component = (MenuComponent)enumerator.Current;
                if (enumerator.Current is Menu)
                {
                    Menu menu = (Menu)enumerator.Current;
                    Stack.Push(menu.MenuComponents.GetEnumerator());
                }
                return true;
            }
            else
            {
              return false;
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
                IEnumerator enumerator = Stack.Peek();
                if (HasNext())
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
       
        public void Remove() => throw new NotSupportedException();
        public void Reset() => throw new NotImplementedException();
    }
}
