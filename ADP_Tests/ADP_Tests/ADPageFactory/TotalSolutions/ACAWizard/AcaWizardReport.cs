using System.IO;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.ACAWizard
{
    class AcaWizardReport : AdpAbstractPageFactory
    {
        private string ValidFEIN = "111111111";

        private readonly string _folder = "C:/Users/ramazana/Downloads";

        private readonly By _title = By.XPath("//button[@id='adp-current-breadcrumb-Report']");

        private readonly By _loadingBar = By.Id("adp-bar-loading-indicator");

        private readonly By _curtain2 = By.XPath("//div[@class='md-dialog-container ng-scope']");

        [FindsBy(How = How.XPath, Using = "//input[@name='Fein']")]
        private readonly IWebElement _feinField;

        [FindsBy(How = How.XPath, Using = "//label[.='Search']")]
        private readonly IWebElement _searchField;

        [FindsBy(How = How.XPath, Using = "//md-select[@aria-label='Filter']")]
        private readonly IWebElement _filterDropDown;

        [FindsBy(How = How.XPath, Using = "//md-checkbox[@ng-model='ctrl.filter.incomplete']//div[@class='md-icon']")]
        private readonly IWebElement _incompleteOnlyCheckbox;

        [FindsBy(How = How.XPath, Using = "(//md-checkbox[@aria-label='Incomplete']//span[@class='ng-scope'])[1]")]
        private readonly IWebElement _incompleteText;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Clear Filters']")]
        private readonly IWebElement _clearFiltersButton;

        [FindsBy(How = How.XPath, Using = "//md-checkbox[@ng-model='ctrl.report.bulkEditor.show']//div[@class='md-icon']")]
        private IWebElement _showBulkEditorCheckbox;

        [FindsBy(How = How.XPath, Using = "(//md-checkbox[@aria-label='Incomplete']//span[@class='ng-scope'])[2]")]
        private IWebElement _showBulkEditorText;

        [FindsBy(How = How.XPath, Using = "//span[.='Client Survey']")]
        private IWebElement _clientSurveyButton;

        [FindsBy(How = How.XPath, Using = "//span[.='Download Final Report']")]
        private IWebElement _downloadFinalReportButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Open Menu Button']")]
        private IWebElement _hamburgerMenuIcon;

        [FindsBy(How = How.XPath, Using = "//md-option[@ng-repeat='option in ctrl.filter.options']//div[normalize-space(text()) = 'All']")]
        private IWebElement _filterAllDropDownSelection;

        [FindsBy(How = How.XPath, Using = "//md-option[@ng-repeat='option in ctrl.filter.options']//div[normalize-space(text()) = 'EV4']")]
        private IWebElement _filterEv4DropDownSelection;

        [FindsBy(How = How.XPath, Using = "//md-option[@ng-repeat='option in ctrl.filter.options']//div[normalize-space(text()) = 'Additional']")]
        private IWebElement _filterAdditionalDropDownSelection;

        [FindsBy(How = How.XPath, Using = "//md-option[@ng-repeat='option in ctrl.filter.options']//div[normalize-space(text()) = 'Selected']")]
        private IWebElement _filterSelectedDropDownSelection;

        [FindsBy(How = How.XPath, Using = "//h4[.='Client Survey']")]
        private IWebElement _clientSurveyText;

        [FindsBy(How = How.XPath, Using = "//h5[.='Plan Year start/renewal month?']")]
        private IWebElement _question1Text;

        [FindsBy(How = How.XPath, Using = "//h5[.='Did Client make a Conditional Offer of Coverage to Spouses?']")]
        private IWebElement _question2Text;

        [FindsBy(How = How.XPath, Using = "//h5[.='Did Client make a Conditional Offer of Coverage to Dependents?']")]
        private IWebElement _question3Text;

        [FindsBy(How = How.XPath, Using = "//h5[.='Did Client limit the number of Dependents offered coverage?']")]
        private IWebElement _question4Text;

        [FindsBy(How = How.XPath, Using = "//h5[.='Highest level of health coverage offered?']")]
        private IWebElement _question5Text;

        [FindsBy(How = How.XPath, Using = "//h5[.='Does Client offer their own medical plans?']")]
        private IWebElement _question6Text;

        [FindsBy(How = How.XPath, Using = "//h5[.='Will only 1 Affordability Safe Harbor method apply?']")]
        private IWebElement _question7Text;

        [FindsBy(How = How.XPath, Using = "//h5[.='Did the client contribute to a Health Reimbursement Account (HRA)?']")]
        private IWebElement _question8Text;

        [FindsBy(How = How.XPath, Using = "//h5[.='Did the client offer employees an Opt-Out payment for waiving coverage in the respective calendar year?']")]
        private IWebElement _question9Text;

        [FindsBy(How = How.XPath, Using = "//h5[.='TotalSource Start Date?']")]
        private IWebElement _question10Text;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Close']")]
        private IWebElement _clientSurveyCloseButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Save']")]
        private IWebElement _clientSurveySaveButton;

        [FindsBy(How = How.XPath, Using = "//i[.='fullscreen']")]
        private IWebElement _fullscreenIcon;

        [FindsBy(How = How.XPath, Using = "//span[.='Employee Template File']")]
        private IWebElement _employeeTemplateFile;

        [FindsBy(How = How.XPath, Using = "//span[.='Safe Harbor Calculator']")]
        private IWebElement _safeHarborCalculator;

        [FindsBy(How = How.XPath, Using = "//span[.='ART File']")]
        private IWebElement _artFile;

        [FindsBy(How = How.XPath, Using = "//span[.='Additional WSE File']")]
        private IWebElement _additionalWseFile;

        [FindsBy(How = How.XPath, Using = "//span[.='Reset Report (EE info only)']")]
        private IWebElement _resetReport;

        [FindsBy(How = How.XPath, Using = "//span[.='Reset Report & Client Survey']")]
        private IWebElement _resetReportAndClientSurvey;

        [FindsBy(How = How.XPath, Using = "//span[.='View Different Report Year']")]
        private IWebElement _viewDifferentReportYear;

        [FindsBy(How = How.XPath, Using = "//body[@ng-controller='MainController']")]
        private IWebElement _curtain;

        public AcaWizardReport() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        
        public void VerifyContents()
        {
            #region Verifying main contents of the page
            if (IsElementDisplayed(_searchField)) { }
            if (IsElementDisplayed(_filterDropDown)) { }
            if (IsElementDisplayed(_incompleteOnlyCheckbox)) { }
            if (IsElementDisplayed(_incompleteText)) { }
            if (IsElementDisplayed(_clearFiltersButton)) { }
            if (IsElementDisplayed(_showBulkEditorCheckbox)) { }
            if (IsElementDisplayed(_showBulkEditorText)) { }
            if (IsElementDisplayed(_clientSurveyButton)) { }
            if (IsElementDisplayed(_downloadFinalReportButton)) { }
            if (IsElementDisplayed(_fullscreenIcon))
            {
                Logger.screenshot_PASS("ACA Report. All the main page elemens are displayed correctly");
            }
#endregion
            Click(_filterDropDown);
            #region Verifying contents of the Filter drop down
            if (IsElementDisplayed(_filterAllDropDownSelection)) { }
            if (IsElementDisplayed(_filterEv4DropDownSelection)) { }
            if (IsElementDisplayed(_filterAdditionalDropDownSelection)) { }
            if (IsElementDisplayed(_filterSelectedDropDownSelection))
            {
                Logger.screenshot_PASS("ACA Report. Filter drop down. All the values are displayed correctly");
            }
#endregion
            Click(_curtain);
            Click(_clientSurveyButton);
            #region Verifying contents of the Client Survey modal window 
            if (IsElementDisplayed(_clientSurveyText)) { }
            if (IsElementDisplayed(_question1Text)) { }
            if (IsElementDisplayed(_question2Text)) { }
            if (IsElementDisplayed(_question3Text)) { }
            if (IsElementDisplayed(_question4Text)) { }
            if (IsElementDisplayed(_question5Text)) { }
            if (IsElementDisplayed(_question6Text)) { }
            if (IsElementDisplayed(_question7Text)) { }
            if (IsElementDisplayed(_question8Text)) { }
            if (IsElementDisplayed(_question9Text)) { }
            if (IsElementDisplayed(_question10Text))
            {
                Logger.screenshot_PASS("ACA Report. Client Survey pop up. All the values are displayed correctly");
            }
#endregion
            Click(_clientSurveyCloseButton);
            StandBy(2);
            Click(_hamburgerMenuIcon);
            #region Verifying contents of the right habmurger menu
            if (IsElementDisplayed(_employeeTemplateFile)) { }
            if (IsElementDisplayed(_safeHarborCalculator)) { }
            if (IsElementDisplayed(_artFile)) { }
            if (IsElementDisplayed(_additionalWseFile)) { }
            if (IsElementDisplayed(_resetReport)) { }
            if (IsElementDisplayed(_resetReportAndClientSurvey)) { }
            if (IsElementDisplayed(_viewDifferentReportYear))
            {
                Logger.screenshot_PASS("ACA Reports. Hamburger menu. All the page elements are displayed correctly.");
            }
#endregion
        }

        public void VerifyFinalReport()
        {
            string[] filesToDelete = Directory.GetFiles(_folder);
            foreach (string fileToDelete in filesToDelete)
                File.Delete(fileToDelete);
            WaitInvisibleElement(_loadingBar);
            Click(_curtain);
            Click(_downloadFinalReportButton);
            StandBy(3);
            string[] files = System.IO.Directory.GetFiles(_folder, "*.xls", SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                Logger.screenshot_PASS("FEIN for" + " " + "<b>" + ValidFEIN + "</b>" + " " + "is successfully downloaded to" + " " + _folder);
            }
            else
            {
                Logger.Fail("Unable to download FEIN file");
            }
            WaitInvisibleElement(_loadingBar);
        }
    }
}
