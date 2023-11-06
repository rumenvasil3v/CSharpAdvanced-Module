namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            string[] sequenceOfSongs = Console.ReadLine().Split(", ");

            Queue<string> songsQueue = new Queue<string>(sequenceOfSongs);

            // INVOKE METHOD
            ManipulatingSongs(songsQueue);
        }

        static void ManipulatingSongs(Queue<string> songsQueue)
        {
            while (songsQueue.Count > 0)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    // ENQUEUE SONG
                    case "Add":
                        string currentSong = NameOfSong(command); 

                        if (CheckIfSongIsAlreadyEnqueued(songsQueue, currentSong))
                        {
                            // in case if there is already enqueued that song
                            Console.WriteLine("{0} is already contained!", currentSong);
                            continue;
                        }

                        EnqueueSong(songsQueue, currentSong);
                        break;
                    case "Play": // DEQUEUE SONG
                        DequeueSong(songsQueue);
                        break;
                    case "Show":
                        PrintAllSongs(songsQueue); // PRINT CURRENT ENQUEUED SONGS
                        break;
                }
            }

            // OUTPUT
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

        static string NameOfSong(string[] command)
        {
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

            return currentSong;
        }
    }
}