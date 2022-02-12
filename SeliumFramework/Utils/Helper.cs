using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    class Helper
    {
        public enum SelectorType
        {
           Id,
           Name,
           CssSelector,
           ClassName,
           LinkText,
           XPath,
           TagName,
           PartialLinkText
        }
        internal static void MouseRightClick(SelectorType selectorType, string selectorName)
        {
            Actions action = new Actions(Driver.Instance);
            IWebElement elementRightClick = null;
            switch (selectorType)
            {
                case SelectorType.Id:
                    elementRightClick = Driver.Instance.FindElement(By.Id(selectorName));
                    break;
                case SelectorType.Name:
                    elementRightClick = Driver.Instance.FindElement(By.Name(selectorName));
                    break;
                case SelectorType.CssSelector:
                    elementRightClick = Driver.Instance.FindElements(By.CssSelector(selectorName))
                        .FirstOrDefault();
                    break;
                case SelectorType.ClassName:
                    elementRightClick = Driver.Instance.FindElement(By.ClassName(selectorName));
                    break;
                case SelectorType.LinkText:
                    elementRightClick = Driver.Instance.FindElement(By.LinkText(selectorName));
                    break;
                case SelectorType.XPath:
                    elementRightClick = Driver.Instance.FindElement(By.XPath(selectorName));
                    break;
                case SelectorType.TagName:
                    elementRightClick = Driver.Instance.FindElement(By.TagName(selectorName));
                    break;
                case SelectorType.PartialLinkText:
                    elementRightClick = Driver.Instance.FindElement(By.PartialLinkText(selectorName));
                    break;
                default:
                    break;
            }

            if (elementRightClick != null)
            {
                action.ContextClick(elementRightClick).Perform();
            }
            else
            {
                throw new NoSuchElementException();
            }
            
           
            
        }
    }
}
