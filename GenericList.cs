using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    public class GenericList<T>
    {
        private class Node
        {
            public Node(T t)
            {
                Next = null;
                Data = t;
            }

            public Node Next { get; set; }

            public T Data { get; private set; }
        }

        private Node _head;

        public GenericList()
        {
            _head = null;
        }

        public void AddHead(T t)
        {
            var n = new Node(t) {Next = _head};
            _head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
