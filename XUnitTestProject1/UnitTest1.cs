using NUnit.Framework;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Pages;

namespace XUnitTestProject1
{
    [TestFixture]
    public class XUnitTestProject1
    {

        [Test]
        public void Test1()
        {
            using (IWebDriver driver = new ChromeDriver(@"D:\"))
            {
                var google = new Google(driver);
                google.NavigateToGoogle();
                google.SearchText("hdrezka");
                Thread.Sleep(2000);
                ResultPage result = google.Click();
                HDrezka hdrezka = result.Click();
                hdrezka.SearchText("Люцифер");
                Thread.Sleep(2000);
                Lucifer lucifer = hdrezka.Click();
                Thread.Sleep(2000);
                LuciferMovie luciferMovie = lucifer.Click();
                Thread.Sleep(2000);
                Assert.True(luciferMovie.isResultPresent());
            }
        }
    }
}
