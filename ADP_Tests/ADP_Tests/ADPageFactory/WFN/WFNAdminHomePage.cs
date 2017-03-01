using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.WFN
{
    public class WfnAdminHomePage: AdpAbstractPageFactory
    {
        private readonly By _title = By.XPath("//i[@class = 'icon-adp']");

        [FindsBy(How = How.Id, Using = "adpClient_navItem_label")]
        private IWebElement _clientLink;

        [FindsBy(How = How.XPath, Using = "//span[.= 'Client List']")]
        private IWebElement _clientListLink;

        [FindsBy(How = How.Id, Using = "wfnClientGrid_toolbar_add")]
        private IWebElement _addLink;




        public WfnAdminHomePage() : base()
        {
            WaitVisibleElement(_title);
            Logger.screenshot_PASS("Successfully accessed WFN Admin Home Page");
        }

        public void NavigateToClientCreation()
        {
            Click(_clientLink);
            Click(_clientListLink);
            Click(_addLink);           
        }
    }
}
