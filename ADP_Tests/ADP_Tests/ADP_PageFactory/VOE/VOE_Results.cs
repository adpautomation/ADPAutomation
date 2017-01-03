using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using AutoIt;
using ADP_SeleniumFramework.resources;
using System.Linq;
using System.IO;

namespace ADP_SeleniumFramework.ADP_PageFactory.VOE
{
    class VOE_Results: ADP_AbstractPageFactory
    {
        string folder = "C:/Users/ramazana/Downloads";

        private By title = By.XPath("//section[@id='request-form']//label[contains(text(), 'Employee')]");

        private By pdfDownload = By.XPath("//div[@class='toast-message']");

        private By loading_bar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//a[@class='logo']")]
        private IWebElement logo;

        [FindsBy(How = How.Id, Using = "inputEmplID")]
        private IWebElement searchField;

        [FindsBy(How = How.Id, Using = "taRequestor")]
        private IWebElement requestorInfo_field;

        [FindsBy(How = How.Id, Using = "inputShowPayInfo")] 
        private IWebElement showPayInformation_checkmark;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-cancel']")]
        private IWebElement startOver_button;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-primary']")]
        private IWebElement submit_button;

        public VOE_Results() : base()
        {
            waitVisibleElement(title);
        }

        public void submit()
        {
            string[] filesToDelete = Directory.GetFiles(folder);
            foreach (string fileToDelete in filesToDelete)
            File.Delete(fileToDelete);
            waitInvisibleElement(loading_bar);
            click(requestorInfo_field);
            requestorInfo_field.SendKeys("This is test. Please disregard any given information");
            click(showPayInformation_checkmark);
            click(submit_button);
            waitVisibleElement(pdfDownload);
            standBy(5);
            string[] files = System.IO.Directory.GetFiles(folder, "*.pdf", SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                Logger.screenshot_PASS("VOE file is successfully downloaded to" + " " + folder);
            }
            else
            {
                Logger.FAIL("Unable to download VOE file");
            }
            waitInvisibleElement(loading_bar);
            click(logo);
        }
    }
}
