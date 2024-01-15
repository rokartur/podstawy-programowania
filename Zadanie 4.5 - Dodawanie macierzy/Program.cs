class Program
{
    private static void Main()
    {
        const int matrixSize = 10;
        var matrix1 = new int[matrixSize, matrixSize];
        var matrix2 = new int[matrixSize, matrixSize];
        var matrix3 = new int[matrixSize, matrixSize];

        for (var i = 0; i < matrix1.GetLength(0); i++)
        {
            for (var j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i, j] = 1;
                matrix2[i, j] = 2;
            }
        }

        for (var i = 0; i < matrix1.GetLength(0); i++)
        {
            for (var j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Result matrix:");
        for (var i = 0; i < matrix1.GetLength(0); i++)
        {
            for (var j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write($"{matrix3[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}
