class Program
{
    private static void Main()
    {
        var matrix = new int[10, 10];
        var sum = 0;

        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    matrix[i, j] = i;
                    sum += i;
                }
                else
                {
                    matrix[i, j] = 0;
                }
            }
        }

        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Sum of diagonal elements: {sum}");
    }
}
