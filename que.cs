namespace algorithms_Datastructures.Interfaces
{
    public interface IQue<T>
    {
        void Enqueue(T item);
        T Peek();
        T Dequeue();
        bool IsEmpty();
    }
}