using System;
class Stock
{
    string stockName;
    string stockSymbol;
    double previousClosingPrice;
    double currentClosingPrice;
    // Constructor
    public Stock(string name, string symbol, double previous, double current)
    {
        stockName = name;
        stockSymbol = symbol;
        previousClosingPrice = previous;
        currentClosingPrice = current;
    }
    // Method to calculate percentage change
    public double GetChangePercentage()
    {
        return ((currentClosingPrice - previousClosingPrice) / previousClosingPrice) * 100;
    }
    static void Main()
    {
        Stock s = new Stock("Infosys", "Infosys", 4000, 4275);
        Console.WriteLine("Stock Name       : " + s.stockName);
        Console.WriteLine("Stock Symbol     : " + s.stockSymbol);
        Console.WriteLine("Previous Price   : " + s.previousClosingPrice);
        Console.WriteLine("Current Price    : " + s.currentClosingPrice);
        Console.WriteLine("Change Percentage: " + s.GetChangePercentage().ToString("F2") + "%");
        Console.ReadLine();
    }
}
