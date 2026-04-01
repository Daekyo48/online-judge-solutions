class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();
        int markedCount = int.Parse(values[0]);
        int captureCount = int.Parse(values[1]);
        int recapturedCount = int.Parse(values[2]);

        int n = (markedCount + 1) * (captureCount + 1) / (recapturedCount + 1) - 1;

        Console.WriteLine(n);
    }
}