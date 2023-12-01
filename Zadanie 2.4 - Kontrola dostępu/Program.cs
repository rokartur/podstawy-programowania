class Program
{
    private static void Main()
    {
        Console.WriteLine("Enter your age:");
        var age = Convert.ToInt32(Console.ReadLine());

        switch (age)
        {
            case >= 18:
                Console.WriteLine("Access granted");
                break;
            case >= 15:
            {
                Console.WriteLine("Do you have parental consent? (y/n)");
                var answer = Console.ReadLine();

                switch (answer?.ToLower())
                {
                    case "y":
                        Console.WriteLine("Access granted");
                        break;
                    case "n":
                        Console.WriteLine("Access denied");
                        break;
                    default:
                        Console.WriteLine("Wrong answer");
                        break;
                }

                break;
            }
            default:
                Console.WriteLine("Access denied");
                break;
        }
    }
}
