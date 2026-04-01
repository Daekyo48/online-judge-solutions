class Program
{
    static void Main()
    {
        int[,] board = new int[9, 9];

        bool[][,] visited =
        {
            new bool[9, 9],
            new bool[9, 9],
            new bool[9, 9]
        };

        List<(int rowIndex, int columnIndex)> blanks = new();

        for (int i = 0; i < 9; i++)
        {
            string[] numbers = Console.ReadLine()!.Split();

            for (int j = 0; j < 9; j++)
            {
                int number = int.Parse(numbers[j]);

                board[i, j] = number;

                if (number != 0)
                {
                    visited[0][i, number - 1] = true;
                    visited[1][j, number - 1] = true;
                    visited[2][i / 3 * 3 + j / 3, number - 1] = true;
                }
                else
                {
                    blanks.Add((i, j));
                }
            }
        }

        DepthFirstSearch(0);

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write($"{board[i, j]} ");
            }

            Console.WriteLine();
        }

        bool DepthFirstSearch(int depth)
        {
            if (depth == blanks.Count) return true;

            (int rowIndex, int columnIndex) = blanks[depth];
            int submatrixIndex = rowIndex / 3 * 3 + columnIndex / 3;

            for (int i = 0; i < 9; i++)
            {
                if (visited[0][rowIndex, i]) continue;
                if (visited[1][columnIndex, i]) continue;
                if (visited[2][submatrixIndex, i]) continue;

                board[rowIndex, columnIndex] = i + 1;
                visited[0][rowIndex, i] = true;
                visited[1][columnIndex, i] = true;
                visited[2][submatrixIndex, i] = true;

                if (DepthFirstSearch(depth + 1)) return true;

                board[rowIndex, columnIndex] = 0;
                visited[0][rowIndex, i] = false;
                visited[1][columnIndex, i] = false;
                visited[2][submatrixIndex, i] = false;
            }

            return false;
        }
    }
}