using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    internal class NodeDeque<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(T value) { Value = value; }
        }

        private Node _header;
        private Node _tail;
        private int _count;

        public bool IsEmpty => _count == 0;
        public NodeDeque()
        {
            _tail = _header = null;
            _count = 0;
        }

        public void PushFront(T value)
        {
            Node newNode = new Node(value);
            if (IsEmpty)
            {
                _tail = _header = newNode;
            }
            else
            {
                _header.Previous = newNode;
                newNode.Next = _header;
                _header = newNode;
            }
            _count++;
        }

        public void PushBack(T value)
        {
            Node newNode = new Node(value);
            if (IsEmpty)
            {
                _tail = _header = newNode;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
            }
            _count++;
        }

        public T PopBack()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Deque is empty");

            T resultValue = _tail.Value;

            if (_count == 1)
            {
                // последний элемент → очищаем весь дек
                Clear();
            }
            else
            {
                // больше одного элемента
                _tail = _tail.Previous;
                _tail.Next = null;
                _count--;
            }
            return resultValue;

        }


        public T PopFront()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Deque is empty");

            T resultValue = _header.Value;

            if (_count == 1)
            {
                // последний элемент → очищаем весь дек
                Clear();
            }
            else
            {
                // больше одного элемента
                _header = _header.Next;
                _header.Previous = null;
                _count--;
            }
            return resultValue;
        }

        public T PeekBack()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Deque is empty");
            }
            else
            {
                return _tail.Value;
            }
        }
        public T PeekFront()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Deque is empty");
            }
            else
            {
                return _header.Value;
            }
        }

        public void Clear()
        {
            _tail = _header = null;
            _count = 0;
        }
    }
}
