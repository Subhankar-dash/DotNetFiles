using WebApi1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi1.Services
{
    /// <summary>
    /// Inject the eSoppingCodiContext to this class
    /// using Constructor Injection
    /// </summary>
    public class CategoryDataAccessService : IDbAccessService<Category, int>
    {
        Eshopping2Context context;
        /// <summary>
        /// Injection. The eShoppingCodiContext instance will be 
        /// read from DI Container of the Application
        /// </summary>
        /// <param name="context"></param>
        public CategoryDataAccessService(Eshopping2Context context)
        {
            this.context = context;
        }

        async Task<Category> IDbAccessService<Category, int>.CreateAsync(Category entity)
        {
            try
            {
                var result = await context.Categories.AddAsync(entity);
                await context.SaveChangesAsync();
                return result.Entity;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        async Task<bool> IDbAccessService<Category, int>.DeleteAsync(int id)
        {
            var recordToDelete = await context.Categories.FindAsync(id);
            if (recordToDelete == null) throw new Exception("Record for Delete is not found");

            context.Categories.Remove(recordToDelete);
            int result = await context.SaveChangesAsync();
            if (result > 0) return true;
            else
            {
                return false;
            }
        }

        async Task<IEnumerable<Category>> IDbAccessService<Category, int>.GetAsync()
        {
            return await context.Categories.ToListAsync();
        }

        async Task<Category> IDbAccessService<Category, int>.GetAsync(int id)
        {
            var record = await context.Categories.FindAsync(id);
            if (record == null)
                throw new Exception("Record  not found");
            return record;

        }

        async Task<Category> IDbAccessService<Category, int>.UpdateAsync(int id, Category entity)
        {
            try
            {
                var recordToUpate = await context.Categories.FindAsync(id);
                if (recordToUpate == null) throw new Exception("Record for Update is not found");

                recordToUpate.CategoryName = entity.CategoryName;
                recordToUpate.BasePrice = entity.BasePrice;
                await context.SaveChangesAsync();
                return recordToUpate;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}