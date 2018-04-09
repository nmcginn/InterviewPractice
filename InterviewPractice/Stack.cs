using System;

namespace InterviewPractice
{
    public class Stack<T> where T:IComparable
    {
        private StackNode<T> RootElement;

        public Stack()
        {
            RootElement = new StackNode<T>() { Next = null, Value = default(T), Empty = true };
        }

        public bool IsEmpty()
        {
            return RootElement == null || RootElement.Empty;
        }

        public void Push(T element)
        {
            var current = RootElement;
            while (!current.Empty)
            {
                current = current.Next;
            }
            current.Next = new StackNode<T>() { Empty = true, Next = null, Value = element };
            current.Empty = false;
        }

        public T Pop()
        {
            var current = RootElement;
            var parent = RootElement;
            while (current.Next != null)
            {
                parent = current;
                current = current.Next;
            }
            parent.Empty = true;
            parent.Next = null;
            return current.Value;
        }
    }

    public class StackNode<T>
    {
        public T Value;
        public StackNode<T> Next;
        public bool Empty = true;
    }
}
