class Program
{
    private static void Main()
    {
        Console.WriteLine("Enter a:");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b:");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter c:");
        var c = Convert.ToInt32(Console.ReadLine());
        var delta = Math.Pow(b, 2) - 4 * a * c;
        var deltaRoot = Math.Sqrt(delta);
        Console.WriteLine("--------------------");
        Console.WriteLine($"Δ = {delta}");

        if (delta > 0)
        {
            Console.WriteLine($"√Δ = {deltaRoot}");
            var x1 = (-b - deltaRoot) / (2 * a);
            var x2 = (-b + deltaRoot) / (2 * a);
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if (deltaRoot == 0)
        {
            var x = -b / (2 * a);
            Console.WriteLine($"x = {x}");
        }
        else
        {
            Console.WriteLine("No solution");
        }
    }
}
