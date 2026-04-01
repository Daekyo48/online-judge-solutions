class Program
{
    static void Main()
    {
        int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        int c = int.Parse(Console.ReadLine()!);
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine((a[0] * n + a[1] <= c * n) && (a[0] <= c) ? 1 : 0);
    }
}