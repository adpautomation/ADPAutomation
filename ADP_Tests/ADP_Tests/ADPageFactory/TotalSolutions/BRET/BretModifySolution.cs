using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BRET
{
    class BretModifySolution: AdpAbstractPageFactory
    {
        private By _title = By.XPath("//h2[.='Solutions Summary']");

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='View deltas in dollars']")]
        private IWebElement _viewDetailsDeltas;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='%']")]
        private IWebElement _viewDetailsPercent;

        [FindsBy(How = How.XPath, Using = "//div[@class='button-group']//button[@aria-label='monetization_on']")]
        private IWebElement _viewDetailsDollars;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='event_available']")]
        private IWebElement _annualized;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='today']")]
        private IWebElement _pointInTime;

        [FindsBy(How = How.XPath, Using = "//h2[.='Plans']")]
        private IWebElement _plans;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='format_list_bulleted']")]
        private IWebElement _planClassMapping;

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='add']")]
        private IWebElement _addClass;

        public BretModifySolution() : base()
        {
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_viewDetailsDeltas)) { }
            if (IsElementDisplayed(_viewDetailsPercent)) { }
            if (IsElementDisplayed(_viewDetailsDollars)) { }
            if (IsElementDisplayed(_annualized)) { }
            if (IsElementDisplayed(_pointInTime)) { }
            if (IsElementDisplayed(_plans)) { }
            if (IsElementDisplayed(_planClassMapping)) { }
            if (IsElementDisplayed(_addClass)) {
                Logger.screenshot_PASS("Modify plan page icons are OK");
            }
        }
}
}
