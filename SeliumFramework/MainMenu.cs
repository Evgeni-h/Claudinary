using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    public class MainMenu
    {
        public class MediaLibraryTab
        {
            public static void Select()
            {
                var mediaLibraryTab = Driver.Instance.FindElement(By.CssSelector(".ModuleNavigationLinkstyled__StyledNavLink-sc-1cquk99-1.gsSnVV.module-link.module-link.media"));
                mediaLibraryTab.Click();
            }
        }
    }
}
