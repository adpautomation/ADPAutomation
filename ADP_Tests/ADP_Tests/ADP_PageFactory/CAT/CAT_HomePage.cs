using ADP_Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_SeleniumFramework.ADP_PageFactory.CAT
{
    public class CAT_HomePage: ADP_AbstractPageFactory
    {
        private By loadingBar = By.XPath("//div[@class='message ng-binding']");

        private By title = By.XPath("//h3[.='Client Lookup']");

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter a Search Query']")]
        private IWebElement client_searchField;

        [FindsBy(How = How.XPath, Using = "//div[@ng-class='paygroup.klass']")]
        private IWebElement companyName;

        public CAT_HomePage() : base()
        {
            waitInvisibleElement(loadingBar);
            waitVisibleElement(title);
        } 

        public void navigateClientLevel()
        {
            click(client_searchField);
            client_searchField.SendKeys(SmokeTestWindow.validCompanyCode);
            click(companyName);
        }
    }
}
