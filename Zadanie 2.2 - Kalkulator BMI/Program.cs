class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your weight in kilograms:");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your height in centimeters:");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your BMI is: " + (weight / ((height / 100) * (height / 100))));
    }
}
