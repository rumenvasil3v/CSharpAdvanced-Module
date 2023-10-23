namespace CustomDataStructures
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();

            list.Add(2);
            list.Add(3);
            list.Add(4); // resize here
            list.Add(5);

            list.Add(6); // resize here
            list.Add(7);
            list.Add(8);
            list.Add(9);

            //list.Insert(2, 100);

            list.RemoveAt(8);

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
        }
    }
}