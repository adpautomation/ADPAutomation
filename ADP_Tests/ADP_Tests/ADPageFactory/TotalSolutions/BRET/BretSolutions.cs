using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BRET
{
    public class BretSolutions: AdpAbstractPageFactory
    {
        private By _selection = By.Id("adp-current-breadcrumb-Selection");

        private By _loaderModal = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//a[@aria-label = 'device_hub']")]
        private IWebElement _classesEmployeesSetup;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'View deltas in dollars']")]
        private IWebElement _viewDetailsInDollars;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = '%']")]
        private IWebElement _viewDetailsInPercent;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'monetization_on']")]
        private IWebElement _viewDetailsInPercentOfWage;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'event_available']")]
        private IWebElement _annualized;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'today']")]
        private IWebElement _pointInTime;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'format_align_justify']")]
        private IWebElement _viewAllPlanTypes;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'drag_handle']")]
        private IWebElement _viewMedicalAndHsaPlans;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//a[@aria-label = 'file_download']")]
        private IWebElement _documents;

        [FindsBy(How = How.XPath, Using = "//button[@title='Select solutions order']")]
        private IWebElement _orderSolutions;

        [FindsBy(How = How.XPath, Using = "//div[@class='layout-row']//button[@aria-label = 'add']")]
        private IWebElement _addSolution;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='onModifySolution()']")]
        private IWebElement _modifySolution;





        public BretSolutions(): base()
        {
            WaitVisibleElement(_selection);
        }

        public void VerifyHeaderInfo()
        {
            if (IsElementDisplayed(_classesEmployeesSetup)) { }
            if (IsElementDisplayed(_viewDetailsInDollars)) { }
            if (IsElementDisplayed(_viewDetailsInPercent)) { }
            if (IsElementDisplayed(_viewDetailsInPercentOfWage)) { }
            if (IsElementDisplayed(_annualized)) { }
            if (IsElementDisplayed(_pointInTime)) { }
            if (IsElementDisplayed(_viewAllPlanTypes)) { }
            if (IsElementDisplayed(_viewMedicalAndHsaPlans)) { }
            if (IsElementDisplayed(_documents)) { }
            if (IsElementDisplayed(_orderSolutions)) { }
            if (IsElementDisplayed(_addSolution)) {
                Logger.screenshot_PASS("BRET Solutions header navigation icons are OK");
            }
        }

        public void NavigateToClassesAndEmployeesSetUp()
        {
            WaitInvisibleElement(_loaderModal);
         Click(_classesEmployeesSetup);
        }

        public void NavigateToModifySolution()
        {
         WaitInvisibleElement(_loaderModal);
         Click(_modifySolution);
        }
    }
}
