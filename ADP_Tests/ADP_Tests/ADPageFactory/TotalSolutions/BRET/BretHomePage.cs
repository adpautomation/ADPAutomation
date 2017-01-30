using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BRET
{
    public class BretHomePage: AdpAbstractPageFactory
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='md-primary md-hue-1 md-button ng-scope md-ink-ripple']")]
        private IWebElement _bret;

        [FindsBy(How = How.Id, Using = "adp-bret-id-input")]
        private IWebElement _bretSearch;

        [FindsBy(How = How.Id, Using = "adp-bret-erfp-input")]
        private IWebElement _erfpSearch;

        [FindsBy(How = How.Id, Using = "adp-bret-legal-name-input")]
        private IWebElement _nameSearch;

        [FindsBy(How = How.Id, Using = "adp-bret-sales-team-select")]
        private IWebElement _salesTeamDd;

        [FindsBy(How = How.Id, Using = "adp-bret-district-manager-select")]
        private IWebElement _districtManagerDd;

        [FindsBy(How = How.Id, Using = "adp-bret-activity-select")]
        private IWebElement _activityDd;

        [FindsBy(How = How.Id, Using = "adp-bret-assigned-broker-input")]
        private IWebElement _assignedBrokerDd;

        [FindsBy(How = How.Id, Using = "adp-bret-clear-button")]
        private IWebElement _clearButton;

        [FindsBy(How = How.Id, Using = "adp-bret-search-button")]
        private IWebElement _searchButton;

        [FindsBy(How = How.XPath, Using = "//a[@ui-sref='sales.details.profile({profileID: result.BRET_ID})']")]
        private IWebElement _foundErfp;

        private By _loaderModal = By.Id("adp-bar-loading-indicator");


        public BretHomePage(): base()
        {
            WaitVisibleText(_bret, "BRET");
        }

        public void search_ERFP()
        {
            _bretSearch.SendKeys(TestCredentialsWindow.BretId);
            WaitInvisibleElement(_loaderModal);
            Click(_searchButton);
            WaitInvisibleElement(_loaderModal);
            Logger.screenshot_PASS("BRET ID" + " " + "<b>" + TestCredentialsWindow.BretId + "</b>" + " " + "is chosen for this test");
            Click(_foundErfp);
        }

        }

}
