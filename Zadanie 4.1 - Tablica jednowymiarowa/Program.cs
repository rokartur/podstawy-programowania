class Program
{
    private static void Main()
    {
        var table = new int[10];

        for (var i = 0; i < table.Length; i++)
        {
            table[i] = i;
        }

        Console.WriteLine("Index\tValue");
        for (var i = 0; i < table.Length; i++)
        {
            Console.WriteLine($"{i}\t{table[i]}");
        }
    }
}
