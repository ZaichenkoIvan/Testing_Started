using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class LuciferMovie
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LuciferMovie(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public Boolean isResultPresent()
        {
            try
            {
                var result = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@href='http://hdrezka.ag/collections/407-serialy-po-komiksam-dc-comics/']")));
                return result != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
