using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProject.models.ProductCategory
{
    public class Tshirt : ProductBase
    {
        public Tshirt(string name, string price, string size) : base(name, price, size)
        {
            category = "tshirt";
        }
    }
}
