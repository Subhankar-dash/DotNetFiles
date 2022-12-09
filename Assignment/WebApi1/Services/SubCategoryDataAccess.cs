using Microsoft.EntityFrameworkCore;
using WebApi1.Models;


namespace WebApi1.Services
    
{
    public class SubCategoryDataAccess : IDbAccessService<SubCategory,int>
    {
        Eshopping2Context context;
        
        public SubCategoryDataAccess(Eshopping2Context context)
        {
            this.context = context;
        }


        

        public Task<SubCategory> CreateAsync(SubCategory entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SubCategory>> GetAsync()
        {
             var result =   await context.SubCategories.ToListAsync();
            
            return result;
        }



        public async Task<SubCategory> GetAsync(int id)
        {
            var record = await context.SubCategories.FindAsync(id);
            if (record == null)
                throw new Exception("Record  not found");
            return record;
        }

        public Task<SubCategory> UpdateAsync(int id, SubCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}


