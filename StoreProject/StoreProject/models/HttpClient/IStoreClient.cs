using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StoreProject.models.Checkout;

namespace StoreProject.models.HttpClient
{
    public interface IStoreClient
    {
        Tuple<Boolean, Receipt> ProcessPurchaseRequest(Basket.Basket basket);
    }
}
