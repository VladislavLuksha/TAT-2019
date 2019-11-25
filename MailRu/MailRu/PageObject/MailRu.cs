using OpenQA.Selenium;

namespace MailRu
{
    /// <summary>
    /// This class is MailRu
    /// </summary>
    public class MailRu:PageObject
    {
        /// <summary>
        /// This is username input
        /// </summary>
        IWebElement UsernameInput { get; set; }
        /// <summary>
        /// This is password input
        /// </summary>
        IWebElement PasswordInput { get; set; }
        /// <summary>
        /// This is inbox page
        /// </summary>
        InboxPage InboxPage { get; set; }
        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="webDriver"></param>
        /// <exception cref="InvalidPageException"> This no login page </exception>
        public MailRu(IWebDriver webDriver):base(webDriver)
        {
            webDriver.Manage().Window.Maximize();
            this.WebDriver.Url = "https://mail.ru/";
            if (!webDriver.Title.Equals("Mail.ru: почта, поиск в интернете, новости, игры"))
            {
                throw new InvalidPageException("This no login page!");
            }
        }
        private IWebElement TypeUsermame(string username)
        {
            Wait.Until(t => WebDriver.FindElement(By.Id("mailbox:login")));
            UsernameInput = WebDriver.FindElement(By.Id("mailbox:login"));
            UsernameInput.SendKeys(username + Keys.Enter);
            return UsernameInput;
        }
        private IWebElement TypePassword(string password)
        {
            Wait.Until(t => WebDriver.FindElement(By.Id("mailbox:password")).Displayed);
            PasswordInput = WebDriver.FindElement(By.Id("mailbox:password"));
            PasswordInput.Click();
            PasswordInput.SendKeys(password + Keys.Enter);
            return PasswordInput;
        }
        /// <summary>
        /// This method login.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>  InboxPage object </returns>
        public InboxPage LoginAs(string username, string password)
        {
            TypeUsermame(username);
            TypePassword(password);
            InboxPage = new InboxPage(WebDriver);
            return InboxPage;
        }
        /// <summary>
        /// This method gets unread messages
        /// </summary>
        /// <returns> return number unread messages </returns>
        public string GetUnreadMessages()
        {
            return InboxPage.GetUnreadMessagesCount();
        }
        /// <summary>
        /// This method reads unread messages
        /// </summary>
        public void ReadUnreadMessages()
        {
            InboxPage.ReadUnreadMessages();
        }
    }
}
