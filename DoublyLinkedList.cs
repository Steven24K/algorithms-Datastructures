namespace algorithms_Datastructures.DoublyLinkedList
{
    using System;
    using algorithms_Datastructures.Interfaces;

    public class MyDoublyLinkedList<T> : IQue<T>
    {
        private Node<T> start;
        private Node<T> last;
        public MyDoublyLinkedList()
        {
            this.start = null;
            this.last = null;
        }

        public T Dequeue()
        {
            if (!this.IsEmpty())
            {
                T dequeued = this.start.Value;
                this.start = this.start.Next;
                return dequeued;
            }
            throw new Exception("QueEmptyException: Can not peek, que is empty");
        }

        public void Enqueue(T item)
        {
            Node<T> newNode;
            if (this.IsEmpty())
            {
                newNode = new Node<T>(null, item, null);
                this.last = newNode;
                this.start = newNode;
            }
            else
            {
                newNode = new Node<T>(this.last, item, null);
                this.last.Next = newNode;
                this.last = newNode;
            }
        }

        public bool IsEmpty()
        {
            if (this.start == null && this.last == null) return true;
            return false;
        }

        public T Peek()
        {
            if (!this.IsEmpty())
            {
                return this.start.Value;
            }
            throw new Exception("QueEmptyException: Can not peek, que is empty");
        }

        public override string ToString()
        {
            string res = "[";
            Node<T> tmp = this.start;
            while(tmp != null)
            {
                res = res + tmp.Value.ToString() + ", ";
                tmp = tmp.Next;
            }
            res += "]";
            return res;
        }
    }

    public class Node<T>
    {
        private Node<T> prev;
        private Node<T> nxt;
        private T val;
        public Node(Node<T> previous, T value, Node<T> next)
        {
            this.prev = previous;
            this.val = value;
            this.nxt = next;
        }

        public Node<T> Next { get { return this.nxt; } set { this.nxt = value; } }

        public Node<T> Previous { get { return this.prev; } set { this.prev = value; } }

        public T Value { get { return this.val; } set { this.val = value; } }
    }
}
