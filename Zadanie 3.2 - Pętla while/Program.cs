class Program
{
    private static void Main()
    {
        var sum = 0;
        var min = int.MaxValue;

        while (true)
        {
            Console.Write("Enter a number (0-10): ");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num is < 0 or > 10)
            {
                continue;
            }

            if (num == 5)
            {
                break;
            }

            if (num < min)
            {
                min = num;
            }

            sum += num * num;
        }

        Console.WriteLine($"Sum of squares: {sum}");
        Console.WriteLine($"Minimum number: {min}");
    }
}
