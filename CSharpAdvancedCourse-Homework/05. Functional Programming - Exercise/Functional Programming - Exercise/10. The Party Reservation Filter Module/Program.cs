namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var invitedPeople = Console.ReadLine().Split(' ').ToList();

            var filters = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] filterArguments = command.Split(';');

                switch (filterArguments[0])
                {
                    case "Add filter":
                        filters.Add($"{filterArguments[1]};{filterArguments[2]}");
                        break;
                    case "Remove filter":
                        filters.Remove($"{filterArguments[1]};{filterArguments[2]}");
                        break;
                }
            }

            foreach (string filter in filters)
            {
                string filterType = filter.Split(';')[0];
                string filterValue = filter.Split(';')[1];

                Predicate<string> predicate = Filter(filterType, filterValue);

                invitedPeople = invitedPeople.Where(p => !predicate(p)).ToList();
            }

            Console.WriteLine(string.Join(' ', invitedPeople));
        }

        static Predicate<string> Filter(string filter, string filterValue)
        {
            switch (filter)
            {
                case "Starts with":
                    return f => f.StartsWith(filterValue);
                case "Ends with":
                    return f => f.EndsWith(filterValue);
                case "Length":
                    return f => f.Length == int.Parse(filterValue);
                case "Contains":
                    return f => f.Contains(filterValue);
                default:
                    throw new ArgumentException($"Invalid filter -> {filter}");
            }
        }
    }
}