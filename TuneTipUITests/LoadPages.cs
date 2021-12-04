using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assert = Xunit.Assert;
using System.Threading;

namespace TuneTipUITests
{
    public class LoadPages
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationHomePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/");
                Thread.Sleep(3000);
                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Home Page", pageTitle);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationLoginPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/login");
                Thread.Sleep(3000);
                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Log In", pageTitle);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationAccountPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/account");
                Thread.Sleep(3000);
                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Account", pageTitle);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationSupportPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/support");
                Thread.Sleep(3000);
                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Support", pageTitle);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationAboutPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/about");
                Thread.Sleep(3000);
                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - About", pageTitle);
            }
        }
        
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationRecommendationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/recommendations");
                Thread.Sleep(3000);
                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Recommendations", pageTitle);
            }
        }
    }
}
