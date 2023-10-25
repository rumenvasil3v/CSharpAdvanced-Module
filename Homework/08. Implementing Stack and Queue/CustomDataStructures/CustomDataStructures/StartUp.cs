namespace CustomDataStructures
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //CustomList list = new CustomList();

            //list.Add(2);
            //list.Add(3);
            //list.Add(4); // resize here
            //list.Add(5);

            //list.Add(6); // resize here
            //list.Add(7);
            //list.Add(8);
            //list.Add(9);

            //list.Insert(2, 100);
            //Console.WriteLine(string.Join(", ", list.Items));

            ////list.Swap(8, 9);
            //Console.WriteLine(string.Join(", ", list.Items));

            //list.RemoveAt(9);
            
            //Console.WriteLine(string.Join(", ", list.Items));

            //Console.WriteLine(list[7]);

            //list[7] = 200;
            
            //Console.WriteLine(list[7]);

            //list.RemoveAt(7);
            //list.RemoveAt(6);
            //list.RemoveAt(5);
            //list.RemoveAt(4);
            //list.RemoveAt(3);
            //list.RemoveAt(2);

            ////list[2] = 3;
            ////Console.WriteLine(list[2]);

            //// check if an element exists
            //Console.WriteLine(list.Contains(8));
            //Console.WriteLine(list.Contains(11));

            //// before swap
            ////Console.WriteLine(list[1]);
            ////Console.WriteLine(list[2]);

            //// swap elements
            //list.Swap(1, 2);

            //// after swap
            ////Console.WriteLine(list[1]);
            ////Console.WriteLine(list[2]);
            ////Console.WriteLine(list[11]);

            //Console.WriteLine(string.Join(", ", list.Items));

            //Console.WriteLine();

            //list.ForEach(x => Console.WriteLine($"--{x}")); // prints elements depending on the action 

            //List<int> normalList = new List<int>() { 2, 3, 4 };

            //normalList[1] = 10;
            //Console.WriteLine(string.Join(",", normalList));

            //CustomStack stack = new CustomStack();

            //stack.Push(3); // add element 
            //stack.Push(4); // add element 
            //stack.Push(5); // add element 
            //stack.ForEach(x => Console.Write(x + ", "));

            //Console.WriteLine(stack.Pop()); // remove element from the stack
            //Console.WriteLine(stack.Peek()); // 4
            //Console.WriteLine(stack.Peek()); // 4

            //stack.Pop(); // remove element from the stack
            //Console.WriteLine(stack.Peek()); // 3
            //Console.WriteLine(stack.Peek()); // 3
            //Console.WriteLine(stack.Pop()); // throw exception

            CustomQueue queue = new CustomQueue();

            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek()); // check the first element 
            Console.WriteLine(queue.Dequeue()); // remove element


            queue.ForEach(x => Console.Write(x + ", "));
        }
    }
}