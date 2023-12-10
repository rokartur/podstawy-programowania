class Program
{
    private static void Main()
    {
        string[] pets = { "cat", "dog", "parrot", "guinea pig" };

        foreach (var pet in pets)
        {
            Console.WriteLine(pet);

            if (pet != "dog") continue;

            Console.WriteLine("End");
            Console.WriteLine("Do you want to see full list? (y/n)");
            var answer = Console.ReadLine()?.ToLower();

            if (answer == "y")
                continue;
            else if (answer == "n")
            {
                break;
            }
        }
    }
}
