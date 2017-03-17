using System.IO;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BenefitsBOB
{
    public class BobParentDetails : AdpAbstractPageFactory
    {
        private string _folder = "C:/Users/ramazana/Downloads";

        private By _title = By.Id("adp-breadcrumb-Parent Details");

        private By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//h3[@class='no-margin ng-binding']")]
        private IWebElement _companyNameText;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Select Download']")]
        private IWebElement _choosePlanTypeDropDown;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Download WSE Presentation']")]
        private IWebElement _wsePresentation;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Download Roster']")]
        private IWebElement _roster;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Client Decision Deck']")]
        private IWebElement _clientDecisionDeck;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Select Download...']")]
        private IWebElement _downloadPlanButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Benefit Solutions']")]
        private IWebElement _benefitSolutionsButton;

        [FindsBy(How = How.XPath, Using = "//label[.='Market']")]
        private IWebElement _marketText;

        [FindsBy(How = How.XPath, Using = "//label[.='Revenue Center']")]
        private IWebElement _revenueCenterText;

        [FindsBy(How = How.XPath, Using = "//label[.='ACR']")]
        private IWebElement _acrText;

        [FindsBy(How = How.XPath, Using = "//label[.='PTR']")]
        private IWebElement _ptrText;

        [FindsBy(How = How.XPath, Using = "//label[.='CRE']")]
        private IWebElement _creText;

        [FindsBy(How = How.XPath, Using = "//label[.='HWE']")]
        private IWebElement _hweText;

        [FindsBy(How = How.XPath, Using = "//label[.='# Of WSE']")]
        private IWebElement _wseText;

        [FindsBy(How = How.XPath, Using = "//label[.='HRBP']")]
        private IWebElement _hrbpText;

        [FindsBy(How = How.XPath, Using = "//label[.='BSR']")]
        private IWebElement _bsrText;

        [FindsBy(How = How.XPath, Using = "//label[.='PSR']")]
        private IWebElement _psrText;

        [FindsBy(How = How.XPath, Using = "//span[.='      WSE Presentation will be emailed to you shortly    ']")]
        private IWebElement _wseEmailPresentationSent;



        public BobParentDetails() : base()
        {
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_marketText)) { }
            if(IsElementDisplayed(_revenueCenterText)) { }
            if (IsElementDisplayed(_acrText)) { }
            if (IsElementDisplayed(_ptrText)) { }
            if (IsElementDisplayed(_creText)) { }
            if (IsElementDisplayed(_hweText)) { }
            if (IsElementDisplayed(_wseText)) { }
            if (IsElementDisplayed(_hrbpText)) { }
            if (IsElementDisplayed(_bsrText)) { }
            if (IsElementDisplayed(_psrText))
            {
                Logger.screenshot_PASS("All the header icons are displayed");
            }
        }
        public void download_WSE_Presentation()
        {
            Click(_choosePlanTypeDropDown);
            StandBy(1);
            Click(_wsePresentation);
            StandBy(1);
            Click(_downloadPlanButton);
            WaitInvisibleElement(_loadingBar);
            try
            {
                IsElementDisplayed(_wseEmailPresentationSent);
                Logger.screenshot_PASS("WSE Presentation should be sent to the user's email");
            }catch(NoSuchElementException ex)
            {
                Logger.screenshot_FAIL("WSE Presentation was not generated");
            }               
        }
        public void download_Roster()
        {
            string[] filesToDelete = Directory.GetFiles(_folder);
            foreach (string fileToDelete in filesToDelete)
            File.Delete(fileToDelete);
            Click(_choosePlanTypeDropDown);
            StandBy(1);
            Click(_roster);
            StandBy(1);
            Click(_downloadPlanButton);
            StandBy(5);
            string[] files = System.IO.Directory.GetFiles(_folder, "*.xlsx", SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                Logger.screenshot_PASS("Roster file is successfully downloaded to" + " " + _folder);
            }
            else
            {
                Logger.Fail("Unable to download Roster file");
            }
        }

        public void download_ClientDecisionDeck()
        {
            string[] filesToDelete = Directory.GetFiles(_folder);
            foreach (string fileToDelete in filesToDelete)
                File.Delete(fileToDelete);
            Click(_choosePlanTypeDropDown);
            StandBy(1);
            Click(_clientDecisionDeck);
            StandBy(1);
            Click(_downloadPlanButton);
            StandBy(5);
            string[] files = System.IO.Directory.GetFiles(_folder, "*.xlsx", SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                Logger.screenshot_PASS("Client Decision Deck file is successfully downloaded to" + " " + _folder);
            }
            else
            {
                Logger.Fail("Unable to download Client Decision Deck file");
            }
        }
        public void NavigateSolutions()
        {
            WaitInvisibleElement(_loadingBar);
            Click(_benefitSolutionsButton);
        }
    }
}
