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
    public class HDrezka
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        private IWebElement search
        {
            get { return this.driver.FindElement(By.Name("q")); }
        }

        private IWebElement btn
        {
            get { return this.driver.FindElement(By.XPath("//*[@title='Начать поиск']")); }
        }

        public HDrezka(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void SearchText(string txt)
        {
            search.Clear();
            search.SendKeys(txt);
        }

        public Lucifer Click()
        {
            this.btn.Click();
            return new Lucifer(this.driver);
        }
    }
}
