class Program
{
    static void Main()
    {
        string value;

        while ((value = Console.ReadLine()!) != null)
        {
            char[] name = value.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                switch (name[i])
                {
                    case 'i':
                        name[i] = 'e';
                        break;
                    case 'e':
                        name[i] = 'i';
                        break;
                    case 'I':
                        name[i] = 'E';
                        break;
                    case 'E':
                        name[i] = 'I';
                        break;
                }
            }

            Console.WriteLine(name);
        }
    }
}