using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.CAT
{
    public class CatHomePage: AdpAbstractPageFactory
    {
        private By _loadingBar = By.XPath("//div[@class='message ng-binding']");

        private By _title = By.XPath("//h3[.='Client Lookup']");

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter a Search Query']")]
        private IWebElement _clientSearchField;

        [FindsBy(How = How.XPath, Using = "//div[@ng-class='paygroup.klass']")]
        private IWebElement _companyName;

        public CatHomePage() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        } 

        public void NavigateClientLevel()
        {
            Click(_clientSearchField);
            _clientSearchField.SendKeys(TestCredentialsWindow.ValidCompanyCode);
            Click(_companyName);
        }
    }
}
