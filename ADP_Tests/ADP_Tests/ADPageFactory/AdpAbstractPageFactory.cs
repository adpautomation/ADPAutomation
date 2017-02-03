using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory
{
    public class AdpAbstractPageFactory : WebDriver
    {
        private IWebDriver driver;
        public AdpAbstractPageFactory()
        {
            PageFactory.InitElements(WebDriver.GetDriver(driver), this);
        }
    }
}
