using OpenQA.Selenium;

namespace dev_5
{
    /// <summary>
    /// This is recipient inbox page class
    /// </summary>
    public class RecipientInboxPage:PageObject
    {
        By messageLocator = By.CssSelector("div[class='llc__content']");
        By answerLocator = By.CssSelector("span[title ='Ответить']");
      
        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="webDriver"></param>
        public RecipientInboxPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// This is method reads message
        /// </summary>
        public void ReadMessage()
        {
            NavigateOnButton(messageLocator);
        }
        /// <summary>
        /// This is method answers on messages
        /// </summary>
        /// <param name="message"></param>
        public  void AnswerOnMessage(string message)
        {
            NavigateOnButton(answerLocator);
            DataInput(message, writeMessageLocator);
            NavigateOnButton(submitLocator);
        }

    }
}
