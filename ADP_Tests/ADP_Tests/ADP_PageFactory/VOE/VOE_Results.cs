using System.IO;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.VOE
{
    class VoeResults: AdpAbstractPageFactory
    {
        string _folder = "C:/Users/ramazana/Downloads";

        private By _title = By.XPath("//section[@id='request-form']//label[contains(text(), 'Employee')]");

        private By _pdfDownload = By.XPath("//div[@class='toast-message']");

        private By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//a[@class='logo']")]
        private IWebElement _logo;

        [FindsBy(How = How.Id, Using = "inputEmplID")]
        private IWebElement _searchField;

        [FindsBy(How = How.Id, Using = "taRequestor")]
        private IWebElement _requestorInfoField;

        [FindsBy(How = How.Id, Using = "inputShowPayInfo")] 
        private IWebElement _showPayInformationCheckmark;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-cancel']")]
        private IWebElement _startOverButton;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-primary']")]
        private IWebElement _submitButton;

        public VoeResults() : base()
        {
            WaitVisibleElement(_title);
        }

        public void Submit()
        {
            string[] filesToDelete = Directory.GetFiles(_folder);
            foreach (string fileToDelete in filesToDelete)
            File.Delete(fileToDelete);
            WaitInvisibleElement(_loadingBar);
            Click(_requestorInfoField);
            _requestorInfoField.SendKeys("This is test. Please disregard any given information");
            Click(_showPayInformationCheckmark);
            Click(_submitButton);
            WaitVisibleElement(_pdfDownload);
            StandBy(5);
            string[] files = System.IO.Directory.GetFiles(_folder, "*.pdf", SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                Logger.screenshot_PASS("VOE file is successfully downloaded to" + " " + _folder);
            }
            else
            {
                Logger.Fail("Unable to download VOE file");
            }
            WaitInvisibleElement(_loadingBar);
        }
        public void Submit2()
        {
            WaitInvisibleElement(_loadingBar);
            Click(_requestorInfoField);
            _requestorInfoField.SendKeys("This is test. Please disregard any given information");
            _submitButton.SendKeys("C:/AznariyRamazanov/TestResults/");
        }
    }
}
