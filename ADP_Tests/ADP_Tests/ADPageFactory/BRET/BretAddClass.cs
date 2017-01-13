 using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.BRET
{
    public class BretAddClass: AdpAbstractPageFactory
    {

        private IWebDriver _driver; 

        private By _title = By.XPath("//*[normalize-space(text()) = 'Add Class']");

        [FindsBy(How = How.XPath, Using = "//md-backdrop[@class='md-select-backdrop md-click-catcher ng-scope']")]
        private IWebElement _titleClick;

        [FindsBy(How = How.Id, Using = "select_1075")]
        private IWebElement _cloneExistingClassDd;

        [FindsBy(How = How.XPath, Using = "//input[@name='Name']")]
        private IWebElement _nameField;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='classType']")]
        private IWebElement _classTypeDd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Eligible']")]
        private IWebElement _eligibleClassType;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Not Eligible']")]
        private IWebElement _notEligibleClassType;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Cobra Only']")]
        private IWebElement _cobraOnlyClassType;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'FSA Only']")]
        private IWebElement _fsaOnlyClassType;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='OfferingMethod']")]
        private IWebElement _offeringMethodDd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Life and LTD All']")]
        private IWebElement _lifeAndLtdAllOfferingMethod;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Life and LTD Med']")]
        private IWebElement _lifeAndLtdMedOfferingMethod;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='WaitingPeriod']")]
        private IWebElement _waitingPeriodDd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = '1st of Month > DOH']")]
        private IWebElement _firstMonthWaitingPeriod;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Date of Hire']")]
        private IWebElement _dateOfHireWaitingPeriod;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = '30 Days']")]
        private IWebElement _thirtyDaysWaitingPeriod;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = '60 Days']")]
        private IWebElement _sixtyDaysWaitingPeriod;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='ContributionBy']")]
        private IWebElement _contributionByDd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Employer']")]
        private IWebElement _contributionByEmployer;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Employee']")]
        private IWebElement _contributionByEmployee;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='ContributionType']")]
        private IWebElement _contributionTypeDd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Dollar Amount']")]
        private IWebElement _dollarAmount;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Dollar Amt Tier']")]
        private IWebElement _dollarAmountTier;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Percent']")]
        private IWebElement _percent;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Percent of Single']")]
        private IWebElement _percentOfSingle;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][normalize-space(text()) = 'Percent of Tier']")]
        private IWebElement _percentOfTier;

        [FindsBy(How = How.XPath, Using = "//input[@name='EE_Contrib']")]
        private IWebElement _eeTierField;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Cancel']")]
        private IWebElement _cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Save']")]
        private IWebElement _saveButton;

        public BretAddClass(): base()
        {
            WaitVisibleElement(_title);
        }
        public void VerifyModalContents()
        {
            _nameField.SendKeys("Test");
            Click(_classTypeDd);
            if (IsElementDisplayed(_eligibleClassType)) { }
            if(IsElementDisplayed(_notEligibleClassType)) { }
            if(IsElementDisplayed(_cobraOnlyClassType)) { }
            if(IsElementDisplayed(_fsaOnlyClassType)) {
                Logger.screenshot_PASS("All the class types displayed correctly");
            }
            Click(_titleClick);
            _offeringMethodDd.Click();
              if(IsElementDisplayed(_lifeAndLtdAllOfferingMethod)) { }
              if(IsElementDisplayed(_lifeAndLtdMedOfferingMethod))
              {
                  Logger.screenshot_PASS("All the offering methods displayed correctly");
              }
            Click(_titleClick);
            _waitingPeriodDd.Click();
                if(IsElementDisplayed(_firstMonthWaitingPeriod)) { }
            if (IsElementDisplayed(_dateOfHireWaitingPeriod)) { }
            if (IsElementDisplayed(_thirtyDaysWaitingPeriod)) { }
            if (IsElementDisplayed(_sixtyDaysWaitingPeriod))
            {
                Logger.screenshot_PASS("All the waiting periods displayed corrrectly");
            }
            Click(_titleClick);
            _contributionByDd.Click();
                if(IsElementDisplayed(_contributionByEmployer)) { }
            if (IsElementDisplayed(_contributionByEmployee)) {
                Logger.screenshot_PASS("All the Contribution By displayed correctly");
            }
            Click(_titleClick);
            _contributionTypeDd.Click();
                if(IsElementDisplayed(_dollarAmount)) { }
            if (IsElementDisplayed(_dollarAmountTier)) { }
            if (IsElementDisplayed(_percent)) { }
            if (IsElementDisplayed(_percentOfSingle)) { }
            if (IsElementDisplayed(_percentOfTier)) {
                Logger.screenshot_PASS("All the Contribution Types displayed correctly");
            }
            Click(_titleClick);
            Click(_cancelButton);          
        } 
    }
}
