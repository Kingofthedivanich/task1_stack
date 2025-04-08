using System;
using System.Collections.Generic;

namespace task1_stack.Models
{
    public class StackModel<T>
    {
        private readonly Stack<T> _stack;

        public StackModel()
        {
            _stack = new Stack<T>();
        }

        public int Count => _stack.Count;

        public bool IsEmpty => _stack.Count == 0;

        public T? Current => _stack.Count > 0 ? _stack.Peek() : default;

        public void Push(T item)
        {
            _stack.Push(item);
        }

        public T? Pop()
        {
            return _stack.Count > 0 ? _stack.Pop() : default;
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public IEnumerable<T> GetAll()
        {
            return _stack.ToArray();
        }
    }
}