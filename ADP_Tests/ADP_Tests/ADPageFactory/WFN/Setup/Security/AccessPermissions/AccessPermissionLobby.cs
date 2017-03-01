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
    public class AccessPermissionLobby: AdpAbstractPageFactory
    {
        private readonly By _title = By.XPath("//span[.='Access Permissions']");

        [FindsBy(How = How.XPath, Using = "(//span[@class ='dijit dijitInline dijitReset primaryButton revitButton'])[1]")]
        private IWebElement _menuAccess;

        [FindsBy(How = How.XPath, Using = "//div[@class='revitInlineField']//span[@data-dojo-attach-point='focusNode,titleNode,stateNode']")]
        private IWebElement _payrollPeopleAccess;


        public AccessPermissionLobby() : base()
        {
            WaitVisibleElement(_title);
        }

        public void NavigatePayrollPeopleAccess()
        {
            Click(_payrollPeopleAccess);
        }
    }
}
