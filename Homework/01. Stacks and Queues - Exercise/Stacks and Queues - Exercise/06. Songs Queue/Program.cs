namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequenceOfSongs = Console.ReadLine().Split(", ");

            Queue<string> songsQueue = new Queue<string>(sequenceOfSongs);

            ManipulatingSongs(songsQueue);
        }

        static void ManipulatingSongs(Queue<string> songsQueue)
        {
            while (songsQueue.Count > 0)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Add":
                        string currentSong = string.Empty;
                        for (int n = 1; n < command.Length; n++)
                        {
                            if (n == command.Length - 1)
                            {
                                currentSong += command[n];
                                break;
                            }
                            currentSong += command[n] + " ";
                        }

                        if (CheckIfSongIsAlreadyEnqueued(songsQueue, currentSong))
                        {
                            Console.WriteLine("{0} song is already contained!", currentSong);
                            continue;
                        }

                        EnqueueSong(songsQueue, currentSong);
                        break;
                    case "Play":
                        DequeueSong(songsQueue);
                        break;
                    case "Show":
                        PrintAllSongs(songsQueue);
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }

        static void EnqueueSong(Queue<string> songsQueue, string currentSong)
        {
            songsQueue.Enqueue(currentSong);
        }

        static void DequeueSong(Queue<string> songsQueue)
        {
            songsQueue.Dequeue();
        }

        static void PrintAllSongs(Queue<string> songsQueue)
        {
            Console.WriteLine(string.Join(", ", songsQueue));
        }

        static bool CheckIfSongIsAlreadyEnqueued(Queue<string> songsQueue, string currentSong)
        {
            if (songsQueue.Contains(currentSong))
            {
                return true;
            }

            return false;
        }
    }
}