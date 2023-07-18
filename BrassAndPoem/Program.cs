
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 5.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Trombone",
        Price = 2.95M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Tuba",
        Price = 4.95M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Ozymandias",
        Price = 1.95M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Leaves of Grass",
        Price = 9.95M,
        ProductTypeId = 2
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title="Brass",
        Id=1
    },
        new ProductType()
    {
        Title="Poem",
        Id=2
    }
};

//put your greeting here
string greeting = @"Welcome to Brass & Poem 
Nubmer 1 Shop in TN";
Console.WriteLine(greeting);
//implement your loop here
DisplayMenu();

void DisplayMenu()
{
    string choice = null;
    while (choice != "0")
    {
        Console.WriteLine(@"Choose an option:
   1. Display all products
   2. Delete a product
   3. Add a new product
   4. Update product properties
   5. Exit");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            DisplayAllProducts( products, productTypes);
        }
        else if (choice == "2")
        {
            Console.WriteLine("Delete Products Here!");

        }
        else if (choice == "3")
        {
            Console.WriteLine("Add Products Here!");
        }
        else if (choice == "4")
        {
            Console.WriteLine("update Products Here!");
        }
        else if (choice == "5")
        {
            Console.WriteLine("GoodBye!");
        }
        else if (choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5")
        {
            Console.WriteLine("Please choose an existing menu item!");
        }
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("List of Products: ");


  
    for ( int i=0; i<products.Count; i++ )
    {
        var query =from pt in productTypes where products[i].ProductTypeId == pt.Id
                    select new { pt.Title };
        var productType=query.First();
        Console.WriteLine($"{i + 1} . {products[i].Name} that costs {products[i].Price} that is type {productType.Title}");

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