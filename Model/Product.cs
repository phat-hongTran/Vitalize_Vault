using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalize_Vault.Model
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime? ExpirationDate { get; set; }

    }
}
