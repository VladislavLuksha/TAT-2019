using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MailRu
{
    /// <summary>
    /// This abstract class is page object
    /// </summary>
    public abstract class PageObject
    {
        protected IWebDriver WebDriver { get; set; }
        protected WebDriverWait Wait { get; private set; }

        /// <summary>
        /// This is class constructor
        /// </summary>
        /// <param name="webDriver"></param>
        public PageObject(IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
            Wait = new WebDriverWait(this.WebDriver, TimeSpan.FromSeconds(40));
        }
    }
}
