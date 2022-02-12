using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace SeleniumFramework
{
    public class CloudinaryLoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://staging.cloudinary.com/users/login");
        }

        public static void Login(string userName, string password)
        {
            var userInput = Driver.Instance.FindElement(By.Id("user_session_email"));
            userInput.SendKeys(userName);        
            var passInput = Driver.Instance.FindElement(By.Id("user_session_password"));
            passInput.SendKeys(password); 
            var signInbtn = Driver.Instance.FindElement(By.Id("sign-in"));
            signInbtn.Click();
        }
    }
}
