using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MailRu
{
    /// <summary>
    /// This class is entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                IWebDriver webDriver = new ChromeDriver();
                MailRu mailRu = new MailRu(webDriver);
                mailRu.LoginAs("vladivanoval@mail.ru", "zxcvbnm,./12345asdfghjkl;'");
                Console.WriteLine($"Number of messages= { mailRu.GetUnreadMessages()}");
                mailRu.ReadUnreadMessages();
                Console.WriteLine($"Number of messages= { mailRu.GetUnreadMessages()}");
                webDriver.Quit();
            }
            catch(Exception exeption)
            {
                Console.WriteLine(exeption.Message); 
            }
        }
    }
}
