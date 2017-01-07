using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.BRET
{
    public class BretClassesEmployeesSetupModal: AdpAbstractPageFactory

    {
        private By _prospectTab = By.XPath("(//md-tabs-canvas[@role='tablist']//span[.='Prospect'])[1]");

        private By _loaderModal = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Classes']")]
        private IWebElement _classesTab;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Employees']")]
        private IWebElement _employeesTab;

        [FindsBy(How = How.XPath, Using = "//span[.='Domestic Partner']")]
        private IWebElement _domesticPartner;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label='Domestic Partner'][@aria-checked='true']")]
        private IWebElement _domesticPartnerFlagOn;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label='Domestic Partner'][@aria-checked='false']")]
        private IWebElement _domesticPartnerFlagOff;

        [FindsBy(How = How.XPath, Using = "//div[@class='relative layout-align-start-start layout-column']//label[.='Benefit Start Date']")]
        private IWebElement _benefitStartDate;

        [FindsBy(How = How.XPath, Using = "//div[@class='ng-scope layout-align-start-start layout-row']//label[.='Enrollment Start Date']")]
        private IWebElement _enrollmentStartDate;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-align-start-start layout-column']//label[.='Enrollment End Date']")]
        private IWebElement _enrollmentEndDate;

        [FindsBy(How = How.XPath, Using = "//md-dialog-actions[@class='plr-16']//a[@aria-label='Close']")]
        private IWebElement _closeButton;

        [FindsBy(How = How.XPath, Using = "//md-datepicker[@ng-model='startDateClone']//md-icon[@aria-label='md-calendar']")]
        private IWebElement _benefitStartDateCalendar;

        [FindsBy(How = How.XPath, Using = "//md-datepicker[@ng-model='enrollmentStartDate']//md-icon[@aria-label='md-calendar']")]
        private IWebElement _enrollmentStartDateCalendar;

        [FindsBy(How = How.XPath, Using = "//md-datepicker[@ng-model='enrollmentEndDate']//md-icon[@aria-label='md-calendar']")]
        private IWebElement _enrollmentEndDateCalendar;

        [FindsBy(How = How.XPath, Using = "//span[.='1099 Class']")]
        private IWebElement _class1099;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label='1099'][@aria-checked='true']")]
        private IWebElement _class1099FlagOn;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label='1099'][@aria-checked='false']")]
        private IWebElement _class1099FlagOff;

        [FindsBy(How = How.XPath, Using = "//div[@class='relative layout-column']//h6[.='Name']")]
        private IWebElement _classesTabName;

        [FindsBy(How = How.XPath, Using = "//h6[@class='bold flex-25']//span[@class='ng-scope']")]
        private IWebElement _defaultMedicalContributionStrategy;

        [FindsBy(How = How.XPath, Using = "//h6[.='Waiting Period']")]
        private IWebElement _waitingPeriod;

        [FindsBy(How = How.XPath, Using = "//h6[.='Offering Method']")]
        private IWebElement _offeringMethod;

        [FindsBy(How = How.XPath, Using = "//h6[.='Type']")]
        private IWebElement _type;

        [FindsBy(How = How.XPath, Using = "//button[@class='md-icon-button md-button ng-scope md-ink-ripple'][@aria-label='add']")]
        private IWebElement _addClassIcon;

        [FindsBy(How = How.XPath, Using = "//div[.='9 - Not Eligible']")]
        private IWebElement _notEligible9;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-align-start-center layout-row flex']//div[contains(text(), 'A -')]")]
        private IWebElement _allFtEmployeesA;

        [FindsBy(How = How.XPath, Using = "//div[@class='adp-employees-scroller']//h6[.='Name']")]
        private IWebElement _employeesTabName;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//h6[.='FT/PT']")]
        private IWebElement _ftPt;

        [FindsBy(How = How.XPath, Using = "//h6[.='Location']")]
        private IWebElement _location;

        [FindsBy(How = How.XPath, Using = "//h6[.='Selected Class']")]
        private IWebElement _selectedClass;

        [FindsBy(How = How.XPath, Using = "//h6[.='Classes']")]
        private IWebElement _employeesTabClasses;


        public BretClassesEmployeesSetupModal(): base()
        {
            WaitVisibleElement(_prospectTab);
        }

        public void VerifyModalContent()
        {
            if (IsElementDisplayed(_domesticPartner)) { }
            if (IsElementDisplayed(_benefitStartDate)) { }
            if (IsElementDisplayed(_enrollmentStartDate)) { }
            if (IsElementDisplayed(_enrollmentEndDate)) { }
            if (IsElementDisplayed(_benefitStartDateCalendar)) { }
            if (IsElementDisplayed(_enrollmentStartDateCalendar)) { }
            if (IsElementDisplayed(_enrollmentEndDateCalendar)) { }
            if (IsElementDisplayed(_closeButton)) {
                Logger.screenshot_PASS("Prospect modal navigation icons are OK");
            }
            Click(_classesTab);
            WaitInvisibleElement(_loaderModal);
            if (IsElementDisplayed(_classesTabName)) { }
            if (IsElementDisplayed(_class1099)) { }
            if (IsElementDisplayed(_defaultMedicalContributionStrategy)) { }
            if (IsElementDisplayed(_waitingPeriod)) { }
            if (IsElementDisplayed(_offeringMethod)) { }
            if (IsElementDisplayed(_type)) { }
            if (IsElementDisplayed(_addClassIcon)) { }
            if (IsElementDisplayed(_notEligible9)) { }
            if (IsElementDisplayed(_allFtEmployeesA)) {
                Logger.screenshot_PASS("Classes modal navigation icons are OK");
            }
            Click(_employeesTab);
            WaitInvisibleElement(_loaderModal);
            if (IsElementDisplayed(_employeesTabName)) { }
            if (IsElementDisplayed(_ftPt)) { }
            if (IsElementDisplayed(_location)) { }
            if (IsElementDisplayed(_selectedClass)) { }
            if (IsElementDisplayed(_employeesTabClasses)) {
                Logger.screenshot_PASS("Employees modal navigation icons are OK");
            }
        }
        public void NavigateToAddClass()
        {
            Click(_classesTab);
            WaitVisibleText(_addClassIcon, "");
            Click(_addClassIcon);
        }
        public void CloseModal()
        {
            StandBy(2);
            WaitInvisibleElement(_loaderModal);
            Click(_closeButton);
        }
    }

}
