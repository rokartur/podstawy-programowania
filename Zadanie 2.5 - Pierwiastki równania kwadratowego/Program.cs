class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a:");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b:");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter c:");
        double c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The delta root is: {Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)}");
    }
}
