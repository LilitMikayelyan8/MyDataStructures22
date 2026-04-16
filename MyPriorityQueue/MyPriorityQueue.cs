using System.Collections.Generic;

namespace MyPriorityQueue
{
    public class MyPriorityQueue<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        LinkedList<T> _items = new LinkedList<T>;
        public void Enqueue(T item) 
        {
            if (_items.Count == 0)
                _items.AddLast(item);
            else 
            { 
                var current = _items.Head;
                while (current != null && current.Value.CompareTo(item)>0) 
                { 
                    current = current.Next;
                }
                if (current == null)
                {

                    _items.AddLast(item);
                }
                else 
                {
                    _items.AddBefore(current, item);
                }
            }
        }
        public T Dequeue() 
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            T value = _items.Head.Value;
            _items.RemoveFirst();

            return value;
        }
        public T Peek() 
        { 
        
        }
        public int Count() 
        { 
        
        }
        public void Clear() 
        { 
        
        }
        public IEnumerator<T> GetEnumerator() { }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}