using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
            //options.AddArgument("--headless");

            driver = new ChromeDriver(@"H:\L6\SeleniumPracticeL6\SeleniumPracticeL6", options);
        }

        [Test]
        public void CheckPageTitle()
        {
            /*
            //Arrange
            string title = string.Empty;

            //Act
            driver.Navigate().GoToUrl("https://www.next.co.uk/");

            title = driver.Title;

            //Assert
            Assert.AreEqual(title, "Next Official Site: Online Fashion, Kids Clothes & Homeware");
            */

            //Test Case 1
            //Arrange
            string title = string.Empty;

            //Act
            driver.Navigate().GoToUrl("http://automationpractice.com/");

            title = driver.Title;

            //Assert
            

        }

        
        [Test]
        public void CreateAccount()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            IWebElement signIn = driver.FindElement(By.ClassName("login"));
            signIn.Click();

            //Act
            IWebElement email = driver.FindElement(By.Id("email_create"));
            email.SendKeys("NotFake@FakeMail.com");
            email.SendKeys(Keys.Return);

            System.Threading.Thread.Sleep(30000);
            IWebElement fname = driver.FindElement(By.Id("customer_firstname"));
            fname.SendKeys("Bubble");

            IWebElement lname = driver.FindElement(By.Id("customer_lastname"));
            lname.SendKeys("Cloud");

            IWebElement password = driver.FindElement(By.Id("passwd"));
            password.SendKeys("BubbleCloud123!");

            IWebElement days = driver.FindElement(By.Id("days"));
            SelectElement selectDays = new SelectElement(days);
            selectDays.SelectByIndex(1);

            IWebElement years = driver.FindElement(By.Id("years"));
            SelectElement selectYears = new SelectElement(years);
            selectYears.SelectByIndex(2);

            IWebElement months = driver.FindElement(By.Id("months"));
            SelectElement selectMonths = new SelectElement(months);
            selectMonths.SelectByIndex(3);

            IWebElement Address = driver.FindElement(By.Id("address1"));
            Address.SendKeys("RealStreet 69");

            IWebElement City = driver.FindElement(By.Id("city"));
            City.SendKeys("Mars");

            IWebElement state = driver.FindElement(By.Id("id_state"));
            SelectElement selectState = new SelectElement(state);
            selectState.SelectByIndex(3);

            IWebElement ZIP = driver.FindElement(By.Id("postcode"));
            ZIP.SendKeys("00000");

            IWebElement Phone = driver.FindElement(By.Id("phone_mobile"));
            Phone.SendKeys("1234567890");

            IWebElement RegisterButton = driver.FindElement(By.Id("submitAccount"));
            RegisterButton.Click();


            //Assert
        }

        /*
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
        */

        /*[OneTimeTearDown]
        public void Clean()
        {
            driver.Close();
        }*/


    }
}