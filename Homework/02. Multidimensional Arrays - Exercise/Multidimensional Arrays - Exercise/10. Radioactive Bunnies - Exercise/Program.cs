class Program
{
    static void Main(string[] args)
    {
        /// Rabbit expansion area
        Queue<Tuple<int, int>> rabbitExpansionArea = new Queue<Tuple<int, int>>();

        rabbitExpansionArea.Enqueue(new Tuple<int, int>(-1, 0));
        rabbitExpansionArea.Enqueue(new Tuple<int, int>(1, 0));
        rabbitExpansionArea.Enqueue(new Tuple<int, int>(0, -1));
        rabbitExpansionArea.Enqueue(new Tuple<int, int>(0, 1));

        int startRow = 0;
        int startCol = 0;

        Queue<Tuple<int, int>> currRabbitOnField = new Queue<Tuple<int, int>>();
        Queue<Tuple<int, int>> updateRabbitOnField = new Queue<Tuple<int, int>>();
        int[] sizeOfField = Console.ReadLine().Split().Select(int.Parse).ToArray();
        bool dead = false;
        bool won = false;

        char[,] field = new char[sizeOfField[0], sizeOfField[1]];
        for (int i = 0; i < field.GetLength(0); i++)
        {
            char[] curRow = Console.ReadLine().ToCharArray();
            for (int k = 0; k < field.GetLength(1); k++)
            {
                field[i, k] = curRow[k];
                if (curRow[k] == 'B')
                {
                    currRabbitOnField.Enqueue(new Tuple<int, int>(i, k));
                }
                if (curRow[k] == 'P')
                {
                    startRow = i;
                    startCol = k;
                }
            }
        }
        char[] directions = Console.ReadLine().ToCharArray();

        for (int i = 0; i < directions.Length; i++)
        {
            switch (directions[i])
            {
                case 'L':
                    TheChaseSequance(currRabbitOnField, updateRabbitOnField
                        , rabbitExpansionArea, field, directions[i]
                        , ref startRow, ref startCol, ref dead, ref won);
                    break;

                case 'U':
                    TheChaseSequance(currRabbitOnField, updateRabbitOnField
                        , rabbitExpansionArea, field, directions[i]
                        , ref startRow, ref startCol, ref dead, ref won);
                    break;

                case 'D':
                    TheChaseSequance(currRabbitOnField, updateRabbitOnField
                        , rabbitExpansionArea, field, directions[i]
                        , ref startRow, ref startCol, ref dead, ref won);
                    break;

                case 'R':
                    TheChaseSequance(currRabbitOnField, updateRabbitOnField
                        , rabbitExpansionArea, field, directions[i]
                        , ref startRow, ref startCol, ref dead, ref won);
                    break;
            }
            if (dead || won)
            {
                break;
            }
        }


        if (dead)
        {
            PrintGrid(field);
            CheckFinalPosition(field, ref startRow, ref startCol);
            Console.WriteLine($"dead: {startRow} {startCol}");
        }
        else if (won)
        {
            PrintGrid(field);
            CheckFinalPosition(field, ref startRow, ref startCol);
            Console.WriteLine($"won: {startRow} {startCol}");
        }
    }

    private static void CheckFinalPosition(char[,] field, ref int startRow, ref int startCol)
    {
        if (startRow == -1)
        {
            startRow = 0;
        }
        else if (startRow == field.GetLength(0))
        {
            startRow = field.GetLength(0) - 1;
        }
        if (startCol == -1)
        {
            startCol = 0;
        }
        else if (startCol == field.GetLength(1))
        {
            startCol = field.GetLength(1) - 1;
        }
    }

    private static void TheChaseSequance(Queue<Tuple<int, int>> currRabbitOnField
        , Queue<Tuple<int, int>> updateRabbitOnField, Queue<Tuple<int, int>> rabbitExpansionArea
        , char[,] field, char direction, ref int startRow, ref int startCol, ref bool dead, ref bool won)
    {

        field[startRow, startCol] = '.';
        switch (direction)
        {
            case 'U':
                startRow--;
                break;
            case 'D':
                startRow++;
                break;
            case 'L':
                startCol--;
                break;
            case 'R':
                startCol++;
                break;
        }

        try
        {
            if (field[startRow, startCol] == 'B')
            {

                dead = true;
            }
            else
            {
                field[startRow, startCol] = 'P';
            }
        }
        catch (Exception)
        {
            won = true;
        }

        for (int rabbOnField = 0; rabbOnField < currRabbitOnField.Count; rabbOnField++)
        {
            int row = currRabbitOnField.Peek().Item1;
            int col = currRabbitOnField.Peek().Item2;
            currRabbitOnField.Enqueue(currRabbitOnField.Dequeue());
            for (int rabbits = 0; rabbits < rabbitExpansionArea.Count; rabbits++)
            {
                int curRow = rabbitExpansionArea.Peek().Item1;
                int curCol = rabbitExpansionArea.Peek().Item2;
                rabbitExpansionArea.Enqueue(rabbitExpansionArea.Dequeue());
                try
                {
                    if (field[row + curRow, col + curCol] != 'P')
                    {
                        if (field[row + curRow, col + curCol] != 'B')
                        {
                            field[row + curRow, col + curCol] = 'B';
                            updateRabbitOnField.Enqueue(new Tuple<int, int>(row + curRow, col + curCol));
                        }
                    }
                    else
                    {
                        field[row + curRow, col + curCol] = 'B';
                        dead = true;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        if (!dead || !won)
        {
            currRabbitOnField.Clear();
            for (int s = 0; s < updateRabbitOnField.Count; s++)
            {
                currRabbitOnField.Enqueue(updateRabbitOnField.Peek());
                updateRabbitOnField.Enqueue(updateRabbitOnField.Dequeue());
            }
            updateRabbitOnField.Clear();
        }
    }

    private static void PrintGrid(char[,] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int k = 0; k < grid.GetLength(1); k++)
            {
                Console.Write(grid[i, k]);
            }
            Console.WriteLine();
        }

        var a = 0;
    }
}
