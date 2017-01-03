using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_SeleniumFramework.resources;
using System.IO;

namespace ADP_SeleniumFramework.ADP_PageFactory.BenefitsBOB
{
    public class BOB_ParentDetails : ADP_AbstractPageFactory
    {
        string folder = "C:/Users/ramazana/Downloads";

        private By title = By.Id("adp-breadcrumb-Parent Details");

        private By loading_bar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//h3[@class='no-margin ng-binding']")]
        private IWebElement companyName_text;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Select Download']")]
        private IWebElement choosePlanType_dropDown;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Download WSE Presentation']")]
        private IWebElement WSE_Presentation;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Download Roster']")]
        private IWebElement Roster;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Select Download...']")]
        private IWebElement downloadPlan_button;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Benefit Solutions']")]
        private IWebElement benefitSolutions_button;

        [FindsBy(How = How.XPath, Using = "//label[.='Market']")]
        private IWebElement market_text;

        [FindsBy(How = How.XPath, Using = "//label[.='Revenue Center']")]
        private IWebElement revenueCenter_text;

        [FindsBy(How = How.XPath, Using = "//label[.='ACR']")]
        private IWebElement ACR_text;

        [FindsBy(How = How.XPath, Using = "//label[.='PTR']")]
        private IWebElement PTR_text;

        [FindsBy(How = How.XPath, Using = "//label[.='CRE']")]
        private IWebElement CRE_text;

        [FindsBy(How = How.XPath, Using = "//label[.='HWE']")]
        private IWebElement HWE_text;

        [FindsBy(How = How.XPath, Using = "//label[.='# Of WSE']")]
        private IWebElement WSE_text;

        [FindsBy(How = How.XPath, Using = "//label[.='HRBP']")]
        private IWebElement HRBP_text;

        [FindsBy(How = How.XPath, Using = "//label[.='BSR']")]
        private IWebElement BSR_text;

        [FindsBy(How = How.XPath, Using = "//label[.='PSR']")]
        private IWebElement PSR_text;

        [FindsBy(How = How.XPath, Using = "//span[.='      WSE Presentation will be emailed to you shortly    ']")]
        private IWebElement WSE_Email_Presentation_Sent;



        public BOB_ParentDetails() : base()
        {
            waitVisibleElement(title);
        }

        public void verifyContents()
        {
            try
            {
                isElementDisplayed(market_text, "");
                isElementDisplayed(revenueCenter_text, "");
                isElementDisplayed(ACR_text, "");
                isElementDisplayed(PTR_text, "");
                isElementDisplayed(CRE_text, "");
                isElementDisplayed(HWE_text, "");
                isElementDisplayed(WSE_text, "");
                isElementDisplayed(HRBP_text, "");
                isElementDisplayed(BSR_text, "");
                isElementDisplayed(PSR_text, "");
                Logger.screenshot_PASS("All the header icons are displayed");
            } catch (NoSuchElementException ex) {
                Logger.screenshot_FAIL("Header icons are displayed incorrectly. Missing" + "" + ex.Message);
            }
        }
        public void download_WSE_Presentation()
        {
            click(choosePlanType_dropDown);
            standBy(1);
            click(WSE_Presentation);
            standBy(1);
            click(downloadPlan_button);
            waitInvisibleElement(loading_bar);
            try
            {
                isElementDisplayed(WSE_Email_Presentation_Sent, "");
                Logger.screenshot_PASS("WSE Presentation should be sent to the user's email");
            }catch(NoSuchElementException ex)
            {
                Logger.screenshot_FAIL("WSE Presentation was not generated");
            }               
        }
        public void download_Roster()
        {
            string[] filesToDelete = Directory.GetFiles(folder);
            foreach (string fileToDelete in filesToDelete)
            File.Delete(fileToDelete);
            click(choosePlanType_dropDown);
            standBy(1);
            click(Roster);
            standBy(1);
            click(downloadPlan_button);
            standBy(5);
            string[] files = System.IO.Directory.GetFiles(folder, "*.xlsx", SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                Logger.screenshot_PASS("Roster file is successfully downloaded to" + " " + folder);
            }
            else
            {
                Logger.FAIL("Unable to download Roster file");
            }
        }
        public void navigateSolutions()
        {
            waitInvisibleElement(loading_bar);
            click(benefitSolutions_button);
        }
    }
}
