using ADP_SeleniumFramework.resources;
using ADP_Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_SeleniumFramework.ADP_PageFactory.VOE
{
   public class VOE_Search: ADP_AbstractPageFactory
    {
        private By title = By.Id("adp-breadcrumb-VOE");

        [FindsBy(How = How.Id, Using = "inputEmplID")]
        private IWebElement searchField;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='vm.verifyID()']")]
        private IWebElement verifyID_button;

        public VOE_Search() : base()
        {
            waitVisibleElement(title);
        }

        public void search_ID()
        {
            searchField.SendKeys(SmokeTestWindow.validEmployeeID);
            Logger.screenshot_PASS("Using" + " " + "<b>" + SmokeTestWindow.validEmployeeID + "</b>" + " " + "as Employment ID");
            click(verifyID_button);
        }
    }
}
