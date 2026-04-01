class Program
{
    static void Main()
    {
        int[] sticks = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        Array.Sort(sticks);

        if (sticks[0] + sticks[1] > sticks[2])
        {
            Console.WriteLine(sticks[0] + sticks[1] + sticks[2]);
        }
        else
        {
            Console.WriteLine((sticks[0] + sticks[1]) * 2 - 1);
        }
    }
}