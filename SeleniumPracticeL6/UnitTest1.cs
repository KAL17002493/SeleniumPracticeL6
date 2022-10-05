using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumPracticeL6
{
    public class Tests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            //headless makes it so the test is done in the background (browser does not get opened)
            options.AddArgument("--headless");

            driver = new ChromeDriver(@"H:\L6\SeleniumPracticeL6\SeleniumPracticeL6", options);
        }

        [Test]
        public void CheckPageTitle()
        {
            //Arrange
            string title = string.Empty;

            //Act
            driver.Navigate().GoToUrl("https://www.next.co.uk/");

            title = driver.Title;

            //Assert
            Assert.AreEqual(title, "Next Official Site: Online Fashion, Kids Clothes & Homeware");


        }

        [Test]
        public void SearchForShoes()
        {
            //Arrange

            //Act
            driver.Navigate().GoToUrl("https://www.next.co.uk/");
            IWebElement searchBar = driver.FindElement(By.Id("header-big-screen-search-box"));
            searchBar.SendKeys("Shoes");
            searchBar.SendKeys(Keys.Return);

            //Assert
            Assert.IsTrue(driver.Url.Contains(".next.co.uk/search?w=shoes"));
        }

        [OneTimeTearDown]
        public void Clean()
        {
            driver.Close();
        }


    }
}