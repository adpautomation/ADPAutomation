using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_SeleniumFramework.ADP_PageFactory.CAT
{
    class CAT_Summary: ADP_AbstractPageFactory
    {
        private By title = By.Id("adp-current-breadcrumb-Summary");

        [FindsBy(How = How.XPath, Using = "//label[.='Market:']")]
        private IWebElement Market_text;


        public CAT_Summary() : base()
        {
            waitVisibleElement(title);
        }
    }
}
