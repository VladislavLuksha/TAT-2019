using OpenQA.Selenium;

namespace MailRu
{
    /// <summary>
    /// This abstract class is page object
    /// </summary>
    public abstract class PageObject
    {
        protected  IWebDriver webDriver;

        public PageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}
