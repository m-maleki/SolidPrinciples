using System;

namespace SingleResponsibilityExample
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor to initialize product details
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // Method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Product Price: ${Price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Product
            Product product = new Product("Smartphone", 499.99m);

            // Displaying product details
            product.DisplayProductDetails();
        }
    }
}