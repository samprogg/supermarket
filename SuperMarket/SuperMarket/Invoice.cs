using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Invoice : IPay
    {
        private List<Product> _products { get; set; }

        public TaskAwaiter AddProduct(Product product)
        {
            _products.Add(product);
        }
        public decimal ValueToPay()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{_products[0].Id}";
        }
    }
}
