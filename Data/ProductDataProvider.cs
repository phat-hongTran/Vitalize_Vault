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
            await Task.Delay(100); // Simulate a bit of server work

            return new List<Product>
            {
                new Product { Id = 1, Name = "Milk", ExpirationDate = DateTime.Now.AddDays(7) },
                new Product { Id = 2, Name = "Eggs", ExpirationDate = DateTime.Now.AddDays(14) },
                new Product { Id = 3, Name = "Yogurt", ExpirationDate = DateTime.Now.AddDays(10) },
                new Product { Id = 4, Name = "Cheese", ExpirationDate = DateTime.Now.AddDays(30) },
                new Product { Id = 5, Name = "Juice", ExpirationDate = DateTime.Now.AddDays(20) }
            };
        }
    }
}
