using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    public class Queue<T>
    {
        private class Node
        {
            public T data;
            public Node next;

            public override string ToString()
            {
                return $"data:{data}";
            }
            public Node(T data) { this.data = data; }
        }

        private Node _head;
        private Node _tail;
        public int Count { get; private set; }

        public Queue()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public bool IsEmpty => _head == null;
        public void Enqueue(T data)
        {
            var newNode = new Node(data);
            if (_tail == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.next = newNode;
                _tail = newNode;
            }
            Count++;

        }

        public T Dequeue()
        {
            if (IsEmpty) throw new InvalidOperationException("Queue is empty");
            var value = _head.data;
            _head = _head.next;
            if (_head == null)
                _tail = null;
            Count--;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Empty");
            return _head.data;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
    }

}



