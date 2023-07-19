
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System.Collections.Generic;
using System.ComponentModel.Design;
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
    while (choice != "5")
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
            DeleteProduct( products, productTypes);

        }
        else if (choice == "3")
        {
            AddProduct( products, productTypes);
        }
        else if (choice == "4")
        {
            UpdateProduct(products, productTypes);
        }
        else if (choice == "5")
        {
            Console.WriteLine("GoodBye!");
        }
        else if (choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5" || choice == null)
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
        //var Value= productTypes.First(p=> p.Id == products[i].ProductTypeId);
        Console.WriteLine($"{i + 1} . {products[i].Name} that costs {products[i].Price} that is type {productType.Title}");

    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts( products, productTypes);
    Console.WriteLine("Select a product you wish to delete");

    int removeProduct =  Convert.ToInt32(Console.ReadLine());

    if(removeProduct == 0 )
    { Console.WriteLine("Please select a product between 1-5");}
    else
    {
        products.RemoveAt(removeProduct-1);
    }

}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter a product name ");
    string Name = Console.ReadLine();
    Console.WriteLine("Enter the product's price");
    decimal Price = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Select a product type");
    for(int i=0; i<productTypes.Count; i++ )
    {
        Console.WriteLine($"{i+1}. {productTypes[i].Title}");
    }
    int ProductTypeid= int.Parse(Console.ReadLine());
    Product newProduct = new Product
    { Name = Name,
      Price = Price,
      ProductTypeId = ProductTypeid    
    }; 
    products.Add(newProduct);
    Console.WriteLine("Thank you for adding a product.Product has been added");
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        var query = from pt in productTypes
                    where products[i].ProductTypeId == pt.Id
                    select new { pt.Title };
        var productType = query.First();
        //Antoher way var Value= productTypes.First(p=> p.Id == products[i].ProductTypeId);
        Console.WriteLine($"{i + 1} . {products[i].Name}");

    }
    Console.WriteLine("Select the product you would like to update :");
    int updateProduct = int.Parse(Console.ReadLine());
    Product selectedProduct = products[updateProduct - 1];
    Console.WriteLine($"You Selected {selectedProduct.Name} that costs {selectedProduct.Price} and it's Product type id is {selectedProduct.ProductTypeId}");
    Console.WriteLine("Update the product name ");
    string Name = Console.ReadLine();
    if ( string.IsNullOrEmpty(Name)) {
        products[updateProduct - 1].Name = products[updateProduct - 1].Name;
    } else {
        products[updateProduct - 1].Name = Name;
    }
    Console.WriteLine("Update the product's price");
    try
    {
        decimal Price = decimal.Parse(Console.ReadLine());
        products[updateProduct - 1].Price = Price;
    }
    catch(FormatException)
    {
        products[updateProduct - 1].Price = products[updateProduct - 1].Price;
    }
    Console.WriteLine("Update the product's type");
    try
    {
        int ProductTypeId = int.Parse(Console.ReadLine());
        products[updateProduct - 1].ProductTypeId = ProductTypeId;
    }
    catch (FormatException) 
    {
        products[updateProduct - 1].ProductTypeId = products[updateProduct - 1].ProductTypeId;
    }
   

    Console.WriteLine("Here is your updated list");
    DisplayAllProducts(products, productTypes);


}

// don't move or change this!
public partial class Program { }