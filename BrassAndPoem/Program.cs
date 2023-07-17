
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
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

//implement your loop here

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