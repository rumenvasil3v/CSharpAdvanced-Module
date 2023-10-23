namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(3);
            list.AddLast(10);
            list.AddLast(1011);
            list.AddFirst(567);

            Console.WriteLine(list.RemoveFirst()); // 567
            Console.WriteLine(list.RemoveLast()); // 1011

            list.ForEach(x => Console.WriteLine(x));

            var arr = list.ToArray();

            Console.WriteLine(string.Join(", ", arr));

            list.RemoveFirst();
            list.RemoveFirst();
            list.RemoveFirst();
            list.RemoveFirst();
            list.RemoveFirst();
        }
    }
}