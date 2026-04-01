class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        HashSet<string> dancingPeople = new() { "ChongChong" };

        for (int i = 0; i < n; i++)
        {
            string[] log = Console.ReadLine()!.Split();

            if (dancingPeople.Contains(log[0]))
            {
                dancingPeople.Add(log[1]);
            }
            else if (dancingPeople.Contains(log[1]))
            {
                dancingPeople.Add(log[0]);
            }
        }

        Console.WriteLine(dancingPeople.Count);
    }
}