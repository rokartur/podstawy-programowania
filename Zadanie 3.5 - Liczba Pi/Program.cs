class Program
{
    private static void Main()
    {
        const int totalPoints = 10000000;
        double circlePoints = 0, squarePoints = 0;
        const double r = 1.0;
        var rand = new Random();
        var start = Environment.TickCount;

        for (var i = 0; i < totalPoints; i++)
        {
            var x = rand.NextDouble() * 2.0 - 1.0;
            var y = rand.NextDouble() * 2.0 - 1.0;
            
            if (x * x + y * y <= r * r) circlePoints++;
            squarePoints++;
        }

        var pi = 4 * (circlePoints / squarePoints);
        var stop = Environment.TickCount;

        Console.WriteLine($"Estimated Pi = {pi}");
        Console.WriteLine($"Elapsed time = {stop - start}ms");
    }
}
