using WebApi1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi1.Services
{
    public class ProductDataAccessService : IDbAccessService<Product, int>
    {
        Eshopping2Context context;

        public ProductDataAccessService(Eshopping2Context context)
        {
            this.context = context;
        }

        public async Task<Product> GetAsync(int id)
        {
            var record = await context.Products.FindAsync(id);
            if (record == null)
                throw new Exception("Record  not found");
            return record;
        }

        async Task<Product> IDbAccessService<Product, int>.CreateAsync(Product entity)
        {
            try
            {
                var result = await context.Products.AddAsync(entity);
                await context.SaveChangesAsync();
                return result.Entity;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        async Task<bool> IDbAccessService<Product, int>.DeleteAsync(int id)
        {
            var recordToDelete = await context.Products.FindAsync(id);
            if (recordToDelete == null) throw new Exception("Record for Delete is not found");

            context.Products.Remove(recordToDelete);
            int result = await context.SaveChangesAsync();
            if (result > 0) return true;
            else
            {
                return false;
            }
        }

        async Task<IEnumerable<Product>> IDbAccessService<Product, int>.GetAsync()
        {
            return await context.Products.ToListAsync();
        }

       

        async Task<Product> IDbAccessService<Product, int>.UpdateAsync(int id, Product entity)
        {
            try
            {
                var recordToUpate = await context.Products.FindAsync(id);
                if (recordToUpate == null) throw new Exception("Record for Deleteupdate is not found");
                recordToUpate.ProductId = entity.ProductId;
                recordToUpate.ProductName = entity.ProductName;
                recordToUpate.Descrition = entity.Descrition;
                recordToUpate.Price = entity.Price;
                recordToUpate.SubCategoryId = entity.SubCategoryId;
                
               // recordToUpate.Manufracture = entity.Manufracture;
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