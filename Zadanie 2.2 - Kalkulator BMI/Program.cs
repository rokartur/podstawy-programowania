class Program
{
    private static void Main()
    {
        Console.WriteLine("Enter your weight in kilograms:");
        var weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your height in centimeters:");
        var height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your BMI is: " + (weight / ((height / 100) * (height / 100))));
    }
}
