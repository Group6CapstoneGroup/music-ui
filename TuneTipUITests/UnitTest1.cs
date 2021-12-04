using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TuneTipUITests
{
    public class UnitTest1
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
                driver.Navigate().GoToUrl("http://localhost:3000/login");

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

                string pageTitle = driver.Title;

                Assert.Equal("Tune Tip - Recommendations", pageTitle);
            }
        }
    }
}
