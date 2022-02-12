using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            Instance.Manage().Window.Maximize();
        }

        internal static void SwitchToFrame(Helper.SelectorType selectorType, string selectorString)
        {
            switch (selectorType)
            {
                case Helper.SelectorType.Id:
                    break;
                case Helper.SelectorType.Name:
                    break;
                case Helper.SelectorType.CssSelector:
                    break;
                case Helper.SelectorType.ClassName:
                    break;
                case Helper.SelectorType.LinkText:
                    break;
                case Helper.SelectorType.XPath:
                    Driver.Instance.SwitchTo().Frame(Driver.Instance.FindElement(By.XPath(selectorString)));
                    break;
                case Helper.SelectorType.TagName:
                    break;
                case Helper.SelectorType.PartialLinkText:
                    break;
                default:
                    break;
            }
        }

        internal static void SwitchToDefaultFrame()
        {
            Driver.Instance.SwitchTo().DefaultContent();
        }

        public static void GoBack()
        {
            Driver.Instance.Navigate().Back();
        }
        public static void Close()
        {
            Instance.Quit();
        }
    }
}
