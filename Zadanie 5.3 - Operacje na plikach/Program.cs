class Program
{
    private static void Main()
    {
        Console.Write("Podaj tytuł książki: ");
        var bookTitle = Console.ReadLine();

        Console.Write("Podaj nazwisko autora: ");
        var authorSurname = Console.ReadLine();

        const string filePath = "./library.txt";

        File.WriteAllText(filePath, $"{bookTitle}\n{authorSurname}");

        var fileContent = File.ReadAllLines(filePath);

        Console.WriteLine($"Tytuł książki: {fileContent[0]}");
        Console.WriteLine($"Nazwisko autora: {fileContent[1]}");
    }
}
