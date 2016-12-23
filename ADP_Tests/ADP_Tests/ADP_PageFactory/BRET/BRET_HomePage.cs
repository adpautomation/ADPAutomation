using ADP_SeleniumFramework.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_Tests;
using NUnit.Framework;

namespace ADP_SeleniumFramework.ADP_PageFactory
{
    public class BRET_HomePage: ADP_AbstractPageFactory
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='md-primary md-hue-1 md-button ng-scope md-ink-ripple']")]
        private IWebElement BRET;

        [FindsBy(How = How.Id, Using = "adp-bret-id-input")]
        private IWebElement BRET_search;

        [FindsBy(How = How.Id, Using = "adp-bret-erfp-input")]
        private IWebElement ERFP_search;

        [FindsBy(How = How.Id, Using = "adp-bret-legal-name-input")]
        private IWebElement Name_search;

        [FindsBy(How = How.Id, Using = "adp-bret-sales-team-select")]
        private IWebElement SalesTeam_dd;

        [FindsBy(How = How.Id, Using = "adp-bret-district-manager-select")]
        private IWebElement DistrictManager_dd;

        [FindsBy(How = How.Id, Using = "adp-bret-activity-select")]
        private IWebElement Activity_dd;

        [FindsBy(How = How.Id, Using = "adp-bret-assigned-broker-input")]
        private IWebElement AssignedBroker_dd;

        [FindsBy(How = How.Id, Using = "adp-bret-clear-button")]
        private IWebElement clear_button;

        [FindsBy(How = How.Id, Using = "adp-bret-search-button")]
        private IWebElement search_button;

        [FindsBy(How = How.XPath, Using = "//a[@ui-sref='sales.details.profile({profileID: result.BRET_ID})']")]
        private IWebElement found_ERFP;

        private By loaderModal = By.Id("adp-bar-loading-indicator");


        public BRET_HomePage(): base()
        {
            waitVisibleText(BRET, "BRET");
        }

        public void search_ERFP()
        {
            BRET_search.SendKeys(BRET_SmokeTestWindow.bret_id);
            click(search_button);
            waitInvisibleElement(loaderModal);
            Logger.screenshot_PASS("BRET ID" + " " + "<b>" + BRET_SmokeTestWindow.bret_id + "</b>" + " " + "is chosen for this test");
            click(found_ERFP);
        }

        }

}
