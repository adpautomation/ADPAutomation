using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.VOE
{
    public class VoeSearch: AdpAbstractPageFactory
    {
        private By _title = By.Id("adp-breadcrumb-VOE");

        [FindsBy(How = How.Id, Using = "inputEmplID")]
        private IWebElement _searchField;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='vm.verifyID()']")]
        private IWebElement _verifyIdButton;

        public VoeSearch() : base()
        {
            WaitVisibleElement(_title);
        }

        public void search_ID()
        {
            _searchField.SendKeys(TestCredentialsWindow.ValidEmployeeId);
            Logger.screenshot_PASS("Using" + " " + "<b>" + TestCredentialsWindow.ValidEmployeeId + "</b>" + " " + "as Employment ID");
            Click(_verifyIdButton);
        }
    }
}
