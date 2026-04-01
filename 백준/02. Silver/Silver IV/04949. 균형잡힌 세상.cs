class Program
{
    static void Main()
    {
        string values;

        while ((values = Console.ReadLine()!) != ".")
        {
            Stack<char> brackets = new();
            bool isBalanced = true;
            
            foreach (char character in values)
            {
                if (character == '(' || character == '[')
                {
                    brackets.Push(character);
                    continue;
                }

                if (character != ')' && character != ']') continue;

                if (brackets.Count == 0 || brackets.Pop() != (character == ')' ? '(' : '['))
                {
                    isBalanced = false;
                    break;
                }
            }

            Console.WriteLine(isBalanced && brackets.Count == 0 ? "yes" : "no");
        }
    }
}