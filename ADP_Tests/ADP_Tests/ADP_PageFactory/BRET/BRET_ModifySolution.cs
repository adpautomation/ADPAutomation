using ADP_SeleniumFramework.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_SeleniumFramework.ADP_PageFactory.BRET
{
    class BRET_ModifySolution: ADP_AbstractPageFactory
    {
        private By title = By.XPath("//h2[.='Solutions Summary']");

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='View deltas in dollars']")]
        private IWebElement viewDetailsDeltas;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='%']")]
        private IWebElement viewDetailsPercent;

        [FindsBy(How = How.XPath, Using = "//div[@class='button-group']//button[@aria-label='monetization_on']")]
        private IWebElement viewDetailsDollars;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='event_available']")]
        private IWebElement Annualized;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='today']")]
        private IWebElement pointInTime;

        [FindsBy(How = How.XPath, Using = "//h2[.='Plans']")]
        private IWebElement Plans;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='format_list_bulleted']")]
        private IWebElement planClassMapping;

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='add']")]
        private IWebElement addClass;

        public BRET_ModifySolution() : base()
        {
            waitVisibleElement(title);
        }

        public void verifyContents()
        {
            if (
            isElementDisplayed(viewDetailsDeltas, "") &&
            isElementDisplayed(viewDetailsPercent, "") &&
            isElementDisplayed(viewDetailsDollars, "") &&
            isElementDisplayed(Annualized, "") &&
            isElementDisplayed(pointInTime, "") &&
            isElementDisplayed(Plans, "") &&
            isElementDisplayed(planClassMapping, "") &&
            isElementDisplayed(addClass, "")
        )
            {
                Logger.screenshot_PASS("Modify plan page icons are OK");
            }
        }
    }
}
