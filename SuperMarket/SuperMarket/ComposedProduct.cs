using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class ComposedProduct : Product
    {
        public List<Product> Products { get; set; }
        public float Discount { get; set; }

        public override decimal ValueToPay()
        {
            decimal payroll = 0;

            foreach (Product products in Products)
            {
                payroll += products.Price * (decimal)Discount;
            }
            return payroll;
        }
        private string productoslista()
        {
            string listaprod = null;
            foreach (Product products in Products)
            {
                listaprod += products.Description +",";
            }
            return listaprod;
        }
        
        public override string ToString()
        {
            return 
                   $"\n\tProducts.................: {$"{productoslista()}",15}" +
                   $"\n\tDiscount.................: {$"{Discount:P2}",15}" +
                   $"\n\tValue....................: {$"{ValueToPay():C2}",15}"
                   ;
        }
    }
}
