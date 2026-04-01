class Program
{
    static void Main()
    {
        Console.ReadLine();

        Stack<int> sideSpace = new();
        int nextNumber = 1;

        foreach (string value in Console.ReadLine()!.Split())
        {
            sideSpace.Push(int.Parse(value));

            while (sideSpace.Count > 0 && sideSpace.Peek() == nextNumber)
            {
                sideSpace.Pop();
                nextNumber++;
            }
        }

        Console.WriteLine(sideSpace.Count == 0 ? "Nice" : "Sad");
    }
}