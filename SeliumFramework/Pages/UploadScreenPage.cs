using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    public enum UpperTabs
    {
        MyFiles,
        WebAddress,
        ImageSearch
    }
    public class UploadScreenPage
    {
        public static void UpperMenu(UpperTabs item)
        {
            Driver.SwitchToFrame(Helper.SelectorType.XPath, "/html/body/iframe[2]");
            switch (item)
            {
                case UpperTabs.MyFiles:
                    var myFiles = Driver.Instance.FindElement(By.CssSelector(".TopMenuItem__ItemButton-bKlfLg.bXmGMq.bc-link.c-tab-icon.fill-tab-icon"));
                    myFiles.Click();
                    break;
                case UpperTabs.WebAddress:
                    break;
                case UpperTabs.ImageSearch:
                    break;
                default:
                    break;
            }
        }

        public static void UploadImageFromPC(string path)
        {
            Driver.Instance.FindElement(By.CssSelector(".cloudinary_fileupload")).SendKeys(path);
            Thread.Sleep(3000);
            Driver.SwitchToDefaultFrame();
        }

        public class Advanced
        {
            public static void PublicId(string publicIdName)
            {
                var advanced = Driver.Instance.FindElement(By.CssSelector(".btn-advance.c-link.ml2"));
                advanced.Click();
                var publicIdField = Driver.Instance.FindElement(By.XPath("//*[@id='app-root']/div/div/div[2]" +
                    "/div/footer/div[1]/div[2]/div/div[1]/input"));
                publicIdField.SendKeys(publicIdName);
            }
        }
    }
}
