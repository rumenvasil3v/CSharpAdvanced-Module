using System.Collections.Generic;

namespace _09._Custom_Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

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
            //list.RemoveFirst();

            DoublyLinkedList<string> listOfStrings = new DoublyLinkedList<string>();

            listOfStrings.AddFirst("Niki");
            listOfStrings.AddFirst("Niki");
            listOfStrings.AddLast("Niki");
            listOfStrings.AddLast("Niki");
            listOfStrings.AddLast("Niki");
            listOfStrings.AddFirst("Niki");

            Console.WriteLine(listOfStrings.RemoveFirst());
            Console.WriteLine(listOfStrings.RemoveLast()); 

            listOfStrings.ForEach(x => Console.WriteLine(x));

            var listOfStringsArr = listOfStrings.ToArray();

            Console.WriteLine(string.Join(", ", listOfStringsArr));

            listOfStrings.RemoveFirst();
            listOfStrings.RemoveFirst();
            listOfStrings.RemoveFirst();
            listOfStrings.RemoveFirst();
        }
    }
}