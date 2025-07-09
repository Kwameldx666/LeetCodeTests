using System;
using System.ComponentModel.Design.Serialization;

public class Heap
{
    public int[] heap;
    public int Count { get; private set; }
    public bool IsEmpty => Count == 0;
    public Heap(int capacity)
    {
        heap = new int[capacity];
        Count = 0;
    }
    public int Parent(int i) => (i - 1) / 2;
    public int LeftChild(int i) => (i * 2) + 1;
    public int RightChild(int i) => (i * 2) + 2;
    public void Insert(int data)
    {
        if (Contains(data) != -1)
        {
            Console.WriteLine("Already exists this figure");
            return;
        }
        if (Count == heap.Length)
        {
            Console.WriteLine("Heap is full");
            return;
        }
        heap[Count] = data;
        Count++;
        HeapifyUp(Count - 1);
    }

    public void HeapifyUp(int index)
    {

        while (index > 0 && heap[index] > heap[Parent(index)])
        {
            Swap(index, Parent(index));
            index = Parent(index);
        }
    }

    public void Swap(int index1, int index2)
    {
        var tmp = heap[index1]; heap[index1] = heap[index2]; heap[index2] = tmp;
    }

    public int Contains(int value)
    {
        int index = 0;
        while (index < Count)
        {
            if (value == heap[index])
            {
                return index;
            }
            index++;
        }
        return -1;
    }

    public int ExtractMax()
    {
        if (IsEmpty) throw new Exception("Error");
        var max = heap[0];
        heap[0] = heap[Count - 1];
        Count--;
        HeapifyDown(0);
        return max;
    }

    public void HeapifyDown(int index)
    {
        int highest = index;

        if (LeftChild(index) < Count && heap[highest] < heap[LeftChild(index)])
        {
            highest = LeftChild(index);
        }
        if (RightChild(index) < Count && heap[highest] < heap[RightChild(index)])
        {
            highest = RightChild(index);
        }
        if (index != highest)
        {
            Swap(index, highest);
            index = highest;
            HeapifyDown(highest);
        }
    }
}
