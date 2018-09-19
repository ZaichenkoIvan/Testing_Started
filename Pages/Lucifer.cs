using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class Lucifer
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        private IWebElement btn
        {
            get { return this.driver.FindElement(By.XPath("//a[@href='http://hdrezka.ag/series/fantasy/11428-lyucifer-2016.html']")); }
        }


        public Lucifer(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public LuciferMovie Click()
        {
            this.btn.Click();
            return new LuciferMovie(this.driver);
        }
    }
}
