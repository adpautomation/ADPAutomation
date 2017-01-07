using ADP_Tests.resources;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory
{
    public class AdpAbstractPageFactory : WebDriver
    {
        public AdpAbstractPageFactory()
        {
            PageFactory.InitElements(WebDriver.Initialize(Browser.GoogleChrome), this);
        }
    }
}
