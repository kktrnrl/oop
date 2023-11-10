using System;

class Converter
{
    private decimal usdRate;
    private decimal eurRate;

    public Converter(decimal usdRate, decimal eurRate)
    {
        this.usdRate = usdRate;
        this.eurRate = eurRate;
    }

    public decimal ConvertToUSD(decimal amountInUah)
    {
        return amountInUah / usdRate;
    }

    public decimal ConvertToEUR(decimal amountInUah)
    {
        return amountInUah / eurRate;
    }

    public decimal ConvertFromUSD(decimal amountInUsd)
    {
        return amountInUsd * usdRate;
    }

    public decimal ConvertFromEUR(decimal amountInEur)
    {
        return amountInEur * eurRate;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converter1 = new Converter(36.14M, 28.72M);
        Converter converter2 = new Converter(37.2995M, 40.0192M);
        string symbol = new string('-', 100);

        while (true)
        {
            Console.WriteLine(symbol);
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Convert from UAH to USD");
            Console.WriteLine("2. Convert from UAH to EUR");
            Console.WriteLine("3. Convert from USD to UAH");
            Console.WriteLine("4. Convert from EUR to UAH");
            Console.WriteLine("5. Exit");
            Console.WriteLine(symbol);

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the amount in UAH: ");
                decimal amountInUah = decimal.Parse(Console.ReadLine());
                decimal amountInUsd = converter1.ConvertToUSD(amountInUah);
                Console.WriteLine($"Result: {amountInUah} UAH = {amountInUsd} USD");
            }
            else if (choice == "2")
            {
                Console.Write("Enter the amount in UAH: ");
                decimal amountInUah = decimal.Parse(Console.ReadLine());
                decimal amountInEur = converter1.ConvertToEUR(amountInUah);
                Console.WriteLine($"Result: {amountInUah} UAH = {amountInEur} EUR");
            }
            else if (choice == "3")
            {
                Console.Write("Enter the amount in USD: ");
                decimal amountInUsd = decimal.Parse(Console.ReadLine());
                decimal amountInUah = converter2.ConvertFromUSD(amountInUsd);
                Console.WriteLine($"Result: {amountInUsd} USD = {amountInUah} UAH");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the amount in EUR: ");
                decimal amountInEur = decimal.Parse(Console.ReadLine());
                decimal amountInUah = converter2.ConvertFromEUR(amountInEur);
                Console.WriteLine($"Result: {amountInEur} EUR = {amountInUah} UAH");
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorrect choice. Please choose an action from 1 to 5..");
            }
        }
    }
}
