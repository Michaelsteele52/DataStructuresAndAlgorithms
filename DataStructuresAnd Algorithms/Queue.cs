using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAnd_Algorithms
{
    public class Queue
    {
        private Node _head;
        private Node _tail;

        public void Enqueue(int item)
        {
            var newNode = new Node()
            {
                Value = item
            };
            if (IsEmpty())
            {
                _tail = newNode;
                _head = _tail;
            }

            _head.Next = newNode;
            newNode.Previous = _head;
            _head = newNode;
        }


        public int Dequeue()
        {
            if (!IsEmpty())
            {
                var output = _tail.Value;
                _tail = _tail.Next;
                return output;
            }

            return -1;
        }

        public bool IsEmpty()
        {
            return _tail == null ? true : false;
        }
    }
}
