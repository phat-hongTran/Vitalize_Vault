using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalize_Vault.Model;

namespace Vitalize_Vault.Data
{
    public interface IProductDataProvider
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<bool> DeleteAsync(int id);
    }
    public class ProductDataProvider : IProductDataProvider
    {
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            using var db = new ProductDbContext();

            var products = db.Products;

            return await products.ToListAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var db = new ProductDbContext();

            var product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product != null) 
            {
                db.Products.Remove(product);
                int rowsAffected = await  db.SaveChangesAsync();
                return rowsAffected > 0;
            }

            return false;
        }
    }
}
