namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INVOKING METHOD AND SET CUSTOMERS IN THIS QUEUE
            Queue<string> queue = ManipulatingCustomers();

            // OUTPUT /PRINT REMAINING CUSTOMERS/
            Console.WriteLine("{0} people remaining.", queue.Count);
        }

        static Queue<string> ManipulatingCustomers()
        {
            Queue<string> queue = new Queue<string>();

            // CODE LOGIC AND INPUT
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "Paid":
                        DequeueAllCustomers(queue);
                        break;
                    default:
                        EnqueueCustomer(queue, command);
                        break;
                }
            }

            // RETURN CUSTOMERS QUEUE
            return queue;
        }

        static void DequeueAllCustomers(Queue<string> queue)
        {
            while (queue.Count > 0)
            {
                // DEQUEUE ALL CUSTOMERS
                Console.WriteLine(queue.Dequeue());
            }
        }

        static void EnqueueCustomer(Queue<string> queue, string command)
        {
            string customer = command;

            // ENQUEUE CUSTOMER
            queue.Enqueue(customer);
        }
    }
}