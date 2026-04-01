class Program
{
    static void Main()
    {
        int[] foundPieces = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        int[] pieces = { 1, 1, 2, 2, 2, 8 };

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"{pieces[i] - foundPieces[i]} ");
        }
    }
}