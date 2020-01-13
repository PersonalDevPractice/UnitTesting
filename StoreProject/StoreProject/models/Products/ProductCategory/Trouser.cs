using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProject.models.ProductCategory
{
    public class Trouser : ProductBase
    {
        public Trouser(string name, string price, string size) : base(name, price, size)
        {
            category = "trouser";
        }
    }
}
