using System;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.RateSheets
{
    class RateSheetsHomePage: AdpAbstractPageFactory
    {
        private string date = DateTime.Now.ToString("MM/dd/yyyy"); 

        private By _loadingBar = By.Id("adp-bar-loading-indicator");

        private By _title = By.XPath("//span[normalize-space(text()) = 'Selections']");

        [FindsBy(How = How.XPath, Using = "//h2[.='Rate sheets']")]
        private IWebElement _rateSheetsText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) = 'Effective Date']")]
        private IWebElement _effectiveDateText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) = 'Headquater State']")]
        private IWebElement _headquaterStateText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) = 'Plan Type']")]
        private IWebElement _planTypeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) = 'Provider']")]
        private IWebElement _providerText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) = 'Rate Level']")]
        private IWebElement _rateLevelText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) = 'Provider Service Areas']")]
        private IWebElement _providerServiceAreasText;

        [FindsBy(How = How.XPath, Using = "//input[@class='md-datepicker-input']")]
        private IWebElement _dateField;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model = 'selectedHeaderQuarterStateOption']")]
        private IWebElement _headquaterStateDropDown;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model= 'selectedPlanTypeOption']")]
        private IWebElement _planTypeDropDown;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model= 'selectedProviderStateOption']")]
        private IWebElement _providerDropDown;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model= 'selectedRateLevelOption']")]
        private IWebElement _rateLevelDropDown;

        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model= 'selectedPSAOptions']")]
        private IWebElement _providerServiceAeasDropDown;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) = 'National']")]
        private IWebElement _nationalHeadQuaterState;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) = 'Vision']")]
        private IWebElement _visionPlanType;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) = 'Life']")]
        private IWebElement _lifePlanType;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) = 'STD']")]
        private IWebElement _stdPlanType;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) = 'LTD']")]
        private IWebElement _ltdPlanType;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) = 'VSP']")]
        private IWebElement _vspProvider;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) = 'ALL']")]
        private IWebElement _allRateLevel;

        [FindsBy(How = How.XPath, Using = "(//md-option[@ng-value = 'currentSelectedPsaOption']//div[normalize-space(text()) = 'National'])[2]")]
        private IWebElement natioanlProviderServiceArea;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Next']")]
        private IWebElement _nextButton;

        public RateSheetsHomePage() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_rateSheetsText)) { }
            if (IsElementDisplayed(_effectiveDateText)) { }
            if (IsElementDisplayed(_headquaterStateText)) { }
            if (IsElementDisplayed(_planTypeText)) { }
            if (IsElementDisplayed(_providerText)) { }
            if (IsElementDisplayed(_rateLevelText)) { }
            if (IsElementDisplayed(_providerServiceAreasText))
            {
                Logger.screenshot_PASS("All the main page elements are displayed correctly");
            }
        }

        public void NavigatetoSheets()
        {
            _dateField.SendKeys(date);
            WaitInvisibleElement(_loadingBar);
            Click(_headquaterStateDropDown);
            WaitInvisibleElement(_loadingBar);
            Click(_nationalHeadQuaterState);
            WaitInvisibleElement(_loadingBar);
            Click(_planTypeDropDown);
            WaitInvisibleElement(_loadingBar);
            Click(_visionPlanType);
            WaitInvisibleElement(_loadingBar);
            Click(_providerDropDown);
            WaitInvisibleElement(_loadingBar);
            Click(_vspProvider);
            WaitInvisibleElement(_loadingBar);
            Click(_rateLevelDropDown);
            WaitInvisibleElement(_loadingBar);
            Click(_allRateLevel);
            WaitInvisibleElement(_loadingBar);
            Click(_providerServiceAeasDropDown);
            WaitInvisibleElement(_loadingBar);
            Click(natioanlProviderServiceArea);
            WaitInvisibleElement(_loadingBar);
            Click(_nextButton);
        }
    }
}
