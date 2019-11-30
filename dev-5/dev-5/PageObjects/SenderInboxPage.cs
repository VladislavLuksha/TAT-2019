using System;
using OpenQA.Selenium;

namespace dev_5
{
    /// <summary>
    /// This is sender inbox page class
    /// </summary>
    public class SenderInboxPage:PageObject
    {
        By userNameLocator = By.CssSelector("span[title='Vladislav Luksha <luksha.vladislav@mail.ru>']");
        By writeLetterLocator = By.CssSelector("span.compose-button__wrapper");
        By senderSelectLocator = By.CssSelector("label.container--zU301");
        By themeLocator = By.CssSelector("input[name='Subject']");
   
        IWebElement Username { get; set; }

        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="webDriver"></param>
        public SenderInboxPage(IWebDriver webDriver) : base(webDriver) { }

        /// <summary>
        /// This method writes messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="theme"></param>
        /// <param name="message"></param>
        public void WriteLetter(string sender,string theme,string message)
        {
            NavigateOnButton(writeLetterLocator);
            DataInput(sender, senderSelectLocator);
            DataInput(theme, themeLocator);
            DataInput(message,writeMessageLocator);
            NavigateOnButton(submitLocator);   
        }
        /// <summary>
        /// This method checks received messages
        /// </summary>
        /// <returns> true or false </returns>
        public bool CheckReceivedMessage()
        {
            Username = FindElement(userNameLocator);
            return (Username!=null);
        }
    }
}
