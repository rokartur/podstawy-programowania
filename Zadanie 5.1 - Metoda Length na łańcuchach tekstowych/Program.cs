class Program
{
    private static void Main()
    {
        Console.Write("Podaj nazwę miasta: ");
        var city = Console.ReadLine();

        Console.Write("Podaj nazwę województwa: ");
        var region = Console.ReadLine();

        Console.WriteLine($"Nazwa miasta {city} zawiera {city?.Length} liter. Nazwa województwa {region} zawiera {region?.Length} liter.");
    }
}
