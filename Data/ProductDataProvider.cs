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
    }
    public class ProductDataProvider : IProductDataProvider
    {
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            using var db = new ProductDbContext();

            var products = db.Products;

            return await products.ToListAsync();
        }
    }
}
