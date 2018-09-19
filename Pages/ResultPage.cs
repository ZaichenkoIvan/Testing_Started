using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class ResultPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement btn
        {
            get { return this.driver.FindElement(By.XPath("//a[@href='http://hdrezka.ag/series/']")); }
        }

        public HDrezka Click()
        {
            this.btn.Click();
            return new HDrezka(this.driver);
        }
    }
}
