using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using StoreProject.models.Checkout;

namespace StoreProject.models.HttpClient
{
    public class Client : IStoreClient
    {
        private IRestClient RestClient { get; }
        public Client(string url)
        {
            RestClient = new RestClient(url);
        }

        public Client(IRestClient restClient)
        {
            RestClient = restClient;
        }

        public Tuple<bool, Receipt> ProcessPurchaseRequest(Basket.Basket basket)
        {
            var executeRequest = SendDbPurchaseRequest(basket);
            var handledResponse = HandleDbPurchaseResponse(executeRequest);

            return new Tuple<bool, Receipt>(true, handledResponse);
        }
        private IRestResponse SendDbPurchaseRequest(Basket.Basket basket)
        {
            var request = GenerateRequest(Method.POST);
            var jsonBasket = JsonConvert.SerializeObject(basket);
            request.AddJsonBody(jsonBasket);

            return RestClient.Execute(request);
        }

        private Receipt HandleDbPurchaseResponse(IRestResponse response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.Accepted:
                case HttpStatusCode.OK:
                    return new Receipt("Success", "Successfully processed order", true);
                case HttpStatusCode.BadRequest:
                    return new Receipt("Error", "Bad Request from Server", false);
                case HttpStatusCode.NoContent:
                    return new Receipt("Error","No Content appended to request", false);
                default:
                    return new Receipt("Error", "Unknown Error Occured", false);
            }
        }

        private RestRequest GenerateRequest(Method httpMethod)
        {
            return new RestRequest(httpMethod);
        }
    }

}
