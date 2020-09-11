using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace dev_5
{
    /// <summary>
    /// This class is entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver();
            MailRu mailRu = new MailRu(webDriver);
            mailRu.LoginOnSenderPage("vladivanoval@mail.ru", "zxcvbnm,./12345asdfghjkl;'");
            mailRu.WriteLetterTheSender("luksha.vladislav@mail.ru", "Helloy", "Vladislav,Helloy");
            mailRu.OutOfSenderPage();
            mailRu.LoginOnRecipientPage("luksha.vladislav@mail.ru", "qwertyuiop[]567890");
            mailRu.ReadMessage();
            mailRu.AnswerOnMessage("Helloy");
            mailRu.OutOfRecipientPage();
            mailRu.LoginOnSenderPage("vladivanoval@mail.ru", "zxcvbnm,./12345asdfghjkl;'");
            Console.WriteLine(mailRu.CheckMessageOnSenderPage()); 
        }
    }
}
