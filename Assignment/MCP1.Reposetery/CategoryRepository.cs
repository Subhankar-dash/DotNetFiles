using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;
using MVP1.Entity;
using Microsoft.EntityFrameworkCore;

namespace MCP1.Reposetery
{
    public class CategoryRepository : IDbRepository<Category, int>
    {
        Eshopping2Context _context;
        public CategoryRepository(Eshopping2Context context)
        {
            _context = context;
        }

        async Task<Category> IDbRepository<Category, int>.CreateAsync(Category entity)
        {
            try
            {
                var result = await _context.Categories.AddAsync(entity);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<Category> IDbRepository<Category, int>.DeleteAsync(int id)
        {
            try
            {
                var record = await _context.Categories.FindAsync(id);
                if (record == null)
                    throw new Exception($"The Record with Category Id {id} is Missing");
                _context.Categories.Remove(record);
                await _context.SaveChangesAsync();
                return record;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<IEnumerable<Category>> IDbRepository<Category, int>.GetAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        async Task<Category> IDbRepository<Category, int>.GetAsync(int id)
        {
            try
            {
                var record = await _context.Categories.FindAsync(id);
                if (record == null)
                    throw new Exception($"The Record with Category Id {id} is Missing");
                return record;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<Category> IDbRepository<Category, int>.UpdateAsync(int id, Category entity)
        {
            try
            {
                
                var record = await _context.Categories.FindAsync(id);
                if (record == null)
                    throw new Exception($"The Record with Category Id {id} is Missing");
                record.CategoryName = entity.CategoryName;
                record.BasePrice = entity.BasePrice;
                await _context.SaveChangesAsync();
                
                return record;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
