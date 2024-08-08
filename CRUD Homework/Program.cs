using CRUD_stuff.Models;
using CRUD_stuff.Services;

CategoryService categoryService = new CategoryService();
ProductService productService = new ProductService();
Category category = new Category
{
    Name = "Electronics"
};
Category category2 = new Category
{
    Name = "Furniture"
};
Category category3 = new Category
{
    Name = "Miscellaneous"
};

//await categoryService.CreateCategoryAsync(category);
//await categoryService.CreateCategoryAsync(category2);
//await categoryService.CreateCategoryAsync(category3);

Product product = new Product
{
    Name = "Laptop",
    Price = 2000,
    CategoryId = 1,
};

Product product1 = new Product
{
    Name = "Nokia",
    Price = 90,
    CategoryId = 1
};

Product product2 = new Product
{
    Name = "Chair",
    Price = 200,
    CategoryId = 2
};

Product product3 = new Product
{
    Name = "Table",
    Price = 1500,
    CategoryId = 2
};

Product product4 = new Product
{
    Name = "C# Programming for Beginners",
    Price = 30,
    CategoryId = 3
};

Product product5 = new Product
{
    Name = "Lego Technic",
    Price = 95,
    CategoryId = 3
};

Product product6 = new Product
{
    Name = "Camping Lantern",
    Price = 45,
    CategoryId = 3
};

Product product7 = new Product
{
    Name = "Desk Organizer",
    Price = 10,
    CategoryId = 3
};

Product product8 = new Product
{
    Name = "Multi-purpose tool",
    Price = 4,
    CategoryId = 3
};

//await productService.CreateProductAsync(product);
//await productService.CreateProductAsync(product1);
//await productService.CreateProductAsync(product2);
//await productService.CreateProductAsync(product3);
//await productService.CreateProductAsync(product4);
//await productService.CreateProductAsync(product5);
//await productService.CreateProductAsync(product6);
//await productService.CreateProductAsync(product7);
//await productService.CreateProductAsync(product8);


//var products = await productService.GetAllProductsAsync();
//Console.WriteLine("All Products:");
//foreach (var p in products)
//{
//    Console.WriteLine(p);
//}


Product updatedProduct = new Product
{
    Id = 5,
    Name = "Camping Tent3113312312212",
    Price = 1200,
    CategoryId = 3
};


await productService.UpdateProductAsync(updatedProduct);