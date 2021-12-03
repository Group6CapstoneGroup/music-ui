using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MusicRecommendation.UITests
{
    public class MusicRecommendationWebAppShould
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationHomePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/");

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
                driver.Navigate().GoToUrl("http://localhost:3000/");

                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Home Page", pageTitle);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationAccountPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/");

                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Home Page", pageTitle);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationSupportPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/");

                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Home Page", pageTitle);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationAboutPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/");

                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Home Page", pageTitle);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationRecommendationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:3000/");

                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Home Page", pageTitle);
            }
        }
    }
}
