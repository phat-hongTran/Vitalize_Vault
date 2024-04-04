using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vitalize_Vault.Model
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public static int ElapsedDays(DateTime exp)
        {
            if (exp.Equals(null))
            {
                return -1;
            }

            TimeSpan difference = DateTime.Now - exp;

            double days = difference.TotalDays;

            if (days < 0)
            {
                return -1;
            }

            return (int)days;
        }
    }
}
