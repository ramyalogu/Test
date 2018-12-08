using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using FileSystem;

namespace ApiTest
{
    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        [TestCategory("Smoke")]
        public async Task GetAllValues()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(@"http://localhost:33319/");

            var response = (await client.GetAsync("api/values/0")).Content;
            var content = (await response.ReadAsStringAsync());
            GlobalWriter.WriteFile(content);
            var writer = new FileSystemWriter();
            writer.WriteToFile(content);
            Assert.AreEqual("ramya", content);
        }
    }
}
