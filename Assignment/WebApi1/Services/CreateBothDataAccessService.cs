using WebApi1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi1.Services
{
    public class CreateBothDataAccessService : IBothCreate<Category , Product> 
    {
        Eshopping2Context context;

        public CreateBothDataAccessService(Eshopping2Context Context)
        {
            this.context = Context;
        }

        

        async Task<string> IBothCreate<Category, Product>.CreateBothAsync(Category category, Product product)
        {
            try
            {
                var result = await context.Categories.AddAsync(category);
                var result2 = await context.Products.AddAsync(product);
                await context.SaveChangesAsync();
                return "successfully created";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
