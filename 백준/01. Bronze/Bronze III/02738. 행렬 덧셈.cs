class Program
{
    static void Main()
    {
        string[] sizes = Console.ReadLine()!.Split();
        int n = int.Parse(sizes[0]);
        int m = int.Parse(sizes[1]);

        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] elements = Console.ReadLine()!.Split();

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(elements[j]);
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            string[] elements = Console.ReadLine()!.Split();

            for (int j = 0; j < m; j++)
            {
                Console.Write($"{matrix[i, j] + int.Parse(elements[j])} ");
            }

            Console.WriteLine();
        }
    }
}