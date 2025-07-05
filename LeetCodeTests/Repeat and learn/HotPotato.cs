using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    internal class HotPotato
    {
        private class Node
        {
            public int data;
            public Node next;
            public Node(int data) { this.data = data; }
        }
        private Node _head;
        private Node _tail;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;
        public HotPotato(int childCount)
        {
            for (int i = 1; i <= childCount; i++)
            {
                NewChildInGame(i);
            }
        }

        public void PlayGame(int k)
        {
            if (IsEmpty)
            {
                Console.WriteLine("Is empty");
                return;
            }

            Node current = _tail; // Начинаем с конца, чтобы current.next — это _head
            while (Count > 1)
            {
                // Передаём картошку k-1 раз (чтобы current указывал на того, кто выбывает)
                for (int i = 1; i < k; i++)
                {
                    current = current.next;
                }

                // current.next выбывает
                int outNumber = current.next.data;
                Console.WriteLine($"Вылетает: {outNumber}");

                // Если вылетает _head, сдвигаем _head
                if (current.next == _head)
                    _head = _head.next;
                // Если вылетает _tail, сдвигаем _tail
                if (current.next == _tail)
                    _tail = current;

                // Удаляем current.next
                current.next = current.next.next;
                Count--;
            }

            Console.WriteLine($"Победитель: {_head.data}");
        }

        public void NewChildInGame(int number)
        {
            Node newNode = new Node(number);
            if (IsEmpty)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.next = newNode;
                _tail = newNode;
                _tail.next = _head;
            }
            Count++;
        }
      
    }
}
