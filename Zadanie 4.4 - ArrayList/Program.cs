using System.Collections;

class Program
{
    private static void Main()
    {
        var cities = new ArrayList() { "Gdańsk", "Warszawa", "Katowice", "Poznań", "Kraków", "Rzeszów" };
        cities.Sort();

        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }
    }
}
