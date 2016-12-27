using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_SeleniumFramework.ADP_PageFactory.VOE
{
    class VOE_Results: ADP_AbstractPageFactory
    {
        private By title = By.XPath("//section[@id='request-form']//label[contains(text(), 'Employee')]");

        [FindsBy(How = How.XPath, Using = "inputEmplID")]
        private IWebElement searchField;


        public VOE_Results() : base()
        {
            waitVisibleElement(title);
        }
    }
}
