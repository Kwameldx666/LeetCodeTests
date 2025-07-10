using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    internal class MinHeap<T> where T : IComparable<T>
    {
        private T[] _heap;
        private int _size;
        private int _capacity;
        private bool IsEmpty => _size == 0;
        private int Parent(int index) => (index - 1) / 2;
        private int LeftChild(int index) => (index * 2) + 1;
        private int RightChild(int index) => (index * 2) + 2;

        public MinHeap(int capacity)
        {
            _heap = new T[capacity];
            _capacity = capacity;
            _size = 0;
        }
        public void Insert(T item)
        {
            if (_size >= _capacity)
                throw new InvalidOperationException("Heap is full.");
            _heap[_size] = item;
            _size++;
            HeapifyUp(_size - 1);

        }
        private void Swap(int index1, int index2)
        {
            T tmp = _heap[index1];
            _heap[index1] = _heap[index2];
            _heap[index2] = tmp;
        }
        private void HeapifyUp(int index)
        {
            while (index > 0 && _heap[index].CompareTo(_heap[Parent(index)]) < 0)
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }

        private void HeapifyDown(int index)
        {
            while (true)
            {
                int left = LeftChild(index);
                int right = RightChild(index);
                int smallest = index;

                if (left < _size && _heap[left].CompareTo(_heap[smallest]) < 0)
                    smallest = left;
                if (right < _size && _heap[right].CompareTo(_heap[smallest]) < 0)
                    smallest = right;

                if (smallest != index)
                {
                    Swap(index, smallest);
                    index = smallest;
                }
                else
                {
                    break;
                }
            }
        }

        public T ExtractMin()
        {
            if (IsEmpty) throw new InvalidOperationException("Is empty");
            else
            {
                T res = _heap[0];
                _heap[0] = _heap[_size - 1];
                _heap[_size - 1] = default(T);
                _size--;
                HeapifyDown(0);
                return res;
            }
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Empty");
            else { return _heap[0]; }
        }
    }
}
