using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using StoreProject.models.HttpClient;

namespace StoreProject.models.Checkout
{
    public class Checkout
    {
        private IStoreClient StoreClient { get; }
        public Checkout()
        {
            StoreClient = new Client("http://www.RealEndpointBase.co.uk");
        }

        public Checkout(IStoreClient storeClient)
        {
            StoreClient = storeClient;
        }

        public Receipt CheckoutBasket(Basket.Basket basket)
        {
            Receipt receiptResult;
            try
            {
                var result = StoreClient.ProcessPurchaseRequest(basket);
                receiptResult = result.Item2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
                receiptResult = new Receipt("Exception", "Exception thrown processing basket", false);
            }

            return receiptResult;
        }
    }
}
