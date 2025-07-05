using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    internal class ArrayStack<T>
    {
        private List<T> _stack;
        public int Count => _stack.Count;
        public bool IsEmpty => _stack.Count == 0;

        public ArrayStack()
        {
            _stack = new List<T>();
        }
        public void Push(T item)
        {
            _stack.Add(item);
        }
        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Is empty");
            }
            var res = _stack.Last();
            _stack.RemoveAt(_stack.Count - 1 );
            return res;
        }

        public T Peek()
        {
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException("Is empty");
                }
                return _stack.Last();
            }
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
