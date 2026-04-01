class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        Member[] members = new Member[n];

        for (int i = 0; i < n; i++)
        {
            string[] information = Console.ReadLine()!.Split();

            members[i] = new Member(i, int.Parse(information[0]), information[1]);
        }

        Array.Sort(members, (first, second) =>
        {
            int comparison = first.Age.CompareTo(second.Age);
            if (comparison != 0) return comparison;

            return first.Index.CompareTo(second.Index);
        });

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{members[i].Age} {members[i].Name}");
        }
    }

    struct Member
    {
        public int Index;
        public int Age;
        public string Name;

        public Member(int index, int age, string name)
        {
            Index = index;
            Age = age;
            Name = name;
        }
    }
}