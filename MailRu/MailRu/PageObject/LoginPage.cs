﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MailRu
{
    /// <summary>
    /// This class is mail login page.
    /// </summary>
    public class LoginPage:PageObject
    {
        IWebElement UsernameInput { get; set; }
        IWebElement PasswordInput { get; set; }
        /// <summary>
        /// This is class constructor 
        /// </summary>
        /// <param name="webDriver"></param>
        /// <exception cref="InvalidPageException"> This no login page </exception>
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            if (!webDriver.Title.Equals("Mail.ru: почта, поиск в интернете, новости, игры"))
            {
                throw new InvalidPageException("This no login page!");
            }
        }
        /// <summary>
        /// Method that types username to username field
        /// </summary>
        /// <param name="username"></param>
        /// <returns>username input </returns>
        public IWebElement TypeUsermame(string username)
        {
            //Wait.Until(t=>WebDriver.FindElement(By.Id("mailbox:login"))).
            //UsernameInput = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.Id("mailbox:login")));
           // UsernameInput.SendKeys(username + Keys.Enter);
            return UsernameInput;
        }
        /// <summary>
        /// Method that types username to username field
        /// </summary>
        /// <param name="password"></param>
        /// <returns> password input </returns>
        public IWebElement TypePassword(string password)
        {
            PasswordInput = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));
            PasswordInput.SendKeys(password + Keys.Enter);
            return PasswordInput;
        }
        /// <summary>
        /// This method login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns> new InboxPage object </returns>
        public InboxPage LoginAs(string username, string password)
        {
            TypeUsermame(username);
            TypePassword(password);
            return new InboxPage(WebDriver);
        }
    }
}
