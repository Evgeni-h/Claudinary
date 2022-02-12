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
    public class MediaLibraryPage
    {
        
        public static void UploadButton()
        {
            Thread.Sleep(3500);
            var blueUploadbtn = Driver.Instance.FindElement(
                By.CssSelector(".StyledBaseButton-bPsHXU.BaseButton-bbuSKr" +
                ".Button__StyledButton-iEKVQz.iTnvcR.fpWXfs" +
                ".DesktopUploadButton__StyledSplitButton-sc-1c46mw3-0.cJuVnb" +
                ".upload-button.DesktopUploadButton__StyledSplitButton-sc-1c46mw3-0.cJuVnb.upload-button"));
            blueUploadbtn.Click();
        }
    }
}
