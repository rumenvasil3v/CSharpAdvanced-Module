namespace CustomDataStructures_exercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //list.RemoveAt(7);
            //list.RemoveAt(6);
            //list.RemoveAt(5);
            //list.RemoveAt(4);
            //list.RemoveAt(3);
            //list.RemoveAt(2);

            //list[2] = 3;
            //Console.WriteLine(list[2]);

            //check if an element exists
            //Console.WriteLine(list.Contains(8));
            //Console.WriteLine(list.Contains(11));

            //before swap
            //Console.WriteLine(list[1]);
            //Console.WriteLine(list[2]);

            //swap elements
            //list.Swap(1, 2);

            //after swap
            //Console.WriteLine(list[1]);
            //Console.WriteLine(list[2]);
            //Console.WriteLine(list[11]);

            //Console.WriteLine(string.Join(", ", list.Items));

            //Console.WriteLine();

            //list.ForEach(x => Console.WriteLine($"--{x}")); // prints elements depending on the action 

            //List<int> normalList = new List<int>() { 2, 3, 4 };

            //normalList[1] = 10;
            //Console.WriteLine(string.Join(",", normalList));

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(3);

            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //queue.Clear();

            //CustomStack stack = new CustomStack();
            //stack.Push(1);
            //stack.Push(2);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //stack.Push(3);
            //stack.Push(123);
            //stack.Push(12325235);
            //stack.Push(545);

            //stack.ForEach(x => Console.Write(x + 1 + ", "));

            //Console.WriteLine();

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Peek());

            CustomQueue queue = new CustomQueue();

            queue.Enqueue(123);
            queue.Enqueue(321);
            queue.Enqueue(432);

            queue.ForEach(x => Console.WriteLine($"-- {x + 1}"));

            //Console.WriteLine();

            //Console.WriteLine(queue.Peek());

            //queue.Dequeue();

            //Console.WriteLine();
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine();

            //queue.Dequeue();

            //Console.WriteLine(queue.Peek());
            queue.Clear();

            queue.ForEach(x => Console.WriteLine($"-- {x + 1}"));
        }
    }
}