using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BrowserTest
{
    public class HomePage : BasePage
    {
        private IWebElement leanMoreLink => Driver.FindElement(By.Id("learnmorelink"));
        private IWebElement somethingText => Driver.FindElement(By.Id("something"));
        private IWebElement homePageTitle => Driver.FindElement(By.TagName("h1"));
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        public void EnterSomething(string val)
        {
            somethingText.SendKeys(val);
        }
        public void ClickLearnMore()
        {
            leanMoreLink.Click();
        }

        public string GetPageTitle()
        {
            return homePageTitle.Text;
        }

        public override string GetCurrentUrl()
        {
            return "/home";
        }
    }
}
