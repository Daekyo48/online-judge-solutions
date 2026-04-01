class Program
{
    static void Main()
    {
        string input;

        while ((input = Console.ReadLine()!) != "0")
        {
            char[] reversed = input.ToCharArray();

            Array.Reverse(reversed);

            Console.WriteLine(input == new string(reversed) ? "yes" : "no");
        }
    }
}