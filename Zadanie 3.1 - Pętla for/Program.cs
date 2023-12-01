class Program
{
    private static void Main()
    {
        for (var x = 0; x <= 10; x++)
        {
            var y = Math.Pow(3, 2) * x;
            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
