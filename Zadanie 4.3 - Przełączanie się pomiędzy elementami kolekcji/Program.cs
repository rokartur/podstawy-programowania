class Program
{
    private static void Main()
    {
        var table = new int[100];
        var sumOfEven = 0;
        var sumOfOdd = 0;

        for (var i = 0; i < table.Length; i++)
        {
            table[i] = i + 1;
        }

        foreach (var number in table)
        {
            if (number % 2 == 0)
            {
                sumOfEven += number;
            }
            else
            {
                sumOfOdd += number;
            }
        }

        Console.WriteLine($"Summary of even numbers: {sumOfEven}");
        Console.WriteLine($"Summary of odd numbers: {sumOfOdd}");
    }
}
