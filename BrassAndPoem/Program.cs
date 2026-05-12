
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 299.99M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Trombone",
        Price = 1449.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "The Waste Land by T.S. Eliot",
        Price = 12.99M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "French Horn",
        Price = 899.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Leaves of Grass by Walt Whitman",
        Price = 9.99M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Tuba",
        Price = 1200.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Ariel by Sylvia Plath",
        Price = 14.99M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Flugelhorn",
        Price = 599.99M,
        ProductTypeId = 1
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
    Console.WriteLine(@"Choose an option from the menu:
                        0.
                        1.
                        2.
                        3.
                        4.
                        5.");

    choice = Console.ReadLine();

    if (string.IsNullOrEmpty(choice))
    {
        Console.WriteLine("No option was selected. Please try again.");
    }
    else if (choice == "5")
    {
        Console.WriteLine($"{choice} is correct! Exiting the program.");
    }
    else
    {
        Console.WriteLine($"Sorry, {choice} is incorrect. Try again.");
    }
}


void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
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