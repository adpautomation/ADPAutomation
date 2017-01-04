using ADP_SeleniumFramework.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_SeleniumFramework.ADP_PageFactory.CAT
{
    class CAT_Summary: ADP_AbstractPageFactory
    {
        private By title = By.Id("adp-current-breadcrumb-Summary");

        private By loading_bar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//label[.='Market:']")]
        private IWebElement market_text;

        [FindsBy(How = How.XPath, Using = "//label[.='REVENUE CENTER:']")]
        private IWebElement revenueCenter_text;

        [FindsBy(How = How.XPath, Using = "//label[.='ACR:']")]
        private IWebElement ACR_text;

        [FindsBy(How = How.XPath, Using = "//label[.='PTR:']")]
        private IWebElement PTR_text;

        [FindsBy(How = How.XPath, Using = "//label[.='CRE:']")]
        private IWebElement CRE_text;

        [FindsBy(How = How.XPath, Using = "//label[.='HWE:']")]
        private IWebElement HWE_text;

        [FindsBy(How = How.XPath, Using = "//label[.='# OR WSE:']")]
        private IWebElement numberOfEmployees_text;

        [FindsBy(How = How.XPath, Using = "//label[.='HRBP:']")]
        private IWebElement HRBT_text;

        [FindsBy(How = How.XPath, Using = "//label[.='BSR:']")]
        private IWebElement BSR_text;

        [FindsBy(How = How.XPath, Using = "//label[.='PSR:']")]
        private IWebElement PSR_text;

        [FindsBy(How = How.XPath, Using = "//td[.='Paygroup']")]
        private IWebElement payGroup_text;

        [FindsBy(How = How.XPath, Using = "//td[.='Name']")]
        private IWebElement name_text;

        [FindsBy(How = How.XPath, Using = "//td[.='Client Status']")]
        private IWebElement clientStatus_text;

        [FindsBy(How = How.XPath, Using = "//td[.='Start Date - Term Date']")]
        private IWebElement startDate_text;

        [FindsBy(How = How.XPath, Using = "//td[.='ACR']")]
        private IWebElement acr_text;

        [FindsBy(How = How.XPath, Using = "//td[.='WSE Count']")]
        private IWebElement WSE_count_text;

        [FindsBy(How = How.XPath, Using = "//td[.='PTR']")]
        private IWebElement ptr_text;

        [FindsBy(How = How.XPath, Using = "//td[.='DP']")]
        private IWebElement DP_text;

        [FindsBy(How = How.XPath, Using = "//td[.='Revenue Center']")]
        private IWebElement revenue_center_text;

        [FindsBy(How = How.XPath, Using = "//td[.='Product']")]
        private IWebElement product_text;

        [FindsBy(How = How.XPath, Using = "//td[.='Premium']")]
        private IWebElement premium_text;

        [FindsBy(How = How.XPath, Using = "//td[.='ER Contribution (% ER Contribution)']")]
        private IWebElement ER_contribution_text;

        [FindsBy(How = How.XPath, Using = "//label[.='EE Contribution']")]
        private IWebElement EE_contribution_text;

        [FindsBy(How = How.XPath, Using = "//label[.='Eligible']")]
        private IWebElement eligible_text;

        [FindsBy(How = How.XPath, Using = "//label[.='Enrolled (% Med Enrolled)']")]
        private IWebElement medEnrolled_text;

        [FindsBy(How = How.XPath, Using = "//label[.='Type']")]
        private IWebElement type_text;

        [FindsBy(How = How.XPath, Using = "//label[.='Provider']")]
        private IWebElement provider_text;

        [FindsBy(How = How.XPath, Using = "//label[.='Plan Code']")]
        private IWebElement planCode_text;

        [FindsBy(How = How.XPath, Using = "//label[.='Plan Name']")]
        private IWebElement planName_text;

        [FindsBy(How = How.XPath, Using = "//label[.='Enrolled']")]
        private IWebElement enrolled_text;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Summary']")]
        private IWebElement summary_tab;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='PSA/Rate Level Manager']")]
        private IWebElement rateLevelManager_tab;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Exception Manager']")]
        private IWebElement exceptionManager_tab;

        [FindsBy(How = How.XPath, Using = "//md-tab-item[@role='tab']//span[.='Disability Ratings Manager']")]
        private IWebElement disabilityRatingManager_tab;




        public CAT_Summary() : base()
        {
            waitVisibleElement(title);
        }

        public enum Tab
        {
            Summary, RateLevelManager, ExceptionManager, DisabilityRatingsManager 
        } 

        public void navigate(Tab tab)
        {
            switch (tab)
            {
                case Tab.Summary:
                    waitInvisibleElement(loading_bar);
                    click(summary_tab);
                    break;
                case Tab.RateLevelManager:
                    waitInvisibleElement(loading_bar);
                    click(rateLevelManager_tab);
                    break;
                case Tab.DisabilityRatingsManager:
                    waitInvisibleElement(loading_bar);
                    click(disabilityRatingManager_tab);
                    break;
                case Tab.ExceptionManager:
                    waitInvisibleElement(loading_bar);
                    click(exceptionManager_tab);
                    break;
            }
        }
        public void verifyContents()
        {
            try
            {
                isElementDisplayed(market_text, "");
                isElementDisplayed(revenueCenter_text,"");
                isElementDisplayed(ACR_text, "");
                isElementDisplayed(PTR_text, "");
                isElementDisplayed(CRE_text, "");
                isElementDisplayed(HWE_text, "");
                isElementDisplayed(numberOfEmployees_text, "");
                isElementDisplayed(HRBT_text, "");
                isElementDisplayed(BSR_text, "");
                isElementDisplayed(PSR_text, "");
                isElementDisplayed(payGroup_text, "");
                isElementDisplayed(name_text, "");
                isElementDisplayed(clientStatus_text, "");
                isElementDisplayed(startDate_text, "");
                isElementDisplayed(acr_text, "");
                isElementDisplayed(WSE_count_text, "");
                isElementDisplayed(ptr_text, "");
                isElementDisplayed(DP_text, "");
                isElementDisplayed(revenue_center_text, "");
                isElementDisplayed(product_text, "");
                isElementDisplayed(premium_text, "");
                isElementDisplayed(ER_contribution_text, "");
                isElementDisplayed(EE_contribution_text, "");
                isElementDisplayed(eligible_text, "");
                isElementDisplayed(medEnrolled_text, "");
                isElementDisplayed(type_text, "");
                isElementDisplayed(provider_text, "");
                isElementDisplayed(planCode_text, "");
                isElementDisplayed(planName_text, "");
                isElementDisplayed(enrolled_text, "");
                Logger.screenshot_PASS("CAT Summary. All the page elements are displayed correctly");
            }catch(NoSuchElementException ex)
            {
                Logger.FAIL("CAT Summary. Not all the page elements are displayed correctly." + " " + ex.Message);
            }
        }
    }
}
