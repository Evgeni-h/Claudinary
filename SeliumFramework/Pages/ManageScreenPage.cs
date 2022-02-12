using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    public class ManageScreenPage
    {
        public static string GetPublicId()
        {
            var publicId = Driver.Instance.FindElement(By.CssSelector(".ignoreP2h.w-100.bg-transparent.ba.br2" +
                ".b--white.outline-0.f-md.black.truncate.outline-0" +
                ".components-InputControls-InputStateIndicator-InputStateIndicator__inputStateIndicator--xKz3B"));
            return publicId.GetAttribute("value");
        }
    }
}
