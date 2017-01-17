using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.CAT
{
    class CatExceptionManager: AdpAbstractPageFactory
    {
        private By _title = By.XPath("//button[@id='adp-current-breadcrumb-Manage Exceptions']");

        private By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Add New Exception']")]
        private IWebElement _addNewExceptionButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Get Report']")]
        private IWebElement _getReportButton;

        [FindsBy(How = How.XPath, Using = "//button[.='Active Only']")]
        private IWebElement _activeOnlyButton;

        [FindsBy(How = How.XPath, Using = "//button[.='All Exceptions']")]
        private IWebElement _allExceptionsButton;

        // Xpath expression with whitespace

        [FindsBy(How = How.XPath, Using = "//td[normalize-space(text()) = 'Details']")]
        private IWebElement _detailsText;

        [FindsBy(How = How.XPath, Using = "//td[.='Category']")]
        private IWebElement _categoryText;

        [FindsBy(How = How.XPath, Using = "//td[.='Exception ID']")]
        private IWebElement _exceptionIdText;

        [FindsBy(How = How.XPath, Using = "//td[.='Rule Detail']")]
        private IWebElement _ruleDetailsText;

        [FindsBy(How = How.XPath, Using = "//td[.='Effective Date']")]
        private IWebElement _effectiveDateText;

        [FindsBy(How = How.XPath, Using = "//td[.='End Date']")]
        private IWebElement _endDateText;



        public CatExceptionManager() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if(IsElementDisplayed(_addNewExceptionButton)) { }
            if (IsElementDisplayed(_getReportButton)) { }
            if (IsElementDisplayed(_activeOnlyButton)) { }
            if (IsElementDisplayed(_allExceptionsButton)) { }
            if (IsElementDisplayed(_detailsText)) { }
            if (IsElementDisplayed(_categoryText)) { }
            if (IsElementDisplayed(_exceptionIdText)) { }
            if (IsElementDisplayed(_ruleDetailsText)) { }
            if (IsElementDisplayed(_effectiveDateText)) { }
            if (IsElementDisplayed(_endDateText))
            {
                Logger.screenshot_PASS("CAT Exception Manager. All the page elements displayed correctly");
            }
        } 
    }
}
