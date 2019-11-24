using OpenQA.Selenium;

namespace MailRu
{
    /// <summary>
    /// This class is MailRu
    /// </summary>
    public class MailRu
    {
        IWebDriver webDriver;
        InboxPage inboxPage;
        LoginPage loginPage;
        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="webDriver"></param>
        public MailRu(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            webDriver.Manage().Window.Maximize();
            this.webDriver.Url = "https://mail.ru/";
            loginPage = new LoginPage(this.webDriver);
        }

        public InboxPage LoginAs(string username, string password)
        {
            inboxPage = loginPage.LoginAs(username, password);
            return inboxPage;
        }

        public string GetUnreadMessages()
        {
           return inboxPage.GetUnreadMessagesCount();
        }
 
    }
}
