using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP1.Entity;
using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace MCP1.Reposetery
{
    public class ProductRepositiry : IDbRepository<Product, int>
    {
        Eshopping2Context _context;

        public ProductRepositiry(Eshopping2Context context)
        {
            _context = context;
        }

      

        async Task<Product> IDbRepository<Product, int>.CreateAsync(Product entity)
        {
            try
            {
                var result = await _context.Products.AddAsync(entity);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<Product> IDbRepository<Product, int>.DeleteAsync(int id)
        {
            try
            {
                var record = await _context.Products.FindAsync(id);
                if (record == null)
                    throw new Exception($"The Record with Product Unique Id {id} is Missing");
                _context.Products.Remove(record);
                await _context.SaveChangesAsync();
                return record;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<IEnumerable<Product>> IDbRepository<Product, int>.GetAsync()
        {
            return await _context.Products.ToListAsync();
        }

        async Task<Product> IDbRepository<Product, int>.GetAsync(int id)
        {
            try
            {
                var record = await _context.Products.FindAsync(id);
                if (record == null)
                    throw new Exception($"The Record with Product Unique Id {id} is Missing");
                return record;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<Product> IDbRepository<Product, int>.UpdateAsync(int id, Product entity)
        {
            try
            {
                var record = await _context.Products.FindAsync(id);
                if (record == null)
                    throw new Exception($"The Record with Product Unique Id {id} is Missing");
                record.ProductName = entity.ProductName;
                record.ProductId = entity.ProductId;
                record.ManufractureId = entity.ManufractureId;
                record.Descrition = entity.Descrition;
                record.SubCategoryId = entity.SubCategoryId;
                record.Price = entity.Price;
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