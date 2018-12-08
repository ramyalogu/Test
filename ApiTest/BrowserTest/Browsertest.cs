using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace BrowserTest
{
    /// <summary>
    /// Summary description for Browsertest
    /// </summary>
    [TestClass]
    public class Browsertest
    {
        public Browsertest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup() { }
        
        #endregion

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:33319/");
        }

        private IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            

            var homepage = new HomePage(driver);
            Assert.AreEqual("ASP.NET", homepage.GetPageTitle());

            homepage.RefreshPage();
            homepage.EnterSomething("Ramya is a stupid girl");
            homepage.ClickLearnMore();
            
            Assert.AreEqual("https://www.asp.net/", driver.Url);
            homepage.GoBack();
            Thread.Sleep(5000);
            Assert.AreEqual("http://localhost:33319/",driver.Url );
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
