using System;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack
    {

        private int _itemTotal;
        public List<object> Items;

        public Stack()
        {
            _itemTotal = 0;
            Items = new List<object>();
        }

        public void Push(object obj)
        {
            //if null is passed to this method, you should throw an InvalidOperationException.
            if (obj == null)
            {
                throw new InvalidOperationException("Can't add null object to stack.");
            }
            _itemTotal += 1;
            Items.Add(obj);
        }

        public object Pop()
        {
            //if we call the Pop() method on an empty stack, this method should throw an InvalidOperationException. 
            if (Items.Count == 0)
            {
                throw new InvalidOperationException("Can't remove item from empty stack.");
            }
            var index = _itemTotal - 1;
            var lastOff = Items[index];
            Items.RemoveAt(index);
            _itemTotal -= 1;
            return lastOff;
        }

        public void Clear()
        {
            Items.Clear();
        }

    }
}
