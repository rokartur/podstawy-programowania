class Program
{
    static void Main(string[] args)
    {
        const double EUR = 1.08, CHF = 1.12, GBP = 1.14, USD = 3.99;

        Console.WriteLine("Enter amount of PLN: ");
        double PLN = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Select currency: \n1. EUR ({EUR})\n2. CHF ({CHF})\n3. GBP ({GBP})");
        int choice = Convert.ToInt32(Console.ReadLine());
        PLN /= USD;

        switch (choice)
        {
            case 1:
                Console.WriteLine($"You will get {PLN * EUR} EUR");
                break;
            case 2:
                Console.WriteLine($"You will get {PLN * CHF} CHF");
                break;
            case 3:
                Console.WriteLine($"You will get {PLN * GBP} GBP");
                break;
            default:
                Console.WriteLine("Wrong choice");
                break;
        }
    }
}
