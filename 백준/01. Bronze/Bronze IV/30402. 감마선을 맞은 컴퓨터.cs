class Program
{
    static void Main()
    {
        for (int i = 0; i < 15; i++)
        {
            foreach (string color in Console.ReadLine()!.Split())
            {
                switch (color)
                {
                    case "w":
                        Console.WriteLine("chunbae");
                        return;
                    case "b":
                        Console.WriteLine("nabi");
                        return;
                    case "g":
                        Console.WriteLine("yeongcheol");
                        return;
                }
            }
        }
    }
}