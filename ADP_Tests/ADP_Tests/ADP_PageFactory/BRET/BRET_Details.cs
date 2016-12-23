using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_SeleniumFramework.resources;
using NUnit.Framework;

namespace ADP_SeleniumFramework.ADP_PageFactory.BRET
{
    public class BRET_Details: ADP_AbstractPageFactory
    {

        [FindsBy(How = How.Id, Using = "adp-breadcrumb-Details")]
        private IWebElement details;

        [FindsBy(How = How.XPath, Using = "//h3[@class='text-left no-margin no-padding md-headline ng-binding']")]
        private IWebElement companyName;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[1]")]
        private IWebElement erfpID_field;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[2]")]
        private IWebElement bretID_field;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[3]")]
        private IWebElement bret_status_field;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[4]")]
        private IWebElement ben_start_date_field;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[5]")]
        private IWebElement wse_count_field;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[6]")]
        private IWebElement DM_field;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[7]")]
        private IWebElement revenue_center_field;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[8]")]
        private IWebElement market_field;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[9]")]
        private IWebElement sic_code_field;

        [FindsBy(How = How.XPath, Using = "//div[@ui-view='sales-details-ui-view']//span[@class='ng-binding ng-scope'][.='Profile'][1]")]
        private IWebElement profile_tab;

        [FindsBy(How = How.XPath, Using = "//div[@ui-view='sales-details-ui-view']//span[@class='ng-binding ng-scope'][.='Questionnaire'][1]")]
        private IWebElement questionnaire_tab;

        [FindsBy(How = How.XPath, Using = "//div[@ui-view='sales-details-ui-view']//span[@class='ng-binding ng-scope'][.='Census'][1]")]
        private IWebElement census_tab;

        [FindsBy(How = How.XPath, Using = "//div[@ui-view='sales-details-ui-view']//span[@class='ng-binding ng-scope'][.='Summary/Approval'][1]")]
        private IWebElement summary_approval_tab;

        [FindsBy(How = How.Id, Using = "adp-benefit-solutions-button-callback")]
        private IWebElement BS_button;

        private By loaderModal = By.Id("adp-bar-loading-indicator");





        public BRET_Details(): base()
        {
            waitVisibleText(details, "DETAILS");
        }

        public void verifyHeaderInfo()
        {
            if (
            isElementDisplayed(companyName, "Company Name") &&
            isElementDisplayed(erfpID_field, "ERFP ID") &&
            isElementDisplayed(bretID_field, "BRET ID") &&
            isElementDisplayed(bret_status_field, "BRET Status") &&
            isElementDisplayed(ben_start_date_field, "Benefits Start Date") &&
            isElementDisplayed(wse_count_field, "DM") &&
            isElementDisplayed(DM_field, "WSE Count") &&
            isElementDisplayed(revenue_center_field, "Revenue Center") &&
            isElementDisplayed(market_field, "Market") &&
            isElementDisplayed(sic_code_field, "SIC Code") &&
            isElementDisplayed(profile_tab, "Tab") &&
            isElementDisplayed(questionnaire_tab, "Tab") &&
            isElementDisplayed(census_tab, "Tab") &&
            isElementDisplayed(summary_approval_tab, "Tab")
        )
            {
                Logger.screenshot_PASS("BRET Details header navigation icons are OK");
            }
        }

        public void navigateToSolutions()
        {
            click(BS_button);
        }

    }
}
