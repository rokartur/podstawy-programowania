class Program
{
    private static void Main()
    {
        const double eur = 1.08, chf = 1.12, gbp = 1.14, usd = 3.99;

        Console.WriteLine("Enter amount of PLN: ");
        var pln = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Select currency: \n1. EUR ({eur})\n2. CHF ({chf})\n3. GBP ({gbp})");
        var choice = Convert.ToInt32(Console.ReadLine());
        pln /= usd;

        switch (choice)
        {
            case 1:
                Console.WriteLine($"You will get {pln * eur} EUR");
                break;
            case 2:
                Console.WriteLine($"You will get {pln * chf} CHF");
                break;
            case 3:
                Console.WriteLine($"You will get {pln * gbp} GBP");
                break;
            default:
                Console.WriteLine("Wrong choice");
                break;
        }
    }
}
