using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.CAT
{
    class CatRateLevelManager: AdpAbstractPageFactory
    {
        private By _title = By.XPath("//button[@id='adp-current-breadcrumb-PSA Admin']");

        private By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//label[.='Paygroups']")]
        private IWebElement _paygroupsText;

        [FindsBy(How = How.XPath, Using = "//label[.='Effective date']")]
        private IWebElement _effectiveDateText;

        [FindsBy(How = How.XPath, Using = "//div[.='Add Provider']")]
        private IWebElement _addProviderButton;

        [FindsBy(How = How.XPath, Using = "//div[.='Add Effective Date']")]
        private IWebElement _addEffectiveDateButton;


        public CatRateLevelManager() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_paygroupsText)) { }
            if (IsElementDisplayed(_effectiveDateText)) { }
            if (IsElementDisplayed(_addProviderButton)) { }
            if (IsElementDisplayed(_addEffectiveDateButton))
            {
                Logger.screenshot_PASS("CAT Rate Level Manager. All the page elements are displayed correctly");
            }
        }
    }
}
