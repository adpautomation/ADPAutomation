using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADPageFactory.WFN.Setup.Security.AccessPermissions;
using ADP_Tests.ADP_PageFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.WFN
{
    public class WfnHeader: AdpAbstractPageFactory
    {

        private readonly By _firstTimeTitle = By.Id("whatsNewIframe");

        private readonly By _window = By.Id("whatsnewdialog_underlay");

        [FindsBy(How = How.XPath, Using = "//div[@id='whatsnewdialog']//span[@data-dojo-attach-point = 'closeButtonNode']")]
        private IWebElement _closeWindow;

        [FindsBy(How = How.Id, Using = "pracSetup_navItem_label")]
        private IWebElement _setupLink;

        [FindsBy(How = How.XPath, Using = "//span[.='Security']")]
        private IWebElement _securityLink;

        [FindsBy(How = How.XPath, Using = "//span[.='Access Permissions']")]
        private IWebElement _accessPermissionLink;

        [FindsBy(How = How.XPath, Using = "//div[@id='whatsnewdialog']//span[@data-dojo-attach-point = 'closeButtonNode']")]
        private IWebElement _closeWindows;

        public WfnHeader() : base()
        {
//            WaitVisibleElement(_firstTimeTitle);
        }

        public void SetUpAccessPermissions()
        {
            if (IsElementDisplayed(_closeWindow))
            {
                Click(_closeWindow);
                WaitInvisibleElement(_window);
            }
                Click(_setupLink);
                Click(_securityLink);
                Click(_accessPermissionLink);
                var access = new AccessPermissionLobby();
                access.NavigatePayrollPeopleAccess();
                var access2 = new UserAccessPermissions();
                access2.GetAccessForPractitioner();
        }
    }
}
