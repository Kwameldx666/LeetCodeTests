public class BST<T> where T : IComparable<T>
{
    private class Node
    {
        public T Value;
        public Node Left;
        public Node Right;
        public Node(T value) { Value = value; }
    }

    private Node _root;
    private int _count;
    public int Count => _count;
    public bool IsEmpty => _count == 0;

    public void InsertValue(T value)
    {
        if (_root == null)
        {
            _root = new Node(value);
            _count++;
        }
        else
        {
            if (InsertValue(_root, value)) _count++;
        }
    }

    private bool InsertValue(Node current, T value)
    {
        int cmp = value.CompareTo(current.Value);
        if (cmp == 0) return false; // дубликаты не добавляем
        if (cmp > 0)
        {
            if (current.Right == null)
            {
                current.Right = new Node(value);
                return true;
            }
            else return InsertValue(current.Right, value);
        }
        else
        {
            if (current.Left == null)
            {
                current.Left = new Node(value);
                return true;
            }
            else return InsertValue(current.Left, value);
        }
    }

    public bool Contains(T value)
    {
        return SearchValue(_root, value);
    }

    private bool SearchValue(Node current, T value)
    {
        if (current == null) return false;
        int cmp = value.CompareTo(current.Value);
        if (cmp == 0) return true;
        else if (cmp > 0) return SearchValue(current.Right, value);
        else return SearchValue(current.Left, value);
    }

    public T Min()
    {
        if (IsEmpty) throw new InvalidOperationException("BST is empty");
        return SearchMin(_root).Value;
    }

    public T Max()
    {
        if (IsEmpty) throw new InvalidOperationException("BST is empty");
        return SearchMax(_root).Value;
    }

    private Node SearchMin(Node node)
    {
        while (node.Left != null) node = node.Left;
        return node;
    }

    private Node SearchMax(Node node)
    {
        while (node.Right != null) node = node.Right;
        return node;
    }

    public bool Remove(T value)
    {
        int prevCount = _count;
        _root = RemoveNode(_root, value);
        return _count < prevCount;
    }

    private Node RemoveNode(Node node, T value)
    {
        if (node == null) return null;
        int cmp = value.CompareTo(node.Value);
        if (cmp < 0)
            node.Left = RemoveNode(node.Left, value);
        else if (cmp > 0)
            node.Right = RemoveNode(node.Right, value);
        else
        {
            _count--;
            // Нет левого поддерева — заменяем на правое
            if (node.Left == null) return node.Right;
            // Нет правого поддерева — заменяем на левое
            if (node.Right == null) return node.Left;
            // Два потомка: ищем минимум в правом поддереве
            Node minNode = SearchMin(node.Right);
            node.Value = minNode.Value;
            node.Right = RemoveNode(node.Right, minNode.Value);
        }
        return node;
    }
}