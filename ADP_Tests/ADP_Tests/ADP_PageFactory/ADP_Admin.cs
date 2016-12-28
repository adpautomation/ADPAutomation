using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_SeleniumFramework.resources;
using ADP_Tests;

namespace ADP_SeleniumFramework.ADP_PageFactory
{
    public class ADP_Admin: ADP_AbstractPageFactory
    {
        
        private By title = By.Id("adp-current-breadcrumb-Manage Users");

        [FindsBy(How = How.XPath, Using = "//input[@ng-model='manageUsers.config.name']")]
        private IWebElement inputField;

        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons ng-scope']")]
        private IWebElement searchIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Impersonate User']")]
        private IWebElement impersonateButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Yes']")]
        private IWebElement impersonateButton_YES;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='No']")]
        private IWebElement impersonateButton_NO;


        public ADP_Admin() : base()
        {
            waitVisibleElement(title);
        }

        public void ImpersonateUser()
        {
            inputField.SendKeys(SmokeTestWindow.impersonatedUser);
            click(searchIcon);
            click(impersonateButton);
            Logger.screenshot_PASS("Trying to impersonate" + " " + "<b>" + SmokeTestWindow.impersonatedUser + "</b>");
            click(impersonateButton_YES);
        }
    }
}
