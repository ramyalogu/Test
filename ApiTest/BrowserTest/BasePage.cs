using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BrowserTest
{
    public abstract class BasePage
    {
        public IWebDriver Driver;
        
        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }

        public void GoBack()
        {
            Driver.Navigate().Back();
        }

        public virtual string GetCurrentUrl()
        {
            return Driver.Url;
        }
    }
}
