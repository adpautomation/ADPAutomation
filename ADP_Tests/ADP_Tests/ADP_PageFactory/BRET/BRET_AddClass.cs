using ADP_SeleniumFramework.resources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_SeleniumFramework.ADP_PageFactory.BRET
{
    public class BRET_AddClass: ADP_AbstractPageFactory
    {

        private IWebDriver driver; 

        private By title = By.XPath("//*[.='Add Class']");

        [FindsBy(How = How.XPath, Using = "//md-backdrop[@class='md-select-backdrop md-click-catcher ng-scope']")]
        private IWebElement titleClick;

        [FindsBy(How = How.Id, Using = "select_1075")]
        private IWebElement cloneExistingClass_dd;

        [FindsBy(How = How.XPath, Using = "//input[@name='Name']")]
        private IWebElement name_field;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='classType']")]
        private IWebElement classType_dd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Eligible']")]
        private IWebElement eligible_classType;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Not Eligible']")]
        private IWebElement notEligible_classType;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Cobra Only']")]
        private IWebElement cobraOnly_classType;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='FSA Only']")]
        private IWebElement FSAOnly_classType;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='OfferingMethod']")]
        private IWebElement offeringMethod_dd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Life and LTD All']")]
        private IWebElement lifeAndLTDAll_offeringMethod;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Life and LTD Med']")]
        private IWebElement lifeAndLTDMed_offeringMethod;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='WaitingPeriod']")]
        private IWebElement waitingPeriod_dd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='1st of Month > DOH']")]
        private IWebElement firstMonth_waitingPeriod;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Date of Hire']")]
        private IWebElement dateOfHire_waitingPeriod;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='30 Days']")]
        private IWebElement thirtyDays_waitingPeriod;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='60 Days']")]
        private IWebElement sixtyDays_waitingPeriod;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='ContributionBy']")]
        private IWebElement contributionBy_dd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Employer']")]
        private IWebElement contributionByEmployer;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Employee']")]
        private IWebElement contributionByEmployee;

        [FindsBy(How = How.XPath, Using = "//md-select[@name='ContributionType']")]
        private IWebElement contributionType_dd;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Dollar Amount']")]
        private IWebElement dollarAmount;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Dollar Amt Tier']")]
        private IWebElement dollarAmountTier;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Percent']")]
        private IWebElement percent;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Percent of Single']")]
        private IWebElement percentOfSingle;

        [FindsBy(How = How.XPath, Using = "//div[@class='md-text ng-binding'][.='Percent of Tier']")]
        private IWebElement percentOfTier;

        [FindsBy(How = How.XPath, Using = "//input[@name='EE_Contrib']")]
        private IWebElement eeTier_field;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Cancel']")]
        private IWebElement cancel_button;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Save']")]
        private IWebElement save_button;

        public BRET_AddClass(): base()
        {
            waitVisibleElement(title);
        }
        public void verifyModalContents()
        {
            name_field.SendKeys(Data.ClassName);
            click(classType_dd);
            if(
                isElementDisplayed(eligible_classType, "")&&
                isElementDisplayed(notEligible_classType, "")&&
                isElementDisplayed(cobraOnly_classType, "") &&
                isElementDisplayed(FSAOnly_classType, ""))
                
            {
                Logger.screenshot_PASS("All the class types displayed correctly");
                click(titleClick);
            }
            offeringMethod_dd.Click();
            if(
               isElementDisplayed(lifeAndLTDAll_offeringMethod, "")&&
               isElementDisplayed(lifeAndLTDMed_offeringMethod, ""))              
            {
                Logger.screenshot_PASS("All the offering methods displayed correctly");
                click(titleClick);
            }
            waitingPeriod_dd.Click();
            if(
                isElementDisplayed(firstMonth_waitingPeriod, "")&&
                isElementDisplayed(dateOfHire_waitingPeriod, "")&&
                isElementDisplayed(thirtyDays_waitingPeriod, "")&&
                isElementDisplayed(sixtyDays_waitingPeriod, ""))
            {
                Logger.screenshot_PASS("All the waiting periods displayed corrrectly");
                click(titleClick);
            }
            contributionBy_dd.Click();
            if (
                isElementDisplayed(contributionByEmployer, "") &&
                isElementDisplayed(contributionByEmployee, ""))
            {
                Logger.screenshot_PASS("All the Contribution By displayed correctly");
                click(titleClick);
            }
            contributionType_dd.Click();
            if(
                isElementDisplayed(dollarAmount, "")&&
                isElementDisplayed(dollarAmountTier, "")&&
                isElementDisplayed(percent, "")&&
                isElementDisplayed(percentOfSingle, "")&&
                isElementDisplayed(percentOfTier, ""))
                {
                Logger.screenshot_PASS("All the Contribution Types displayed correctly");
                click(titleClick);
            }
            click(cancel_button);          
        } 
    }
}
