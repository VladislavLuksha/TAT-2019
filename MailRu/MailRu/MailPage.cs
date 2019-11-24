using OpenQA.Selenium;

namespace MailRu
{
    public class MailPage : PageObject
    {
        IWebElement loginPageButton;
       // IWebElement inboxPageButton;
        //By inboxPageButtonSelector = By.ClassName("x-ph__link__text");
        public MailPage(IWebDriver webDriver) : base(webDriver)
        {
            if (!webDriver.Title.Equals("Mail.ru: почта, поиск в интернете, новости, игры"))
            {
                throw new InvalidPageException("This no mail page");
            }
        }

        public LoginPage NavigateToLoginPage()
        {
            loginPageButton = webDriver.FindElement(By.ClassName("mailbox:x-ph__link__text"));
            loginPageButton.Click();
            return new LoginPage(webDriver);
        }
        //public InboxPage NavigateToInboxPage()
        //{
        //    inboxPageButton = webDriver.FindElement(inboxPageButtonSelector);
        //    inboxPageButton.Click();
        //    return new InboxPage(webDriver);
        //}
    }
}