using ADP_SeleniumFramework.resources;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_SeleniumFramework.ADP_PageFactory
{
    public class ADP_AbstractPageFactory : webDriver
    {
        public ADP_AbstractPageFactory()
        {
            PageFactory.InitElements(webDriver.Initialize(browser.GoogleChrome), this);
        }
    }
}
