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
            var answer = Console.ReadLine();

            if (answer?.ToLower() == "y")
            {
                foreach (var pet2 in pets)
                {
                    Console.WriteLine(pet2);
                }
                break;
            }
            else
            {
                Console.WriteLine("Bye!");
                break;
            }
        }
    }
}
