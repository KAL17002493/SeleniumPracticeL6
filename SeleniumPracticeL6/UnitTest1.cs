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
            driver = new ChromeDriver(@"H:\L6\SeleniumPracticeL6\SeleniumPracticeL6");
        }

        [Test]
        public void CheckAddition()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://www.google.com");
            
            //Act


            //Assert


        }
    }
}