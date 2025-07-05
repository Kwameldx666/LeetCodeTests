public class ArrayDeque<T>
{
    private T[] buffer;
    private int head;
    private int tail;
    private int count;

    public ArrayDeque(int Capacity = 4)
    {
        if (Capacity < 1)
        {
            throw new ArgumentException("Error size");
        }
        buffer = new T[Capacity];
        head = 0;
        tail = 0;
        count = 0;
    }
    public int Capacity => buffer.Length;
    public int Count => count;

    public int Next(int index) => (index + 1) % Capacity;
    public int Previous(int index) => (index - 1 + Capacity) % Capacity;
    private void CapacityCheck()
    {
        if (count == Capacity)
        {
            var newCap = Capacity * 2; T[] newArray = new T[newCap];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = buffer[(i + head) % Capacity];
            }
            buffer = newArray;
            head = 0;
            tail = count;

        }
    }

    public void PushFront(T item)
    {
        CapacityCheck();
        head = Previous(head);
        buffer[head] = item;
        count++;
    }

    public void PushBack(T item)
    {
        CapacityCheck();
        buffer[tail] = item;
        tail = Next(tail);
        count++;
    }

    public T PopFront()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("ERROR");
        }
        else
        {
            T Value = buffer[head];
            buffer[head] = default(T);
            head = Next(head);
            count--;
            return Value;

        }
    }

    public T PopBack()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("ERROR");
        }
        else
        {
            tail = Previous(tail);
            T Value = buffer[tail];
            buffer[tail] = default(T);
            count--;
            return Value;
        }
    }

    public T PeekFront()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("ERROR");
        }
        else
        {
            return buffer[head];
        }
    }
    public T PeekBack()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("ERROR");
        }
        else
        {
            return buffer[Previous(tail)];
        }
    }

    public void Clear()
    {
        buffer = new T[Capacity];
        tail = count = head = 0;
    }

    public bool IsEmpty => count == 0;
}