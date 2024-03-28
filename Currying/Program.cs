// Sample data: List of products
List<Product> products = new List<Product>
        {
            new Product("Laptop", "Electronics", 1000),
            new Product ("Phone", "Electronics", 700),
            new Product ("Shirt", "Clothing", 25),
            new Product ("Shoes", "Clothing", 50)
        };

// Define curried filter functions
Func<int, int, Func<Product, bool>> priceFilter = CurriedFilter.Curry((Product product, int min, int max) => product.Price >= min && product.Price <= max);
Func<string, Func<Product, bool>> categoryFilter = CurriedFilter<Product>.Curry((Product product, string category) => product.Category == category);

// Partial application: Filter products within a price range
var filterByPriceRange = priceFilter(50, 500);
var filteredProductsByPrice = products.Where(filterByPriceRange);

Console.WriteLine("Products within the price range of $50 to $500:");
foreach (var product in filteredProductsByPrice)
{
    Console.WriteLine(product);
}

// Partial application: Filter products by category
var filterByCategory = categoryFilter("Electronics");
var filteredProductsByCategory = products.Where(filterByCategory);

Console.WriteLine("\nElectronics products:");
foreach (var product in filteredProductsByCategory)
{
    Console.WriteLine(product);
}
