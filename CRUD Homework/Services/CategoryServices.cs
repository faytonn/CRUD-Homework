using CRUD_Homework.Exceptions;
using CRUD_stuff.Contexts;
using CRUD_stuff.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_stuff.Services
{
    public class CategoryService
    {
        public async Task CreateCategoryAsync(Category category)
        {
            AppDBContext context = new AppDBContext();
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            AppDBContext context = new AppDBContext();
            var categories = await context.Categories.AsNoTracking().ToListAsync();
            return categories;
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            AppDBContext context = new AppDBContext();
            var category = await context.Categories.FirstOrDefaultAsync(p => p.Id == id);

            if (category is null)
            {
                throw new NotFoundException("Category not found.");
            }

            return category;
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            AppDBContext context = new AppDBContext();

            var Exists = await GetCategoryByIdAsync(category.Id);
            context.Categories.Update(category);
            await context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Category category)
        {
            AppDBContext context = new AppDBContext();
            var Exists = await GetCategoryByIdAsync(category.Id);
            context.Categories.Remove(category);
            await context.SaveChangesAsync();
        }
    }
}