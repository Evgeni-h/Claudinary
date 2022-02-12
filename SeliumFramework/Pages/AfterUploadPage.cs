using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    public class AfterUploadPage
    {
        public enum RightClickMenu
        {
            Manage,
            Edit,
            Delete
        }
        public static void RightClickOnAddedImage(RightClickMenu rightClickMenu)
        {
            Helper.MouseRightClick(Helper.SelectorType.CssSelector, ".fs-exclude.modules-MediaLibrary-AssetLoader-AssetLoader__assetImage--2ol77");
                        
            switch (rightClickMenu)
            {
                case RightClickMenu.Manage:
                    var manageElement = Driver.Instance.FindElements(By.CssSelector(".ItemLayout__OnelinerWrapper-kMPbCM.caVALX")).First();
                    manageElement.Click();
                    break;
                case RightClickMenu.Edit:
                    break;
                case RightClickMenu.Delete:
                    var deleteElement = Driver.Instance.FindElements(By.CssSelector(".ItemLayout__OnelinerWrapper-kMPbCM.caVALX")).Last();
                    deleteElement.Click();
                    var popupDltbtn = Driver.Instance.FindElement(By.XPath("/html/body/div[5]/div/div/div/div/div[3]/button[1]"));
                    popupDltbtn.Click();
                    Thread.Sleep(1000);
                    break;
                default:
                    break;
            }
            
        }
    }
}
