class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a:");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b:");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter c:");
        double c = Convert.ToInt32(Console.ReadLine());
        double delta = Math.Pow(b, 2) - 4 * a * c;
        double deltaRoot = Math.Sqrt(delta);
        Console.WriteLine("--------------------");
        Console.WriteLine($"Δ = {delta}");

        if (delta > 0)
        {
            Console.WriteLine($"√Δ = {deltaRoot}");
            double x1 = (-b - deltaRoot) / (2 * a);
            double x2 = (-b + deltaRoot) / (2 * a);
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        } else if (deltaRoot == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"x = {x}");
        } else
        {
            Console.WriteLine("No solution");
        }
    }
}
