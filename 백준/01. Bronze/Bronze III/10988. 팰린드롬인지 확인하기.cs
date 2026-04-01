class Program
{
    static void Main()
    {
        string word = Console.ReadLine()!;

        char[] reversed = word.ToCharArray();

        Array.Reverse(reversed);

        Console.WriteLine(word == new string(reversed) ? 1 : 0);
    }
}