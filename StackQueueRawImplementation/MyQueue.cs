using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueRawImplementation
{
    public class MyQueue<T>
    {
        private Node<T>? front;
        private Node<T>? rear;

        public void Enqueue(T data)
        {
            Node<T> newNode = new(data);
            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T data = front!.Data;
            Node<T> nextNode = front.Next!;
            front.Next = null;
            front = nextNode;
            if (front == null)
            {
                rear = null;
            }
            return data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Node<T> current = front!;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next!;
            }
        }
    }
}
