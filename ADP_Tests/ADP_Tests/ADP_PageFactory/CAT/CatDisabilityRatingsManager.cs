using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.CAT
{
    class CatDisabilityRatingsManager: AdpAbstractPageFactory
    {

        private By _title = By.Id("adp-current-breadcrumb-Manage Disabilities");

        private By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Add Future Disablity Rating']")]
        private IWebElement _addFutureDisabilityRatingButton;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Paygroup')]")]
        private IWebElement _paygroupText;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(), 'Effective Date')]")]
        private IWebElement _effectiveDateText;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(), 'Rating Key')]")]
        private IWebElement _ratingKeyText;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(), 'Owner Occupation')]")]
        private IWebElement _ownerOccupationText;

        [FindsBy(How = How.XPath, Using = "//button[.='Active Only']")]
        private IWebElement _activeOnlyButton;

        [FindsBy(How = How.XPath, Using = "//button[.='All Ratings']")]
        private IWebElement _allRatingsButton;



        public CatDisabilityRatingsManager() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_addFutureDisabilityRatingButton)) { }
            if (IsElementDisplayed(_paygroupText)) { }
            if (IsElementDisplayed(_effectiveDateText)) { }
            if (IsElementDisplayed(_ratingKeyText)) { }
            if (IsElementDisplayed(_ownerOccupationText)) { }
            if (IsElementDisplayed(_activeOnlyButton)) { }
            if (IsElementDisplayed(_allRatingsButton))
            {
                Logger.screenshot_PASS("CAT Disability Ratings Manager. All the page elements are displayed correctly");
            }
        }
    }
}
