using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_SeleniumFramework.resources;
using NUnit.Framework;

namespace ADP_SeleniumFramework.ADP_PageFactory.BRET
{
    public class BRET_Solutions: ADP_AbstractPageFactory
    {
        private By Selection = By.Id("adp-current-breadcrumb-Selection");

        [FindsBy(How = How.XPath, Using = "//a[@aria-label = 'device_hub']")]
        private IWebElement Classes_Employees_Setup;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'View deltas in dollars']")]
        private IWebElement ViewDetailsInDollars;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = '%']")]
        private IWebElement ViewDetailsInPercent;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'monetization_on']")]
        private IWebElement ViewDetailsInPercentOfWage;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'event_available']")]
        private IWebElement Annualized;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'today']")]
        private IWebElement PointInTime;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'format_align_justify']")]
        private IWebElement ViewAllPlanTypes;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'drag_handle']")]
        private IWebElement ViewMedicalAndHSAPlans;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//a[@aria-label = 'file_download']")]
        private IWebElement Documents;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'view_carouselclear']")]
        private IWebElement OrderSolutions;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'add']")]
        private IWebElement AddSolution;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='onModifySolution()']")]
        private IWebElement ModifySolution;



        public BRET_Solutions(): base()
        {
            waitVisibleElement(Selection);
        }

        public void verifyHeaderInfo()
        {
            if (
            isElementDisplayed(Classes_Employees_Setup, "Classes & Employees Classes icon") &&
            isElementDisplayed(ViewDetailsInDollars, "View Details in Dollars icon") &&
            isElementDisplayed(ViewDetailsInPercent, "View Details in Percent icon") &&
            isElementDisplayed(ViewDetailsInPercentOfWage, "View Details in Percent of Wage icon") &&
            isElementDisplayed(Annualized, "Annualized icon") &&
            isElementDisplayed(PointInTime, "Point in Time icon") &&
            isElementDisplayed(ViewAllPlanTypes, "View All Plan Types icon") &&
            isElementDisplayed(ViewMedicalAndHSAPlans, "View Medical and HSA plans only icon") &&
            isElementDisplayed(Documents, "Document download icon") &&
            isElementDisplayed(OrderSolutions, "Order Solutions icon") &&
            isElementDisplayed(AddSolution, "Add Solutionn icon")
                )
            {
                Logger.screenshot_PASS("BRET Solutions header navigation icons are OK");
            }
        }

        public void navigateToClassesAndEmployeesSetUp()
        {
         click(Classes_Employees_Setup);
        }

        public void navigateToModifySolution()
        {
         standBy(2);
         click(ModifySolution);
        }



    }
}
