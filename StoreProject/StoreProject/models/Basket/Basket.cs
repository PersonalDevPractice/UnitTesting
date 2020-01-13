using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProject.models.Basket
{
    public class Basket
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<IProduct> Products { get; set; }

        public Basket(int id, int customerId, List<IProduct> products)
        {
            Id = id;
            CustomerId = customerId;
            Products = products;
        }
    }
}
