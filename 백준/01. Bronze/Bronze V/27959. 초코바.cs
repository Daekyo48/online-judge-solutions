class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();
        int n = int.Parse(numbers[0]);
        int m = int.Parse(numbers[1]);

        Console.WriteLine(n * 100 >= m ? "Yes" : "No");
    }
}