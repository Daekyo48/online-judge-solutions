class Program
{
    static void Main()
    {
        string word = Console.ReadLine()!;

        string[] alphabets = {"c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="};

        foreach (string alphabet in alphabets)
        {
            word = word.Replace(alphabet, "@");
        }

        Console.WriteLine(word.Length);
    }
}