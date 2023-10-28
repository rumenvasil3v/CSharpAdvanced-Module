namespace CustomDataStructures_exercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
//Queue
            CustomQueue queue = new CustomQueue();
            Console.WriteLine("This is Queue:");

            queue.Enqueue(123);
            queue.Enqueue(321);
            queue.Enqueue(432);

            queue.Dequeue();

            Console.WriteLine(queue.Peek());

            queue.ForEach(x => Console.WriteLine($"-- {x + 1}"));

            queue.Enqueue(12019423);
            queue.Enqueue(123409);
            queue.Enqueue(14981423);

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine(queue.Peek());
            queue.ForEach(x => Console.WriteLine($"-- {x + 1}"));

            queue.Clear();
            queue.ForEach(x => Console.WriteLine($"-- {x + 1}"));
            queue.Clear();

            queue.ForEach(x => Console.WriteLine($"-- {x + 1}"));

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("This is List:");

//List
            CustomList list = new CustomList();
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(5);
            list.Add(6);
            Console.WriteLine(string.Join(" ", list.Items));

            list.RemoveAt(0);
            list.RemoveAt(3);  
            list.Add(100);
            list.Add(200);

            list.Insert(2, 235);
            list.Add(17);
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);

            list.Add(13);
            list.Add(18);

            list.ForEach(Console.WriteLine);

            Console.WriteLine(string.Join(" ", list.Items));

            Console.WriteLine(list.Contains(12));
            Console.WriteLine(list.Contains(13));

            list.Swap(2, 3);

            list.ForEach(Console.WriteLine);
            Console.WriteLine(string.Join(" ", list.Items));

//Stack
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("This is Stack:");
            CustomStack stack = new CustomStack();
            stack.Push(321);
            stack.Push(858);
            stack.Push(134);

            Console.WriteLine(stack.Peek());

            stack.ForEach(x => Console.WriteLine($"-- {x + 1}"));

            Console.WriteLine(stack.Pop());

            stack.ForEach(x => Console.WriteLine($"-- {x + 1}"));

            Console.WriteLine(stack.Peek());
        }
    }
}