class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Access granted");
        }
        else if (age >= 15)
        {
            Console.WriteLine("Do you have parental consent? (y/n)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                Console.WriteLine("Access granted");
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("Access denied");
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
        }
        else
        {
            Console.WriteLine("Access denied");
        }
    }
}
