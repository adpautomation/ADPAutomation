using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory_TotalSolutions
{
    public class AdpAdmin: AdpAbstractPageFactory
    {
        
        private By _title = By.Id("adp-current-breadcrumb-Manage Users");

        [FindsBy(How = How.XPath, Using = "//input[@ng-model='manageUsers.config.name']")]
        private IWebElement _inputField;

        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons ng-scope']")]
        private IWebElement _searchIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Impersonate User']")]
        private IWebElement _impersonateButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Yes']")]
        private IWebElement _impersonateButtonYes;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='No']")]
        private IWebElement _impersonateButtonNo;


        public AdpAdmin() : base()
        {
            WaitVisibleElement(_title);
        }

        public void ImpersonateUser()
        {
            _inputField.SendKeys(TestCredentialsWindow.ImpersonatedUser);
            Click(_searchIcon);
            Click(_impersonateButton);
            Logger.screenshot_PASS("Trying to impersonate" + " " + "<b>" + TestCredentialsWindow.ImpersonatedUser + "</b>");
            Click(_impersonateButtonYes);
        }
    }
}
