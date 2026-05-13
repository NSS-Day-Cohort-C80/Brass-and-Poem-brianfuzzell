
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
    else if (choice == "5")
    {
        Console.WriteLine("Goodbye!");
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
    DisplayAllProducts(products, productTypes);

    Product chosenProduct = null;

    Console.WriteLine("Which product do you want to delete?");

    string deletedItem = Console.ReadLine().Trim();

    while (string.IsNullOrEmpty(deletedItem))
    {
        Console.WriteLine("You didn't choose anything, try again!");

        deletedItem = Console.ReadLine().Trim();
    }

    Product deletedProduct = products[int.Parse(deletedItem) - 1];

    products.Remove(deletedProduct);

    Console.WriteLine($"{deletedProduct.Name} has been deleted.");

    chosenProduct = deletedProduct;
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter the name of the product you want to add: ");
    string name = Console.ReadLine().Trim();

    Console.WriteLine("Please enter the price: ");
    decimal price = decimal.Parse(Console.ReadLine().Trim());

    Console.WriteLine("Please enter the product type: ");

    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
    }
    int type = int.Parse(Console.ReadLine().Trim());

    while (type > productTypes.Count || type < 1)
    {
        Console.WriteLine($"Choose a number between 1 and {productTypes.Count}");
        type = int.Parse(Console.ReadLine().Trim());
    }
    List<Product> categories = products.Where(product => product.ProductTypeId == productTypes[type - 1].Id).ToList();

    products.Add(new Product()
    {
        Name = name,
        Price = price,
        ProductTypeId = productTypes[type - 1].Id
    });
    Console.WriteLine($"{name}");
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);

    Product chosenProduct = null;

    Console.WriteLine("Which product should we update?");

    int updatedItem = int.Parse(Console.ReadLine().Trim());

    Product productToUpdate = products[updatedItem - 1];

    Console.WriteLine(@$"Here are this product's current details:
    Name: {productToUpdate.Name}
    Price: ${productToUpdate.Price}
    Type: {productToUpdate.ProductTypeId}");

    Console.WriteLine($"To update the name, enter the new name now: ");

    string newName = Console.ReadLine()!.Trim();

    if (!string.IsNullOrEmpty(newName))
    {
        productToUpdate.Name = newName;
    }

    Console.WriteLine($"To update the price, enter the new price now: ");

    string newPrice = Console.ReadLine()!.Trim();

    if (!string.IsNullOrEmpty(newPrice))
    {
        productToUpdate.Price = decimal.Parse(newPrice);
    }

    Console.WriteLine($"Product Types:");

    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
    }

    Console.WriteLine($"The current product type is {productToUpdate.ProductTypeId}. To update the type, enter the new type now: ");

    string newType = Console.ReadLine()!.Trim();

    if (!string.IsNullOrEmpty(newType))
    {
        productToUpdate.ProductTypeId = int.Parse(newType);
    }

    Console.WriteLine(@$"The product's new details are:
    Name: {productToUpdate.Name}
    Price: ${productToUpdate.Price}
    Product Type: {productToUpdate.ProductTypeId}
    
    Product is updated!");

    chosenProduct = productToUpdate;
}

// don't move or change this!
public partial class Program { }