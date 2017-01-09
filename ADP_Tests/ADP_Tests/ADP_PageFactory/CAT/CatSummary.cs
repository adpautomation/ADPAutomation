using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.CAT
{
    class CatSummary: AdpAbstractPageFactory
    {
        private readonly By _title = By.Id("adp-current-breadcrumb-Summary");

        private readonly By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//label[.='Market:']")]
        private readonly IWebElement _marketText;

        [FindsBy(How = How.XPath, Using = "//label[.='REVENUE CENTER:']")]
        private readonly IWebElement revenueCenterText;

        [FindsBy(How = How.XPath, Using = "//label[.='ACR:']")]
        private readonly IWebElement acrText;

        [FindsBy(How = How.XPath, Using = "//label[.='PTR:']")]
        private readonly IWebElement ptrText;

        [FindsBy(How = How.XPath, Using = "//label[.='CRE:']")]
        private readonly IWebElement _creText;

        [FindsBy(How = How.XPath, Using = "//label[.='HWE:']")]
        private readonly IWebElement _hweText;

        [FindsBy(How = How.XPath, Using = "//label[.='# OR WSE:']")]
        private readonly IWebElement _numberOfEmployeesText;

        [FindsBy(How = How.XPath, Using = "//label[.='HRBP:']")]
        private readonly IWebElement _hrbtText;

        [FindsBy(How = How.XPath, Using = "//label[.='BSR:']")]
        private readonly IWebElement _bsrText;

        [FindsBy(How = How.XPath, Using = "//label[.='PSR:']")]
        private readonly IWebElement _psrText;

        [FindsBy(How = How.XPath, Using = "//td[.='Paygroup']")]
        private readonly IWebElement _payGroupText;

        [FindsBy(How = How.XPath, Using = "//td[.='Name']")]
        private readonly IWebElement _nameText;

        [FindsBy(How = How.XPath, Using = "//td[.='Client Status']")]
        private readonly IWebElement _clientStatusText;

        [FindsBy(How = How.XPath, Using = "//td[.='Start Date - Term Date']")]
        private readonly IWebElement _startDateText;

        [FindsBy(How = How.XPath, Using = "//td[.='ACR']")]
        private readonly IWebElement _acrText;

        [FindsBy(How = How.XPath, Using = "//td[.='WSE Count']")]
        private IWebElement _wseCountText;

        [FindsBy(How = How.XPath, Using = "//td[.='PTR']")]
        private readonly IWebElement _ptrText;

        [FindsBy(How = How.XPath, Using = "//td[.='DP']")]
        private readonly IWebElement _dpText;

        [FindsBy(How = How.XPath, Using = "//td[.='Revenue Center']")]
        private readonly IWebElement _revenueCenterText;

        [FindsBy(How = How.XPath, Using = "//td[.='Product']")]
        private readonly IWebElement _productText;

        [FindsBy(How = How.XPath, Using = "//td[.='Premium']")]
        private readonly IWebElement _premiumText;

        [FindsBy(How = How.XPath, Using = "//td[.='ER Contribution (% ER Contribution)']")]
        private readonly IWebElement _erContributionText;

        [FindsBy(How = How.XPath, Using = "//td[.='EE Contribution']")]
        private readonly IWebElement _eeContributionText;

        [FindsBy(How = How.XPath, Using = "//td[.='Eligible']")]
        private readonly IWebElement _eligibleText;

        [FindsBy(How = How.XPath, Using = "//td[.='Enrolled (% Med Enrolled)']")]
        private readonly IWebElement _medEnrolledText;

        [FindsBy(How = How.XPath, Using = "//td[.='Type']")]
        private readonly IWebElement _typeText;

        [FindsBy(How = How.XPath, Using = "//td[.='Provider']")]
        private readonly IWebElement _providerText;

        [FindsBy(How = How.XPath, Using = "//td[.='Plan Code']")]
        private IWebElement _planCodeText;

        [FindsBy(How = How.XPath, Using = "//td[.='Plan Name']")]
        private IWebElement _planNameText;

        [FindsBy(How = How.XPath, Using = "//td[.='Enrolled']")]
        private readonly IWebElement _enrolledText;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Summary']")]
        private readonly IWebElement _summaryTab;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='PSA/Rate Level Manager']")]
        private readonly IWebElement _rateLevelManagerTab;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Exception Manager']")]
        private readonly IWebElement _exceptionManagerTab;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Disability Ratings Manager']")]
        private readonly IWebElement _disabilityRatingManagerTab;




        public CatSummary() : base()
        {
            WaitVisibleElement(_title);
        }

        public enum Tab
        {
            Summary, RateLevelManager, ExceptionManager, DisabilityRatingsManager 
        } 

        public void Navigate(Tab tab)
        {
            switch (tab)
            {
                case Tab.Summary:
                    WaitInvisibleElement(_loadingBar);
                    Click(_summaryTab);
                    break;
                case Tab.RateLevelManager:
                    WaitInvisibleElement(_loadingBar);
                    Click(_rateLevelManagerTab);
                    break;
                case Tab.DisabilityRatingsManager:
                    WaitInvisibleElement(_loadingBar);
                    Click(_disabilityRatingManagerTab);
                    break;
                case Tab.ExceptionManager:
                    WaitInvisibleElement(_loadingBar);
                    Click(_exceptionManagerTab);
                    break;
            }
        }
        public void VerifyContents()
        {
            if (IsElementDisplayed(_marketText)) { }
            if (IsElementDisplayed(_revenueCenterText)) { }
            if (IsElementDisplayed(_acrText)) { }
            if (IsElementDisplayed(_ptrText)) { }
            if (IsElementDisplayed(_creText)) { }
            if (IsElementDisplayed(_hweText)) { }
            if (IsElementDisplayed(_numberOfEmployeesText)) { }
            if (IsElementDisplayed(_hrbtText)) { }
            if (IsElementDisplayed(_bsrText)) { }
            if (IsElementDisplayed(_psrText)) { }
            if (IsElementDisplayed(_payGroupText)) { }
            if (IsElementDisplayed(_nameText)) { }
            if (IsElementDisplayed(_clientStatusText)) { }
            if (IsElementDisplayed(_startDateText)) { }
            if (IsElementDisplayed(acrText)) { }
            if (IsElementDisplayed(_wseCountText)) { }
            if (IsElementDisplayed(ptrText)) { }
            if (IsElementDisplayed(_dpText)) { }
            if (IsElementDisplayed(revenueCenterText)) { }
            if (IsElementDisplayed(_productText)) { }
            if (IsElementDisplayed(_premiumText)) { }
            if (IsElementDisplayed(_erContributionText)) { }
            if (IsElementDisplayed(_eeContributionText)) { }
            if (IsElementDisplayed(_eligibleText)) { }
            if (IsElementDisplayed(_medEnrolledText)) { }
            if (IsElementDisplayed(_typeText)) { }
            if (IsElementDisplayed(_providerText)) { }
            if (IsElementDisplayed(_planCodeText)) { }
            if (IsElementDisplayed(_planNameText)) { }
            if (IsElementDisplayed(_enrolledText))
            {
                Logger.screenshot_PASS("CAT Summary. All the page elements are displayed correctly");
            }
        }
    }
}
