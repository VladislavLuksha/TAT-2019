using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System; 

namespace dev_5
{
    /// <summary>
    /// This is abstract page object class
    /// </summary>
    abstract public class PageObject
    {
        protected By exitLocator = By.CssSelector("a[title ='выход']");
        protected By emailLocator = By.CssSelector("a[class='x-ph__link x-ph__link_first']");
        protected By submitLocator = By.CssSelector("span[title ='Отправить']");
        protected By writeMessageLocator = By.XPath("/html/body/div[15]/div[2]/div/div[1]/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div[1]/div[1]");

        protected IWebDriver WebDriver { get; set; }
        protected WebDriverWait Wait { get; set; }
        protected IWebElement NavigationButton { get; set; }
        protected IWebElement ElementButton { get; set; }
        /// <summary>
        /// This is class constructor
        /// </summary>
        /// <param name="webDriver"></param>
        public PageObject(IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
            Wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
        }
        /// <summary>
        /// This method leads on button
        /// </summary>
        /// <param name="locator"></param>
        public void NavigateOnButton(By locator)
        {
            try
            {
                Wait.Until(t => WebDriver.FindElement(locator).Displayed);
                NavigationButton = WebDriver.FindElement(locator);
                NavigationButton.Click();
            }
            catch(UnhandledAlertException)
            {

            }
        }
        /// <summary>
        /// This method leaves the email
        /// </summary>
        public void OutOfEmail()
        {
            NavigateOnButton(exitLocator);
            NavigateOnButton(emailLocator);
        }
        /// <summary>
        /// This method searches for elements
        /// </summary>
        /// <param name="locator"></param>
        /// <returns>ElementButton</returns>
        public IWebElement FindElement(By locator)
        {
            Wait.Until(t => WebDriver.FindElement(locator).Displayed);
            ElementButton = WebDriver.FindElement(locator);
            return ElementButton;
        }
        /// <summary>
        /// This method enters data
        /// </summary>
        /// <param name="text"></param>
        /// <param name="locator"></param>
        /// <returns>ElementButton</returns>
        public  IWebElement DataInput(string text, By locator)
        {
            ElementButton = FindElement(locator);
            ElementButton.Click();
            ElementButton.SendKeys(text + Keys.Enter);
            return ElementButton;
        }
    }
}
