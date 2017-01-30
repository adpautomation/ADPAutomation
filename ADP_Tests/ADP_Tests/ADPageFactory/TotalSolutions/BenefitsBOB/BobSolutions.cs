using System;
using System.Collections.Generic;
using System.IO;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BenefitsBOB
{
    class BobSolutions: AdpAbstractPageFactory
    {
        private By _title = By.Id("adp-current-breadcrumb-Solutions");

        private By _loadingBar = By.XPath("//div[@class='message ng-binding']");

        [FindsBy(How = How.XPath, Using = "//div[@ng-class=\"{'visibility-hidden': currentProposedMedicalPlan.PlanCode === null}\"]//div[contains(text(),'UNMAPPED.....')]")]
        private IWebElement _unmappedPlans;

        [FindsBy(How = How.XPath, Using = "//a[@class='logo']")]
        private IWebElement _logo;

        [FindsBy(How = How.XPath, Using = "//label[.='Setup']")]
        private IWebElement _setupText;

        [FindsBy(How = How.XPath, Using = "//label[.='Timelines']")]
        private IWebElement _timelinesText;

        [FindsBy(How = How.XPath, Using = "//label[.='Recipients']")]
        private IWebElement _recipientsText;

        [FindsBy(How = How.XPath, Using = "//label[.='Delta Type']")]
        private IWebElement _deltaTypeText;

        [FindsBy(How = How.XPath, Using = "//label[.='Renewal status']")]
        private IWebElement _renewalStatusText;

        [FindsBy(How = How.XPath, Using = "//label[.='Downloads']")]
        private IWebElement _downloadsText;

        [FindsBy(How = How.XPath, Using = "//label[.='Reorder']")]
        private IWebElement _reorderText;

        [FindsBy(How = How.XPath, Using = "//label[.='Add Solution']")]
        private IWebElement _addSolutionText;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='device_hub']")]
        private IWebElement _setupIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='date_range']")]
        private IWebElement _timelinesIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='mail']")]
        private IWebElement _recipientsIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='attach_money']")]
        private IWebElement _detailsInDollarsIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='%']")]
        private IWebElement _detailsInPercentIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='monetization_on']")]
        private IWebElement _percentageWageIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='file_download']")]
        private IWebElement _downloadsIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='compare_arrows']")]
        private IWebElement _reorderIcon;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='add']")]
        private IWebElement _addSolutionIcon;



        public BobSolutions() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
                if(IsElementDisplayed(_setupText)) { }
                if(IsElementDisplayed(_setupIcon)) { }
                if(IsElementDisplayed(_timelinesText)) { }
                if(IsElementDisplayed(_timelinesIcon)) { }
                if(IsElementDisplayed(_recipientsText)) { }
                if(IsElementDisplayed(_recipientsIcon)) { }
                if(IsElementDisplayed(_detailsInDollarsIcon)) { }
                if(IsElementDisplayed(_detailsInPercentIcon)) { }
                if(IsElementDisplayed(_deltaTypeText)) { }
                if(IsElementDisplayed(_percentageWageIcon)) { }
                if(IsElementDisplayed(_downloadsText)) { }
                if(IsElementDisplayed(_downloadsIcon)) { }
                if(IsElementDisplayed(_reorderText)) { }
                if(IsElementDisplayed(_reorderIcon)) { }
                if(IsElementDisplayed(_addSolutionIcon)) { }
                if(IsElementDisplayed(_addSolutionText))
                {
                    Logger.screenshot_PASS("All the Solutions navigation icons are displayed correctly");
                }
        }
        public void VerifyUnmapped()
        {
            var reader = new StreamReader(File.OpenRead("C:/AznariyRamazanov/JMeter Scripts/ErrorLog.csv"));
            List<string> companyCodes = new List<string>();
            List<string> testStatus = new List<string>();
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                companyCodes.Add(values[0]);
                testStatus.Add(values[1]);
            }
            foreach (string companyCode in companyCodes)
            {
                WebDriver.OpenUrl("http://bsg-mobile-dev/dist/#/bobcat/parent-details/EV4/" + companyCode + "/benefits/solutions");
                WaitInvisibleElement(_loadingBar);
                try
                {
                    IsElementDisplayed(_unmappedPlans);
                    Logger.Fail("Client" + " " + "<b>" + companyCode + "</b>" + " " + "contains UNMAPPED Medical plans");
                }catch(NoSuchElementException ex)
                {
                    Console.WriteLine(ex.Message);
                }                
            }
        }
    }
}
