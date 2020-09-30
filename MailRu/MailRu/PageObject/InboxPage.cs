using OpenQA.Selenium;

namespace MailRu
{
    /// <summary>
    /// This class is inbox page
    /// </summary>
    public class InboxPage:PageObject
    {
        /// <summary>
        /// This is unread messages count
        /// </summary>
        IWebElement UnreadMessagesCount { get; set; }
        /// <summary>
        /// This is message locator
        /// </summary>
        IWebElement MessageLocator { get; set; }
        /// <summary>
        /// This is class constructor
        /// </summary>
        /// <param name="webDriver"></param>
        public InboxPage(IWebDriver webDriver) : base(webDriver)
        {
            //if (!webDriver.Equals("(3) Входящие - Почта Mail.ru"))
            //{
            //    throw new InvalidPageException("This no inbox page");
            //}
        }
        /// <summary>
        /// This method get unread messages count
        /// </summary>
        /// <returns>unread messages count </returns>
        public string GetUnreadMessagesCount()
        {
            try
            {
                Wait.Until(t => WebDriver.FindElement(By.CssSelector("span.badge__text")).Displayed);
                UnreadMessagesCount = WebDriver.FindElement(By.CssSelector("span.badge__text"));
                return UnreadMessagesCount.Text;
            }
            catch(NoSuchElementException)
            {
                return 0.ToString();
            }
        }
        /// <summary>
        /// This method reads unread message.
        /// </summary>
        public void ReadUnreadMessages()
        {
            Wait.Until(t => WebDriver.FindElement(By.CssSelector("span.ll-rs")).Displayed);
            MessageLocator = WebDriver.FindElement(By.CssSelector("span.ll-rs"));
            MessageLocator.Click();
        }
    }
}
