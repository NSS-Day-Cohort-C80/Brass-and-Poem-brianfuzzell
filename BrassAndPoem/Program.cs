
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 150.99M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Trombone",
        Price = 246.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Tuba",
        Price = 1250.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Ozymandias",
        Price = 12350.99M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Leaves of Grass",
        Price = 15650.99M,
        ProductTypeId = 2
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Id = 1,
        Title = "Brass"
    },
    new ProductType()
    {
        Id = 2,
        Title = "Poem"
    }
};

//put your greeting here
string greeting = @"Welcome to Brass & Poem
The best brass instruments and poetry collection in the Heartland";

Console.WriteLine(greeting);

//implement your loop here
string choice = null;
while (choice != "5")
{
    Console.WriteLine(@"Choose an option from the menu:");

    DisplayMenu();

    choice = Console.ReadLine();

    if (string.IsNullOrEmpty(choice))
    {
        Console.WriteLine("No option was selected. Please try again.");
    }
    else if (choice == "1")
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (choice == "2")
    {
        DeleteProduct(products, productTypes);
    }
    else if (choice == "3")
    {
        AddProduct(products, productTypes);
    }
    else if (choice == "4")
    {
        UpdateProduct(products, productTypes);
    }
}

void DisplayMenu()
{
    Console.WriteLine(@"1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Products:");
    for (int i = 0; i < products.Count; i++)
    {
        ProductType matchedProduct = productTypes.FirstOrDefault(product => product.Id == products[i].ProductTypeId);
        Console.WriteLine($"{i + 1}. {products[i].Name} | {matchedProduct.Title} | ${products[i].Price}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }