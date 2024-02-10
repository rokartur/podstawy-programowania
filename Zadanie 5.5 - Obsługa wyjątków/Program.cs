class Program
{
    private static void Main()
    {
        var array = new int[10, 10];
        for (var i = 0; i < 10; i++)
        {
            for (var j = 0; j < 10; j++)
            {
                array[i, j] = 1;
            }
        }

        const string filePath = "dane.txt";
        // const string anotherFilePathForTest = "test.txt";
        using (var sw = new StreamWriter(filePath))
        {
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    sw.Write(array[i, j] + " ");
                }
                sw.WriteLine();
            }
        }

        try
        {
            var fileContent = File.ReadAllLines(filePath);
            foreach (var line in fileContent)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Plik {filePath} nie istnieje.");
        }
    }
}
