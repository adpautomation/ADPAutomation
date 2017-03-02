using ADP_Tests.ADP_PageFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.ACAWizard
{
    class AcaWizardHomePage: AdpAbstractPageFactory
    {
        private string ValidFEIN = "111111111";

        private readonly By _title = By.XPath("//button[@id='adp-current-breadcrumb-Search']");

        private readonly By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//input[@name='Fein']")]
        private readonly IWebElement _feinField;

        [FindsBy(How = How.XPath, Using = "//span[.='SEARCH']")]
        private readonly IWebElement _searchButton;

        [FindsBy(How = How.XPath, Using = "//md-select[@aria-label='Year']")]
        private readonly IWebElement _yearDropDown;

        [FindsBy(How = How.XPath, Using = "//div[.='2017']")]
        private readonly IWebElement _year2017;

        [FindsBy(How = How.XPath, Using = "//div[.='2016']")]
        private readonly IWebElement _year2016;

        [FindsBy(How = How.XPath, Using = "//div[.='2015']")]
        private readonly IWebElement _year2015;

        [FindsBy(How = How.Id, Using = "aca-select-report-dialog-action-button")]
        private readonly IWebElement _showReportButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Close']")]
        private readonly IWebElement _closeButton;






        public AcaWizardHomePage() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        public void NavigateAca()
        {
            _feinField.SendKeys(ValidFEIN);
            Click(_searchButton);
            Click(_yearDropDown);
            Click(_year2016);
            Click(_showReportButton);
        }
    }
}
