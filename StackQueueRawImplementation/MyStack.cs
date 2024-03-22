using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueRawImplementation
{
    public class MyStack<T>
    {
        private Node<T>? top;
        public void Push(T data)
        {
            Node<T> newNode = new(data);
            newNode.Next = top!;
            top = newNode;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T data = top!.Data;
            Node<T> nextNode = top.Next!;
            top!.Next = null;
            top = nextNode;
            return data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Node<T> current = top!;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next!;
            }
        }
    }
}
