using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace MailRu
{
    /// <summary>
    /// This class is inbox page
    /// </summary>
    public class InboxPage:PageObject
    {
        IWebElement unreadMessagesCount;

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
            unreadMessagesCount = webDriver.FindElement(By.ClassName("badge__text"));
            return unreadMessagesCount.Text;
        }
    }
}
