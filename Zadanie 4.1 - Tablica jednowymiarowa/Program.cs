﻿class Program
{
    private static void Main()
    {
        int[] table = new int[10];

        for (int i = 0; i < table.Length; i++)
        {
            table[i] = i;
        }

        Console.WriteLine("Index\tValue");
        for (int i = 0; i < table.Length; i++)
        {
            Console.WriteLine($"{i}\t{table[i]}");
        }
    }
}
