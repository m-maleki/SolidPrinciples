using System;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class DiscountCalculator
{
    public virtual decimal CalculateDiscount(Product product)
    {
        // Default discount calculation logic
        return product.Price * 0.1m; // 10% discount
    }
}

class BlackFridayDiscountCalculator : DiscountCalculator
{
    public override decimal CalculateDiscount(Product product)
    {
        // Custom discount calculation for Black Friday
        return product.Price * 0.2m; // 20% discount
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product laptop = new Product("Laptop", 1000.0m);

        // Calculate discount using default logic
        DiscountCalculator defaultCalculator = new DiscountCalculator();
        decimal defaultDiscount = defaultCalculator.CalculateDiscount(laptop);
        Console.WriteLine($"Default discount for {laptop.Name}: ${defaultDiscount}");

        // Calculate discount using Black Friday logic
        BlackFridayDiscountCalculator blackFridayCalculator = new BlackFridayDiscountCalculator();
        decimal blackFridayDiscount = blackFridayCalculator.CalculateDiscount(laptop);
        Console.WriteLine($"Black Friday discount for {laptop.Name}: ${blackFridayDiscount}");
    }
}