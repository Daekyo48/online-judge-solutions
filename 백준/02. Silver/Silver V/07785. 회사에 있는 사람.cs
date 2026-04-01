class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        HashSet<string> names = new();

        for (int i = 0; i < n; i++)
        {
            string[] log = Console.ReadLine()!.Split();

            if (log[1] == "enter")
            {
                names.Add(log[0]);
            }
            else
            {
                names.Remove(log[0]);
            }
        }

        string[] sortedNames = names.ToArray();

        Array.Sort(sortedNames, StringComparer.Ordinal);

        for (int i = 1; i <= sortedNames.Length; i++)
        {
            Console.WriteLine(sortedNames[^i]);
        }
    }
}