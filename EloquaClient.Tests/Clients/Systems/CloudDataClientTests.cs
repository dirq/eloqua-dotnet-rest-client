﻿using Eloqua.Api.Rest.ClientLibrary.Models.Systems.Cloud;
using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Systems
{
    [TestFixture]
    public class CloudDataClientTests
    {
        private Client _client;

        [OneTimeSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void GetCloudDataTest()
        {
            var clouddata = new CloudDataInstance()
                                {
                                    Name = "sample",
                                    ProviderURL = "www.test.com",
                                    IconURL = "test",
                                    Description = "test"
                                };

            var result = _client.Systems.CloudData.Post(clouddata);
            var t = result;

        }
    }
}
