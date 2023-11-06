using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return ValueToPay();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
