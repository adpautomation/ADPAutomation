using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADP_PageFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.WFN.Setup.Security.AccessPermissions
{
    public class UserAccessPermissions: AdpAbstractPageFactory
    {
        private readonly By _title = By.XPath("//span[.='User Access Permissions']");

        private readonly By _title2 = By.Id("userName");

        [FindsBy(How = How.Id, Using = "role")]
        private IWebElement _roleField;

        [FindsBy(How = How.Id, Using = "tableGridSearchButton")]
        private IWebElement _filterButton;

        [FindsBy(How = How.XPath, Using = "//span[.='ractitioner, p']")]
        private IWebElement _practitioner;

        public UserAccessPermissions() : base()
        {
            WaitVisibleElement(_title);
        }

        public void GetAccessForPractitioner()
        {
            Click(_roleField);
            _roleField.SendKeys("Practitioner");
            Click(_filterButton);
            Click(_practitioner);
            WaitVisibleElement(_title2);

        }
    }
}
