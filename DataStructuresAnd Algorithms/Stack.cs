namespace DataStructuresAnd_Algorithms
{
    public class Stack
    {
        private Node _head;
        public int Peek()
        {
            if (IsEmpty())
            {
                return _head.Value;
            }

            return -1;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                var output = _head.Value;
                _head = _head.Next;
                return output;
            }
            return -1;
        }

        public void Push(int item)
        {
            var newNode = new Node();
            newNode.Value = item;
            newNode.Next = _head;
            _head = newNode;
        }

        public bool IsEmpty()
        {
            return _head != null ? true : false;
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
