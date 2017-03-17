using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BenefitsBOB
{
    public class BobModifyContributions: AdpAbstractPageFactory
    {
        private By _title = By.XPath("//span[normalize-space(text()) ='Contributions']");

        private By _loaderModal = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text())='Enable Bulk Editor']")]
        private IWebElement _bulkEditorText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label='Disabled switch']//div[@class='md-thumb md-ink-ripple']")]
        private IWebElement _bulkEditorSwitch;

        [FindsBy(How = How.XPath, Using = "//label[.='Paygroup/Class']")]
        private IWebElement _paygroupClassesText;

        [FindsBy(How = How.XPath, Using = "//h4[.='ADP Smart Contribution℠']")]
        private IWebElement _ADPSmartContribution;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Reset']")]
        private IWebElement _resetButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Save']")]
        private IWebElement _saveButton;

        [FindsBy(How = How.XPath, Using = "//h3[.='Selected Paygroups & Classes']")]
        private IWebElement _selectedPaygroupsClassesText;

        [FindsBy(How = How.XPath, Using = "//h3[.='Bulk Editor Form']")]
        private IWebElement _bulkEditorFormText;

        [FindsBy(How = How.XPath, Using = "//div[.='Plans']")]
        private IWebElement _plansText;

        [FindsBy(How = How.XPath, Using = "//div[.='Contribution Paid By']")]
        private IWebElement _contributionPaidByText;

        [FindsBy(How = How.XPath, Using = "//form[@name='bulkEditorForm']//md-radio-button[@aria-label='EE']//div[@class='md-container md-ink-ripple']")]
        private IWebElement _contributionPaidByEECheckBox;

        [FindsBy(How = How.XPath, Using = "//form[@name='bulkEditorForm']//md-radio-button[@aria-label='ER']//div[@class='md-container md-ink-ripple']")]
        private IWebElement _contributionPaidByERCheckBox;

        [FindsBy(How = How.XPath, Using = "//div[.='Contribution Type']")]
        private IWebElement _contributionTypeText;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Preview']")]
        private IWebElement _previewButton;





        public BobModifyContributions() : base()
        {
            WaitVisibleElement(_title);
            WaitInvisibleElement(_loaderModal);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_bulkEditorText)) { }
            if (IsElementDisplayed(_ADPSmartContribution)) { }
            if (IsElementDisplayed(_paygroupClassesText)) { }
            if (IsElementDisplayed(_resetButton)) { }
            if (IsElementDisplayed(_saveButton))
            {
                Logger.screenshot_PASS("Modify contributions page navigation icons are OK");
            }
            Click(_bulkEditorSwitch);
            if (IsElementDisplayed(_selectedPaygroupsClassesText)) { }
            if (IsElementDisplayed(_bulkEditorFormText)) { }
            if (IsElementDisplayed(_plansText)) { }
            if (IsElementDisplayed(_contributionPaidByText)) { }
            if (IsElementDisplayed(_contributionPaidByEECheckBox)) { }
            if (IsElementDisplayed(_contributionPaidByERCheckBox)) { }
            if (IsElementDisplayed(_contributionTypeText))
            if (IsElementDisplayed(_previewButton))
            {
                Logger.screenshot_PASS("Modify contributions Bulk Editor page navigation icons are OK");
            }
        } 
    }
}
