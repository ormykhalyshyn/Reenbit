using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chat.Web.Hubs;
using System.Threading.Tasks;
using System.Net;
using System;
using System.IO;
using Chat.Web.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Microsoft.AspNetCore.SignalR;
using Moq;

namespace TestChat
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConnection()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://chatweb20211009215208.azurewebsites.net");
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
