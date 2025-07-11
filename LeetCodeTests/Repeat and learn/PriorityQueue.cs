using static LeetCodeTests.Repeat_and_learn.MusicPlaylist;
public class Node<T>
{
    public T Value;
    public int Priority;
    public Node<T> Next;

    public Node(T value, int priority)
    {
        Value = value;
        Priority = priority;
        Next = null;
    }
}
public class PriorityQueue<T>
{
    private Node<T> head;
    private int count;

    public void Enqueue(T value, int priority)
    {
        var node = new Node<T>(value, priority);
        node.Next = head;
        head = node;
        count++;
    }

    public T Dequeue()
    {
        if (head == null) throw new InvalidOperationException("Queue is empty");

        Node<T> maxNode = head, maxPrev = null;
        Node<T> prev = null, curr = head;
        // Поиск максимального приоритета
        while (curr != null)
        {
            if (curr.Priority > maxNode.Priority)
            {
                maxNode = curr;
                maxPrev = prev;
            }
            prev = curr;
            curr = curr.Next;
        }
        // Удаление maxNode
        if (maxPrev == null)
            head = head.Next;
        else
            maxPrev.Next = maxNode.Next;

        count--;
        return maxNode.Value;
    }

    public T Peek()
    {
        if (head == null) throw new InvalidOperationException("Queue is empty");
        Node<T> maxNode = head;
        Node<T> curr = head.Next;
        while (curr != null)
        {
            if (curr.Priority > maxNode.Priority)
                maxNode = curr;
            curr = curr.Next;
        }
        return maxNode.Value;
    }

    public bool IsEmpty => count == 0;
    public int Count => count;
}