using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    internal class StackList<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node(T value) { Value = value; }
        }
        private Node top;
        public StackList() { top = null; }
        public int Count { get; private set; }

        public bool IsEmpty => top == null;
        public void Push(T item)
        {
            Node newTop = new(item);
            newTop.Next = top;
            top = newTop;
            Count++;
        }
        public T Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                T data = top.Value;
                top = top.Next;
                Count--;
                return data;
            }
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                return top.Value;
            }
        }

        public void Clear()
        {
            top = null;
            Count = 0;
        }

    }
}
