class Program
{
    private static void Main()
    {
        Console.Write("Podaj pierwszy łańcuch: ");
        var string1 = Console.ReadLine();

        Console.Write("Podaj drugi łańcuch: ");
        var string2 = Console.ReadLine();

        Console.WriteLine($"Połączone łańcuchy: {string1 + string2}");
    }
}
