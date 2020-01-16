using System.Collections.Generic;

namespace mazeprojetynov
{
    public interface IPriorityQueue<T>
    {
        int Count { get; }

        T Dequeue();
        void Enqueue(T item, double priority);
        IEnumerator<T> GetEnumerator();
    }
}