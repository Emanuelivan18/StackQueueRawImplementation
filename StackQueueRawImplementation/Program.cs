namespace StackQueueRawImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Print();
            Console.WriteLine("Pop: " + myStack.Pop());
            Console.WriteLine("Pop: " + myStack.Pop());
            myStack.Print();

            MyQueue<string> myQueue = new MyQueue<string>();
            myQueue.Enqueue("A");
            myQueue.Enqueue("B");
            myQueue.Enqueue("C");
            myQueue.Print();
            Console.WriteLine("Dequeue: " + myQueue.Dequeue());
            Console.WriteLine("Dequeue: " + myQueue.Dequeue());
            myQueue.Print();
        }
    }
}
