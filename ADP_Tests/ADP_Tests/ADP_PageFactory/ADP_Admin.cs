using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_SeleniumFramework.resources;

namespace ADP_SeleniumFramework.ADP_PageFactory
{
    public class ADP_Admin: ADP_AbstractPageFactory
    {
        [FindsBy(How = How.Id, Using = "adp-current-breadcrumb-Manage Users")]
        private IWebElement manageUsersTitle;

        [FindsBy(How = How.XPath, Using = "//input[@ng-model='manageUsers.config.name']")]
        private IWebElement inputField;

        [FindsBy(How = How.XPath, Using = "//i[@class='material-icons ng-scope']")]
        private IWebElement searchIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Impersonate User']")]
        private IWebElement impersonateButton;

        [FindsBy(How = How.Id, Using = "//button[@aria-label='Yes']")]
        private IWebElement impersonateButton_YES;

        [FindsBy(How = How.Id, Using = "//button[@aria-label='No']")]
        private IWebElement impersonateButton_NO;


        public ADP_Admin() : base()
        {
            waitVisibleText(manageUsersTitle, "Manage Users");
        }

        public void ImpersonateUser()
        {
            inputField.SendKeys("Felipe Adams");
            Logger.screenshot_PASS("Trying to impersonate Felipe Adams");
            click(searchIcon);
            click(impersonateButton);
            click(impersonateButton_YES);
        }
    }
}
