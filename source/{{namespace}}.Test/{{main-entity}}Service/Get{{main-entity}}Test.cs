using System;
using System.Threading.Tasks;
using Celerik.NetCore.Services;
using Celerik.NetCore.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using {{namespace}}.Model;
using {{namespace}}.Services;

namespace {{namespace}}.Test
{
    [TestClass]
    public class Get{{main-entity}}Test : {{main-entity}}BaseTest
    {
        [TestMethod]
        public async Task NullPayload()
        {
            var {{camel-main-entity}}Svc = GetService<I{{main-entity}}Service>();
            var payload = (Get{{main-entity}}Payload)null;
            var response = await {{camel-main-entity}}Svc.Get{{main-entity}}Async(payload);

            Assert.AreEqual(null, response.Data);
            Assert.AreEqual(false, response.Success);
            Assert.AreNotEqual(null, response.Message);
            Assert.AreEqual(ApiMessageType.Error, response.MessageType);
            Assert.AreEqual(Get{{main-entity}}Status.BadRequest, response.StatusCode);
            
        }

        [TestMethod]
        public async Task Null{{main-entity}}Id()
        {
            var {{camel-main-entity}}Svc = GetService<I{{main-entity}}Service>();
            var payload = new Get{{main-entity}}Payload { {{main-entity}}Id = null };
            var response = await {{camel-main-entity}}Svc.Get{{main-entity}}Async(payload);

            Assert.AreEqual(null, response.Data);
            Assert.AreEqual(false, response.Success);
            Assert.AreNotEqual(null, response.Message);
            Assert.AreEqual(ApiMessageType.Error, response.MessageType);
            Assert.AreEqual(Get{{main-entity}}Status.{{main-entity}}IdFormat, response.StatusCode);
        }

        [TestMethod]
        public async Task Empty{{main-entity}}Id()
        {
            var {{camel-main-entity}}Svc = GetService<I{{main-entity}}Service>();
            var payload = new Get{{main-entity}}Payload { {{main-entity}}Id = string.Empty };
            var response = await {{camel-main-entity}}Svc.Get{{main-entity}}Async(payload);

            Assert.AreEqual(null, response.Data);
            Assert.AreEqual(false, response.Success);
            Assert.AreNotEqual(null, response.Message);
            Assert.AreEqual(ApiMessageType.Error, response.MessageType);
            Assert.AreEqual(Get{{main-entity}}Status.{{main-entity}}IdFormat, response.StatusCode);
        }

        [TestMethod]
        public async Task Exceed{{main-entity}}IdLength()
        {
            var {{camel-main-entity}}Svc = GetService<I{{main-entity}}Service>();
            var payload = new Get{{main-entity}}Payload { {{main-entity}}Id = new string('x', 51) };
            var response = await {{camel-main-entity}}Svc.Get{{main-entity}}Async(payload);

            Assert.AreEqual(null, response.Data);
            Assert.AreEqual(false, response.Success);
            Assert.AreNotEqual(null, response.Message);
            Assert.AreEqual(ApiMessageType.Error, response.MessageType);
            Assert.AreEqual(Get{{main-entity}}Status.{{main-entity}}IdFormat, response.StatusCode);
        }

        [TestMethod]
        public async Task {{main-entity}}IdDoesntExist()
        {
            var {{camel-main-entity}}Svc = GetService<I{{main-entity}}Service>();
            var payload = new Get{{main-entity}}Payload { {{main-entity}}Id = "71B644F6-EE70-4236-A619-84D33076F468" };
            var response = await {{camel-main-entity}}Svc.Get{{main-entity}}Async(payload);

            Assert.AreEqual(null, response.Data);
            Assert.AreEqual(false, response.Success);
            Assert.AreNotEqual(null, response.Message);
            Assert.AreEqual(ApiMessageType.Error, response.MessageType);
            Assert.AreEqual(Get{{main-entity}}Status.{{main-entity}}IdNotFound, response.StatusCode);
        }

        [TestMethod]
        public async Task Ok()
        {
            var {{camel-main-entity}}Svc = GetService<I{{main-entity}}Service>();
            var payload = new Get{{main-entity}}Payload { {{main-entity}}Id = "680d703d-87b7-4158-98d8-a61b9f3abf2f" };
            var response = await {{camel-main-entity}}Svc.Get{{main-entity}}Async(payload);

            Assert.AreEqual(payload.{{main-entity}}Id, response.Data.{{main-entity}}Id);
            Assert.AreEqual(true, response.Success);
            Assert.AreEqual(Get{{main-entity}}Status.Ok, response.StatusCode);
        }
    }
}
