class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine()!.Split();
        int n = int.Parse(inputs[0]);
        int m = int.Parse(inputs[1]);

        Dictionary<int, string> numberToName = new();
        Dictionary<string, int> nameToNumber = new();

        for (int i = 1; i <= n; i++)
        {
            string pokemon = Console.ReadLine()!;

            nameToNumber[pokemon] = i;
            numberToName[i] = pokemon;
        }

        for (int i = 0; i < m; i++)
        {
            string question = Console.ReadLine()!;

            if (int.TryParse(question, out int number))
            {
                Console.WriteLine(numberToName[number]);
            }
            else
            {
                Console.WriteLine(nameToNumber[question]);
            }
        }
    }
}