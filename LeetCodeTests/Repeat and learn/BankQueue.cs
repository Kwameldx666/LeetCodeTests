using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    internal class BankQueue<T>
    {
        private class Node
        {
            public T data;
            public Node Next;
            public Node(T data) { this.data = data; }
        }

        private Node _head;
        private Node _tail;
        private int _count;

        private bool IsEmpty => _count == 0;
        public void Enter(T data)
        {
            Node newNode = new Node(data);
            if (IsEmpty)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }
            _count++;
        }

        public void ServicePeople()
        {
            if (!IsEmpty)
            {

                while (_count > 0)
                {
                   Console.WriteLine($"Обслуживается клиент с номером:{Dequeue()}");
                }
            }
        }
        private T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Is empty");
            }
            else
            {
                var res = _head.data;
                _head = _head.Next;
                _count--;
                if (_head == null)
                    _tail = null;
                return res;
            }
        }
    }
}
