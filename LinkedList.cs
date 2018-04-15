namespace algorithms_Datastructures.LinkedList
{
    using System;
    using algorithms_Datastructures.Interfaces;

    public class MyLinkedList<T> : IStack<T>
    {
        private Node<T> start;
        private int lenght;
        public MyLinkedList()
        {
            this.start = null;
            this.lenght = 0;
        }

        public int Lenght{get{return this.lenght;}}

        public bool IsEmpty()
        {
            if(this.start == null | this.lenght == 0) return true;
            return false;
        }

        public T Peek()
        {
            if(!this.IsEmpty())return this.start.Value;
            throw new Exception("Empty stack execption: Can not peek into an empty stack");
        }

        public T Pop()
        {
            if(!this.IsEmpty())
            {
                T poppedValue = this.start.Value;
                this.start = this.start.Next;
                this.lenght -= 1;
                return poppedValue;
            }
            throw new Exception("Empty stack exception: Can not pop an item in an empty stack.");
        }

        public void Push(T item)
        {
            this.start = new Node<T>(item, this.start);
            this.lenght += 1;
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
        private T _value;
        private Node<T> _next;
        public Node(T value, Node<T> next)
        {
            this._value = value;
            this._next = next;
        }
        public T Value { get { return this._value; } set { this._value = value; } }
        public Node<T> Next { get { return this._next; } set { this._next = value; } }
    }
}