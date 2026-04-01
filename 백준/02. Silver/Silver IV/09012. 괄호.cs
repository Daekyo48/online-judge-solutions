class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            int balance = 0;
            bool isValid = true;

            foreach (char parenthesis in Console.ReadLine()!)
            {
                balance += parenthesis == '(' ? 1 : -1;

                if (balance < 0)
                {
                    isValid = false;
                    break;
                }
            }

            Console.WriteLine(isValid && balance == 0 ? "YES" : "NO");
        }
    }
}