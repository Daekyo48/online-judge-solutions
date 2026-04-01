class Program
{
    static void Main()
    {
        Console.ReadLine();

        HashSet<string> symmetricDifference = new();

        foreach (string element in Console.ReadLine()!.Split())
        {
            symmetricDifference.Add(element);
        }

        foreach (string element in Console.ReadLine()!.Split())
        {
            if (!symmetricDifference.Remove(element))
            {
                symmetricDifference.Add(element);
            }
        }

        Console.WriteLine(symmetricDifference.Count);
    }
}