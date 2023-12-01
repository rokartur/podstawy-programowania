class Program
{
    private static void Main()
    {
        var i = 1;
        do
        {
            var square = i * i;
            Console.WriteLine($"The square of {i} is {square}");
            i++;
        } while (i <= 20);
    }
}
