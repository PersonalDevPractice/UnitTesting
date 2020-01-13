using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProject.models.ProductCategory
{
    public class Shoe : ProductBase
    {
        public Shoe(string name, string price, string size) : base(name, price, size)
        {
            category = "shoe";
        }
    }
}
