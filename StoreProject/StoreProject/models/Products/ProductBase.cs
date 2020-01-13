using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProject.models
{
    public abstract class ProductBase : IProduct
    {
        public string name { get; set; }
        public string price { get; set; }
        public string category { get; set; }
        public string size { get; set; }

        protected ProductBase(string name, string price, string size)
        {
            this.name = name;
            this.price = price;
            this.size = size;
        }
    }
}
