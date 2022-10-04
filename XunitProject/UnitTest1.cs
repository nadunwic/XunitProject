using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XunitProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string URL = "https://stackoverflow.com/";
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);

            IWebElement signinbtn = driver.FindElement(By.XPath("//a[text()='Log in']"));
            signinbtn.Click();

            driver.Close();

        }
    }
}