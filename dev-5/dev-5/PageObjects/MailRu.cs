using OpenQA.Selenium;

namespace dev_5
{  
    /// <summary>
    /// This is MailRu class
    /// </summary>
    public class MailRu:PageObject
    {
        By usernameLocator = By.Id("mailbox:login");
        By passwordLocator = By.Id("mailbox:password");
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
        SenderInboxPage SenderPage { get; set; }
        RecipientInboxPage RecipientPage { get; set; }
        /// <summary>
        /// This is class constructor
        /// </summary>
        /// <param name="webDriver"></param>
        /// <exception cref="InvalidPageException"> This no login page </exception>
        public MailRu(IWebDriver webDriver):base(webDriver)
        {
            WebDriver.Manage().Window.Maximize();
            this.WebDriver.Url = "https://mail.ru/";
            if (!WebDriver.Title.Equals("Mail.ru: почта, поиск в интернете, новости, игры"))
            {
                throw new InvalidPageException("This no login page!");
            }
        }
        /// <summary>
        /// This method defines determines type username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>UsernameInput</returns>
        private IWebElement TypeUsermame(string username)
        {
            UsernameInput = FindElement(usernameLocator);
            UsernameInput.Clear();
            UsernameInput.SendKeys(username + Keys.Enter);
            return UsernameInput;
        }
        /// <summary>
        /// This method defines determines type password
        /// </summary>
        /// <param name="password"></param>
        /// <returns>passwordInput</returns>
        private IWebElement TypePassword(string password)
        {
            PasswordInput = FindElement(passwordLocator);
            PasswordInput.Click();
            PasswordInput.SendKeys(password + Keys.Enter);
            return PasswordInput;
        }
        /// <summary>
        /// This is method logs on sender page
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns> SenderPage </returns>
        public SenderInboxPage LoginOnSenderPage(string username,string password)
        {
            TypeUsermame(username);
            TypePassword(password);
            SenderPage = new SenderInboxPage(WebDriver);
            return SenderPage;
        }
        /// <summary>
        /// This is method logs on recipient page
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public RecipientInboxPage LoginOnRecipientPage(string username,string password)
        {
            TypeUsermame(username);
            TypePassword(password);
            RecipientPage = new RecipientInboxPage(WebDriver);
            return RecipientPage;
        }
        
        public void WriteLetterTheSender(string sender,string theme,string message)
        {
            SenderPage.WriteLetter(sender, theme, message);
        }
        
        public void OutOfSenderPage()
        {
            SenderPage.OutOfEmail();
        }
        
        public void ReadMessage()
        {
            RecipientPage.ReadMessage();
        }
        
        public void AnswerOnMessage(string message)
        {
            RecipientPage.AnswerOnMessage(message);
        }
        
        public void OutOfRecipientPage()
        {
            RecipientPage.OutOfEmail();
        }
        
        public bool CheckMessageOnSenderPage()
        {
            return SenderPage.CheckReceivedMessage();
        }
    }
}
