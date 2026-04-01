class Program
{
    static void Main()
    {
        string value;

        while ((value = Console.ReadLine()!) != "0")
        {
            Console.WriteLine(value.SequenceEqual(value.Reverse()) ? "yes" : "no");
        }
    }
}