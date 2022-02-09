using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo22
{
    class Product
        : IComparable
    {
        public int productid { get; set; }

        public string productname { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        #region IComparable interface members

        public int CompareTo(object O)
        {
            return this.productid.CompareTo((O as Product).productid);
        }

        #endregion
    }
}
