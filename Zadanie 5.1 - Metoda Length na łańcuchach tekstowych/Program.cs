class Program
{
    private static void Main()
    {
        Console.Write("Podaj nazwę miasta: ");
        var city = Console.ReadLine();

        Console.Write("Podaj nazwę województwa: ");
        var region = Console.ReadLine();

        var cityLength = city?.Length;
        var regionLength = region?.Length;

        Console.WriteLine($"Nazwa miasta {city} zawiera {cityLength} liter. Nazwa województwa {region} zawiera {regionLength} liter.");
    }
}
