using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BenefitsBOB
{
    public class BobModifyPlans: AdpAbstractPageFactory
    {
        private By _title = By.XPath("//span[normalize-space(text()) ='Compare and Choose Plans']");

        private By _loaderModal = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//i[. ='attach_money']")]
        private IWebElement _deltasInDollars;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='select Percent delta']//div[.='%']")]
        private IWebElement _deltasInPercent;

        [FindsBy(How = How.XPath, Using = "//i[. ='monetization_on']")]
        private IWebElement _percentOfWage;

        [FindsBy(How = How.XPath, Using = "//h4[. ='Current']")]
        private IWebElement _currentSolutiontext;

        [FindsBy(How = How.XPath, Using = "//i[. ='settings']")]
        private IWebElement _verifySolutionIcon;

        [FindsBy(How = How.XPath, Using = "//label[. ='Plan Type']")]
        private IWebElement _planTypetext;

        [FindsBy(How = How.XPath, Using = "//label[. ='PLAN']")]
        private IWebElement _planText;

        [FindsBy(How = How.XPath, Using = "//label[. ='Benchmarking']")]
        private IWebElement _benchmarkingText;

        [FindsBy(How = How.XPath, Using = "//label[. ='Bookmarks']")]
        private IWebElement _bookmarkstext;

        [FindsBy(How = How.XPath, Using = "//label[. ='Filters']")]
        private IWebElement _filtersText;

        [FindsBy(How = How.XPath, Using = "//label[. ='Networks']")]
        private IWebElement _networksText;

        [FindsBy(How = How.XPath, Using = "//div[. ='Medical']")]
        private IWebElement _medicalDropDown;

        [FindsBy(How = How.XPath, Using = "//i[. ='star_border']")]
        private IWebElement _bookmarkIcon;

        [FindsBy(How = How.XPath, Using = "//i[. ='filter_list']")]
        private IWebElement _filterIcon;

        [FindsBy(How = How.XPath, Using = "//span[. ='In']")]
        private IWebElement _intext;

        [FindsBy(How = How.XPath, Using = "//span[. ='Out']")]
        private IWebElement _outText;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label ='Prev']")]
        private IWebElement _previousPlanIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label ='Next']")]
        private IWebElement _nextPlanIcon;

        [FindsBy(How = How.XPath, Using = "//h4[. =' Apply Filters']")]
        private IWebElement _applyFiltersText;

        [FindsBy(How = How.XPath, Using = "//p[. ='Filter By:']")]
        private IWebElement _filterByText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text())='Provider']")]
        private IWebElement _providerText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text())='Type of Plan']")]
        private IWebElement _TypeOfPlanText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text())='Rating Area']")]
        private IWebElement _ratingAreaText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text())='Premium Type']")]
        private IWebElement _premiumTypeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text())='Premium Range']")]
        private IWebElement _premiumRangeText;

        [FindsBy(How = How.XPath, Using = "//button[.='OK']")]
        private IWebElement _OKButton;

        [FindsBy(How = How.XPath, Using = "//button[.='Reset']")]
        private IWebElement _resetButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='select plan']//span[.='Add a Plan']")]
        private IWebElement _addPlanLink;

        [FindsBy(How = How.XPath, Using = "//p[normalize-space(text())='In order to add a plan, please select the Paygroup(s) and Class(s) to which the new plan will apply.']")]
        private IWebElement _informationtext;

        [FindsBy(How = How.XPath, Using = "//label[.='Select Paygroups']")]
        private IWebElement _selectPaygroupsText;

        [FindsBy(How = How.XPath, Using = "//label[.='Select Classes']")]
        private IWebElement _selectClassestext;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space(text())='Cancel']")]
        private IWebElement _cancelButton;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space(text())='Continue']")]
        private IWebElement _continueButton;

        [FindsBy(How = How.XPath, Using = "(//i[.='arrow_drop_down'])[1]")]
        private IWebElement _planTypesDropdown;

        [FindsBy(How = How.XPath, Using = "(//i[.='arrow_drop_down'])[2]")]
        private IWebElement _plansDropDown;

        public BobModifyPlans() : base()
        {
            WaitVisibleElement(_title);
            WaitInvisibleElement(_loaderModal);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_planTypetext)) { }
            if (IsElementDisplayed(_planText)) { }
            if (IsElementDisplayed(_benchmarkingText)) { }
            if (IsElementDisplayed(_bookmarkstext)) { }
            if (IsElementDisplayed(_filtersText)) { }
            if (IsElementDisplayed(_networksText)) { }
            if (IsElementDisplayed(_medicalDropDown)) { }
            if (IsElementDisplayed(_bookmarkIcon)) { }
            if (IsElementDisplayed(_intext)) { }
            if (IsElementDisplayed(_outText)) { }
            if (IsElementDisplayed(_previousPlanIcon)) { }
            if (IsElementDisplayed(_nextPlanIcon))
            {
                Logger.screenshot_PASS("Modify plans page navigation icons are OK");
            }
            Click(_filterIcon);
            if (IsElementDisplayed(_applyFiltersText)) { }
            if (IsElementDisplayed(_filterByText)) { }
            if (IsElementDisplayed(_providerText)) { }
            if (IsElementDisplayed(_TypeOfPlanText)) { }
            if (IsElementDisplayed(_ratingAreaText)) { }
            if (IsElementDisplayed(_premiumTypeText)) { }
            if (IsElementDisplayed(_premiumRangeText)) { }
            if (IsElementDisplayed(_OKButton)) { }
            if (IsElementDisplayed(_resetButton))
            {
                Logger.screenshot_PASS("Apply filters modal navigation icons are OK");
            }
            Click(_OKButton);
            Click(_plansDropDown);
            Click(_addPlanLink);
            if (IsElementDisplayed(_informationtext)) { }
            if (IsElementDisplayed(_selectPaygroupsText)) { }
            if (IsElementDisplayed(_selectClassestext)) { }
            if (IsElementDisplayed(_cancelButton)) { }
            if (IsElementDisplayed(_continueButton))
            {
                Logger.screenshot_PASS("Add plan page navigation icons are OK");
            }
        }
    }
}
