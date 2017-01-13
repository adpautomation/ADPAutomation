using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.EEOC
{
    class Eeoc : AdpAbstractPageFactory
    {
        private By _title = By.Id("adp-current-breadcrumb-Summary");

        private By _loadingBar = By.XPath("//div[@class='message ng-binding']");

        [FindsBy(How = How.XPath, Using = "//a[@class='logo']")]
        private IWebElement _logo;

        [FindsBy(How = How.XPath, Using = "//div[@class='message ng-binding']")]
        private IWebElement _loadingBar1;

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-repeat']")]
        private IWebElement _reloadButton;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='vm.downloadExcel()']//i[@class='fa fa-file-excel-o']")]
        private IWebElement _excelButton;

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='vm.downloadCSV()']//i[@class='fa fa-file-excel-o']")]
        private IWebElement _csvButton;

        public Eeoc() : base() { 

         WaitVisibleElement(_title);
        }
        public void VerifyContents()
        {
            WaitInvisibleElement(_loadingBar);
            if (IsElementDisplayed(_loadingBar1))
            {
                Logger.screenshot_FAIL("Loading bar is still displyed after 90 seconds of waiting");
            }else if ( 
            IsElementDisplayed(_reloadButton) &&
            IsElementDisplayed(_excelButton) &&
            IsElementDisplayed(_csvButton)
        )
            {
                Logger.screenshot_PASS("EEOC page elements are displayed");
            }
        }
    }
}
