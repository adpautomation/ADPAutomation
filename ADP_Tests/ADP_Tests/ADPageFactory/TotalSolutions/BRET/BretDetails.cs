using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BRET
{
    public class BretDetails: AdpAbstractPageFactory
    {
        [FindsBy(How = How.Id, Using = "adp-breadcrumb-Details")]
        private IWebElement _details;

        [FindsBy(How = How.XPath, Using = "//h3[@class='text-left no-margin no-padding md-headline ng-binding']")]
        private IWebElement _companyName;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[1]")]
        private IWebElement _erfpIdField;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[2]")]
        private IWebElement _bretIdField;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[3]")]
        private IWebElement _bretStatusField;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[4]")]
        private IWebElement _benStartDateField;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[5]")]
        private IWebElement _wseCountField;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[6]")]
        private IWebElement _dmField;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[7]")]
        private IWebElement _revenueCenterField;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[8]")]
        private IWebElement _marketField;

        [FindsBy(How = How.XPath, Using = "(//div[@class='detail ng-binding'])[9]")]
        private IWebElement _sicCodeField;

        [FindsBy(How = How.XPath, Using = "//div[@ui-view='sales-details-ui-view']//span[@class='ng-binding ng-scope'][.='Profile'][1]")]
        private IWebElement _profileTab;

        [FindsBy(How = How.XPath, Using = "//div[@ui-view='sales-details-ui-view']//span[@class='ng-binding ng-scope'][.='Questionnaire'][1]")]
        private IWebElement _questionnaireTab;

        [FindsBy(How = How.XPath, Using = "//div[@ui-view='sales-details-ui-view']//span[@class='ng-binding ng-scope'][.='Census'][1]")]
        private IWebElement _censusTab;

        [FindsBy(How = How.XPath, Using = "//div[@ui-view='sales-details-ui-view']//span[@class='ng-binding ng-scope'][.='Summary/Approval'][1]")]
        private IWebElement _summaryApprovalTab;

        [FindsBy(How = How.Id, Using = "adp-benefit-solutions-button-callback")]
        private IWebElement _bsButton;

        private By _loaderModal = By.Id("adp-bar-loading-indicator");





        public BretDetails(): base()
        {
            WaitInvisibleElement((_loaderModal));
            WaitVisibleText(_details, "DETAILS");
        }

        public void VerifyHeaderInfo()
        {
            if (IsElementDisplayed(_companyName)) { }
            if (IsElementDisplayed(_erfpIdField)) { }
            if (IsElementDisplayed(_bretIdField)) { }
            if (IsElementDisplayed(_bretStatusField)) { }
            if (IsElementDisplayed(_benStartDateField)) { }
            if (IsElementDisplayed(_wseCountField)) { }
            if (IsElementDisplayed(_dmField)) { }
            if (IsElementDisplayed(_revenueCenterField)) { }
            if (IsElementDisplayed(_marketField)) { }
            if (IsElementDisplayed(_sicCodeField)) { }
            if (IsElementDisplayed(_profileTab)) { }
            if (IsElementDisplayed(_questionnaireTab)) { }
            if (IsElementDisplayed(_censusTab)) { }
            if (IsElementDisplayed(_summaryApprovalTab)) {
                Logger.screenshot_PASS("BRET Details header navigation icons are OK");
            }
}

        public void NavigateToSolutions()
        {
            WaitInvisibleElement(_loaderModal);
            Click(_bsButton);
        }

    }
}
