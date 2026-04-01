class Program
{
    static void Main()
    {
        Console.ReadLine();

        Stack<int> sideSpace = new();
        int nextNumber = 1;

        foreach (string input in Console.ReadLine()!.Split())
        {
            sideSpace.Push(int.Parse(input));

            while (sideSpace.Count > 0 && sideSpace.Peek() == nextNumber)
            {
                sideSpace.Pop();
                nextNumber++;
            }
        }

        Console.WriteLine(sideSpace.Count == 0 ? "Nice" : "Sad");
    }
}