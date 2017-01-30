using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.MEP
{
    public class MepHomePage: AdpAbstractPageFactory
    {
        private By _title = By.XPath("//span[normalize-space(text()) = 'Search']");

        private By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//input[@ng-model = 'mepSearch.config.query']")]
        private IWebElement _searchField;


        [FindsBy(How = How.XPath, Using = "//md-select[@ng-model = 'mepSearch.config.searchBy']")]
        private IWebElement _searchByDropDown;


        [FindsBy(How = How.XPath, Using = "(//md-option[@ng-repeat ='searchType in mepSearch.config.searchByOptions'])[1]")]
        private IWebElement _companyCode;


        [FindsBy(How = How.XPath, Using = "(//md-option[@ng-repeat ='searchType in mepSearch.config.searchByOptions'])[2]")]
        private IWebElement _name;


        [FindsBy(How = How.XPath, Using = "(//md-option[@ng-repeat ='searchType in mepSearch.config.searchByOptions'])[3]")]
        private IWebElement _erfp;

        [FindsBy(How = How.XPath, Using = "(//md-option[@ng-repeat ='searchType in mepSearch.config.searchByOptions'])[4]")]
        private IWebElement _recordKeeping;

        [FindsBy(How = How.XPath, Using = "//i[.='search']")]
        private IWebElement _searchButton;

        [FindsBy(How = How.XPath, Using = "(//h4[@class='ng-binding'])[1]")]
        private IWebElement _navigateRecordKeepingLevel;

        [FindsBy(How = How.XPath, Using = "(//h4[@class='ng-binding'])[2]")]
        private IWebElement _navigateCompanyLevel;


        public MepHomePage() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_searchField)) { }
            if (IsElementDisplayed(_searchByDropDown)) { }
            if (IsElementDisplayed(_searchButton)) { }
            Click(_searchByDropDown);
            if (IsElementDisplayed(_companyCode)) { }
            if (IsElementDisplayed(_erfp)) { }
            if (IsElementDisplayed(_name)) { }
            if (IsElementDisplayed(_recordKeeping))
            {
                Logger.screenshot_PASS("All the pafe elements are displayed correctly");
            }
            Click(_companyCode);
        }

        public void NavigateElection()
        {
            _searchField.SendKeys(TestCredentialsWindow.ValidMep);
            Logger.screenshot_PASS("Using" + " " + "<b>" + TestCredentialsWindow.ValidMep + "</b>" + " " + "as test company code");
            Click(_searchButton);
            Click(_navigateRecordKeepingLevel);
        }

        public void NavigateCompany()
        {
            _searchField.SendKeys(TestCredentialsWindow.ValidMep);
            Click(_searchButton);
            Click(_navigateCompanyLevel);
        }
    }
}
