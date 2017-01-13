using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory.WorkBench
{
    class WorkBenchLobby: AdpAbstractPageFactory
    {
        private By _title = By.XPath("//div[@class='container-header'][.='Workbench']");

        [FindsBy(How = How.Id, Using = "ContentMain_MobileTile4_im_Image")]
        private IWebElement _activityManagementTile;

        [FindsBy(How = How.Id, Using = "ContentMain_MobileTile3_im_Image")]
        private IWebElement _createActivityTile;

        [FindsBy(How = How.XPath, Using = "//a[@class='logo']")]
        private IWebElement _logo;


        public WorkBenchLobby() : base()
        {
            WaitVisibleElement(_title);
            Logger.screenshot_PASS("Successfully opened WorkBench");
        }
        public void NavigateToAm()
        {
            Click(_activityManagementTile);
        }

        public void NavigateToCa()
        {
            Click(_createActivityTile);
        }
    }
}
