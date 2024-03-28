class Program
{
    static void Main(string[] args)
    {
        // Calculate the total price of items in a shopping cart
        decimal[] prices = { 10.50m, 20.75m, 5.30m, 15.20m };
        decimal totalPrice = CalculateTotalPrice(prices);

        Console.WriteLine($"Total price: {totalPrice}");
    }

    // Pure function: CalculateTotalPrice calculates the total price of items in a shopping cart
    static decimal CalculateTotalPrice(decimal[] prices)
    {
        decimal total = 0;
        foreach (var price in prices)
        {
            total += price;
        }
        return total;
    }
}
