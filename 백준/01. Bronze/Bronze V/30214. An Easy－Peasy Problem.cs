class Program
{
    static void Main()
    {
        int[] s = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        Console.WriteLine(s[0] * 2 >= s[1] ? "E" : "H");
    }
}