using System.Collections.Generic;
using System.Net;
using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestSharp;
using StoreProject.models;
using StoreProject.models.Basket;
using StoreProject.models.HttpClient;

namespace StoreProject.Tests
{
    [TestClass]
    public class ClientTests
    {
        private Mock<IRestClient> _mockRestClient;
        private RestResponse _restResponse;

        [TestInitialize]
        public void TestInitialize()
        {
            _restResponse = new RestResponse();
            _mockRestClient = new Mock<IRestClient>();
        }

        [TestMethod]
        public void Happy_Path()
        {
            _restResponse.StatusCode = HttpStatusCode.OK;
            _mockRestClient.Setup(ob => ob.Execute(It.IsAny<RestRequest>())).Returns(_restResponse);

            var client = new Client(_mockRestClient.Object);
            var result = client.ProcessPurchaseRequest(new Basket(1, 1, new List<IProduct>()));

            using (new AssertionScope())
            {
                result.Item2.Success.Should().NotBeNull();
                result.Item2.Error.Should().BeNull();
                result.Item2.Success.Should().Be("Successfully processed order");
            }
            
        }
    }
}
