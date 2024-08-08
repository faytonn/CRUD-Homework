using CRUD_Homework.Exceptions;
using CRUD_stuff.Contexts;
using CRUD_stuff.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD_stuff.Services
{
    public class ProductService
    {
        private readonly AppDBContext context;

        public ProductService()
        {
            context = new AppDBContext();
        }

        public async Task CreateProductAsync(Product product)
        {
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await context.Products.Include(p => p.Category).AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await context.Products.Include(p => p.Category).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

            if (product is null)
                throw new NotFoundException("Product not found.");


            return product;
        }

        public async Task UpdateProductAsync(Product product)
        {

            var existProduct = await GetProductByIdAsync(product.Id);

            var isExist = await context.Products.AnyAsync(x => x.Name.ToLower() == existProduct.Name.ToLower() && x.Id != product.Id);

            if (isExist)
            {
                Console.WriteLine("This product already exists");
                return;
            }

            existProduct.Category = product.Category;
            existProduct.Name = product.Name;
            existProduct.Price = product.Price;

            context.Products.Update(product);
            await context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Product product)
        {
            var Exists = await GetProductByIdAsync(product.Id);
            context.Products.Remove(product);
            await context.SaveChangesAsync();
        }
    }
}