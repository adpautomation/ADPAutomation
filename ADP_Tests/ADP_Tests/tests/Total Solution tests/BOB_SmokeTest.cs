using ADP_Tests.ADPageFactory.TotalSolutions.BenefitsBOB;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using NUnit.Framework;
using OpenQA.Selenium;
using ADP_Tests.ADP_PageFactory_TotalSolutions;

namespace ADP_Tests.tests
{
    [TestFixture]
    [Parallelizable]
    class BobSmokeTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            TestCredentialsWindow window = new TestCredentialsWindow();
            window.ShowDialog();
            WebDriver.GetDriver(WebDriver.Initialize(WebDriver.Browser.Remote));
            WebDriver.OpenUrl(TestCredentialsWindow.Env);
            Logger.GetLogger("BOB Smoke Test");
            Logger.StartLogger("BOB Smoke Test", "Quick smoke test of UI");
        }

        [Test]
        public void BOB_Smoke_Test()
        {
            Login login = new Login();
            login.LoginToMobile();
            AdpLobby lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.BenefitsBob);
            BobHomePage bob = new BobHomePage();
            bob.VerifyFilters();



        }

        [TearDown]
        public void AfterTest()
        {
            Logger.EndLogger();
        }
    }
}
