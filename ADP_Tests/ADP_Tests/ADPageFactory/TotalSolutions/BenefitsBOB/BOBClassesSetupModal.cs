using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BenefitsBOB
{
   public class BobClassesSetupModal: AdpAbstractPageFactory
    {
        [FindsBy(How = How.XPath, Using = "//md-tab-item[@aria-selected = 'true']//span[contains(text(), 'Current')]")]
        private readonly IWebElement _currentTab;

        [FindsBy(How = How.XPath, Using = "(//span[.='Domestic Partner'])[1]")]
        private readonly IWebElement _currentDomesticPartnerText;

        [FindsBy(How = How.XPath, Using = "(//md-switch[@aria-label='Domestic Partner']//div[@class='md-bar'])[1]")]
        private readonly IWebElement _currentDomesticPartnerFlag;

        [FindsBy(How = How.XPath, Using = "(//h6[.='Name'])[1]")]
        private readonly IWebElement _currentTabName;

        [FindsBy(How = How.XPath, Using = "(//h6[.='Type'])[1]")]
        private readonly IWebElement _currentTabType;

        [FindsBy(How = How.XPath, Using = "(//h6[.='Waiting Period'])[1]")]
        private readonly IWebElement _currentTabWaitingPeriod;

        [FindsBy(How = How.XPath, Using = "(//h6[.='Offering Method'])[1]")]
        private readonly IWebElement _currentTabOfferingMEthod;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@aria-selected = 'false']//span[contains(text(), 'Renewal')]")]
        private readonly IWebElement _renewalTab;

        [FindsBy(How = How.XPath, Using = "(//span[.='Domestic Partner'])[2]")]
        private readonly IWebElement _renewalDomesticPartnerText;

        [FindsBy(How = How.XPath, Using = "(//md-switch[@aria-label='Domestic Partner']//div[@class='md-bar'])[2]")]
        private readonly IWebElement _renewalDomesticPartnerFlag;

        [FindsBy(How = How.XPath, Using = "(//h6[.='Name'])[1]")]
        private readonly IWebElement _renewalTabName;

        [FindsBy(How = How.XPath, Using = "(//h6[.='Type'])[1]")]
        private readonly IWebElement _renewalTabType;
        [FindsBy(How = How.XPath, Using = "(//h6[.='Waiting Period'])[1]")]
        private readonly IWebElement _renewalTabWaitingPeriod;

        [FindsBy(How = How.XPath, Using = "(//h6[.='Offering Method'])[1]")]
        private readonly IWebElement _renewalTabOfferingMethod;

        [FindsBy(How = How.XPath, Using = "(//button[@aria-label='delete']//i[.='delete'])[1]")]
        private readonly IWebElement _renewalTabDeleteIcon;

        public BobClassesSetupModal() : base()
        {
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_currentTab)) { }
            if (IsElementDisplayed(_currentDomesticPartnerText)) { }
            if (IsElementDisplayed(_currentDomesticPartnerFlag)) { }
            if (IsElementDisplayed(_currentTabName)) { }
            if (IsElementDisplayed(_currentTabType)) { }
            if (IsElementDisplayed(_currentTabWaitingPeriod)) { }
            if (IsElementDisplayed(_currentTabOfferingMEthod))
            {
                Logger.screenshot_PASS("Current class setup navigation icons are displayed correctly");
            }
            Click(_renewalTab);
            if (IsElementDisplayed(_renewalDomesticPartnerText)) { }
            if (IsElementDisplayed(_renewalDomesticPartnerFlag)) { }
            if (IsElementDisplayed(_renewalTabName)) { }
            if (IsElementDisplayed(_renewalTabType)) { }
            if (IsElementDisplayed(_renewalTabWaitingPeriod)) { }
            if (IsElementDisplayed(_renewalTabOfferingMethod)) { }
            if (IsElementDisplayed(_renewalTabDeleteIcon))
            {
                Logger.screenshot_PASS("Renewal class setup navigation icons are displayed correctly");
            }
        }
    }
 }
