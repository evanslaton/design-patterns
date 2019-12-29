using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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

        // check if the stack is empty
          // if not, get the top IEnumerator out of the stack
          // get the next component out of the IEnumerator (IEnumerator keeps track of its current)
            // if that item is also an IEnumerator, put it on top of the stack
          // return the component
        // else return null



       
        public Object Next()
        { 
            if (MoveNext())
            {
                IEnumerator enumerator = (IEnumerator)Stack.Peek();
                enumerator.MoveNext();
                MenuComponent component = (MenuComponent)enumerator.Current;
                    if (enumerator.Current is Menu)
                    {
                        Menu menu = (Menu)enumerator.Current;
                        Stack.Push(menu.MenuComponents.GetEnumerator());
                    }
                    return component;
            }
            else
            {
              return null;
            }
        }
        
        public bool MoveNext()
        {
            if (Stack.Count == 0)
            {
                return false;
            }
            else
            {
                IEnumerator enumerator = (IEnumerator)Stack.Peek();
                if (!enumerator.MoveNext())
                {
                    Stack.Pop(); 
                    return MoveNext();
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
