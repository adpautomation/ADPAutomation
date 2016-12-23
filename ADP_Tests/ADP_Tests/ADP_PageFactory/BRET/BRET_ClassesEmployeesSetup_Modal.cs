using ADP_SeleniumFramework.ADP_PageFactory;
using ADP_SeleniumFramework.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ADP_SeleniumFramework.ADP_PageFactory.BRET
{
    public class BRET_ClassesEmployeesSetup_Modal: ADP_AbstractPageFactory

    {
        private By prospect_tab = By.XPath("(//md-tabs-canvas[@role='tablist']//span[.='Prospect'])[1]");

        private By loaderModal = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Classes']")]
        private IWebElement classes_tab;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Employees']")]
        private IWebElement employees_tab;

        [FindsBy(How = How.XPath, Using = "//span[.='Domestic Partner']")]
        private IWebElement domesticPartner;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label='Domestic Partner'][@aria-checked='true']")]
        private IWebElement domesticPartner_flagON;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label='Domestic Partner'][@aria-checked='false']")]
        private IWebElement domesticPartner_flagOFF;

        [FindsBy(How = How.XPath, Using = "//div[@class='relative layout-align-start-start layout-column']//label[.='Benefit Start Date']")]
        private IWebElement benefitStartDate;

        [FindsBy(How = How.XPath, Using = "//div[@class='ng-scope layout-align-start-start layout-row']//label[.='Enrollment Start Date']")]
        private IWebElement enrollmentStartDate;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-align-start-start layout-column']//label[.='Enrollment End Date']")]
        private IWebElement enrollmentEndDate;

        [FindsBy(How = How.XPath, Using = "//md-dialog-actions[@class='plr-16']//a[@aria-label='Close']")]
        private IWebElement close_button;

        [FindsBy(How = How.XPath, Using = "//md-datepicker[@ng-model='startDateClone']//md-icon[@aria-label='md-calendar']")]
        private IWebElement benefitStartDate_calendar;

        [FindsBy(How = How.XPath, Using = "//md-datepicker[@ng-model='enrollmentStartDate']//md-icon[@aria-label='md-calendar']")]
        private IWebElement enrollmentStartDate_calendar;

        [FindsBy(How = How.XPath, Using = "//md-datepicker[@ng-model='enrollmentEndDate']//md-icon[@aria-label='md-calendar']")]
        private IWebElement enrollmentEndDate_calendar;

        [FindsBy(How = How.XPath, Using = "//span[.='1099 Class']")]
        private IWebElement class1099;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label='1099'][@aria-checked='true']")]
        private IWebElement class1099_flagON;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label='1099'][@aria-checked='false']")]
        private IWebElement class1099_flagOFF;

        [FindsBy(How = How.XPath, Using = "//div[@class='relative layout-column']//h6[.='Name']")]
        private IWebElement classesTab_name;

        [FindsBy(How = How.XPath, Using = "//h6[@class='bold flex-25']//span[@class='ng-scope']")]
        private IWebElement defaultMedicalContributionStrategy;

        [FindsBy(How = How.XPath, Using = "//h6[.='Waiting Period']")]
        private IWebElement waitingPeriod;

        [FindsBy(How = How.XPath, Using = "//h6[.='Offering Method']")]
        private IWebElement offeringMethod;

        [FindsBy(How = How.XPath, Using = "//h6[.='Type']")]
        private IWebElement type;

        [FindsBy(How = How.XPath, Using = "//button[@class='md-icon-button md-button ng-scope md-ink-ripple'][@aria-label='add']")]
        private IWebElement addClass_icon;

        [FindsBy(How = How.XPath, Using = "//div[.='9 - Not Eligible']")]
        private IWebElement NotEligible_9;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-align-start-center layout-row flex']//div[contains(text(), 'A -')]")]
        private IWebElement AllFTEmployees_A;

        [FindsBy(How = How.XPath, Using = "//div[@class='adp-employees-scroller']//h6[.='Name']")]
        private IWebElement employeesTab_name;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//h6[.='FT/PT']")]
        private IWebElement FT_PT;

        [FindsBy(How = How.XPath, Using = "//h6[.='Location']")]
        private IWebElement location;

        [FindsBy(How = How.XPath, Using = "//h6[.='Selected Class']")]
        private IWebElement selectedClass;

        [FindsBy(How = How.XPath, Using = "//h6[.='Classes']")]
        private IWebElement employeesTab_classes;


        public BRET_ClassesEmployeesSetup_Modal(): base()
        {
            waitVisibleElement(prospect_tab);
        }

        public void verifyModalContent()
        {
            if (
            isElementDisplayed(domesticPartner, "") &&
            isElementDisplayed(benefitStartDate, "") &&
            isElementDisplayed(enrollmentStartDate, "") &&
            isElementDisplayed(enrollmentEndDate, "") &&
            isElementDisplayed(benefitStartDate_calendar, "") &&
            isElementDisplayed(enrollmentStartDate_calendar, "") &&
            isElementDisplayed(enrollmentEndDate_calendar, "") &&
            isElementDisplayed(close_button, "")) 
            {
                Logger.screenshot_PASS("Prospect modal navigation icons are OK");
            }
            click(classes_tab);
            waitInvisibleElement(loaderModal);
            if(
            isElementDisplayed(classesTab_name, "") &&
            isElementDisplayed(class1099, "") &&
            isElementDisplayed(defaultMedicalContributionStrategy, "") &&
            isElementDisplayed(waitingPeriod, "") &&
            isElementDisplayed(offeringMethod, "") &&
            isElementDisplayed(type, "") &&
            isElementDisplayed(addClass_icon, "") &&
            isElementDisplayed(NotEligible_9, "") &&
            isElementDisplayed(AllFTEmployees_A, "")
                )
            {
                Logger.screenshot_PASS("Classes modal navigation icons are OK");
            }
            click(employees_tab);
            waitInvisibleElement(loaderModal);
            if (
            isElementDisplayed(employeesTab_name, "") &&
            isElementDisplayed(FT_PT, "") &&
            isElementDisplayed(location, "") &&
            isElementDisplayed(selectedClass, "") &&
            isElementDisplayed(employeesTab_classes, "")
                )
            {
                Logger.screenshot_PASS("Employees modal navigation icons are OK");
            }
        }
        public void navigateToAddClass()
        {
            click(classes_tab);
            waitVisibleText(addClass_icon, "");
            click(addClass_icon);
        }
        public void closeModal()
        {
            standBy(2);
            waitInvisibleElement(loaderModal);
            click(close_button);
        }
    }

}
