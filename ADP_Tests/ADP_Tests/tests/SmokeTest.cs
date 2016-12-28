using ADP_SeleniumFramework.ADP_PageFactory;
using ADP_SeleniumFramework.resources;
using NUnit.Framework;
using OpenQA.Selenium;
using ADP_Tests;
using ADP_Tests.ADP_PageFactory.EEOC;
using ADP_SeleniumFramework.ADP_PageFactory.VOE;

namespace ADP_SeleniumFramework.tests
{
    [TestFixture]
    [Parallelizable]
    public class SmokeTest
    {
        private IWebDriver driver;
        Data data = new Data();
        
        
        [OneTimeSetUp]
        public void setUp()
        {
            SmokeTestWindow window = new SmokeTestWindow();
            window.ShowDialog();
            webDriver.getDriver(webDriver.Initialize(webDriver.browser.Remote));
            webDriver.openURL(SmokeTestWindow.env);
            Logger.getLogger("Smoke Test");
        }

        [Test, Order(1)]
        [Parallelizable]
        public void Login()
        {
            Logger.startLogger("Login", "User should be able to login with valid credentials");
            Login login = new Login();
            login.LoginToMobile();
            Logger.endTest();
        }
        [Test, Order(2)]
        [Parallelizable]
        public void Impersonate() {
            Logger.startLogger("Impersonate User", "User should be able to impersonate another user");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Admin);
            ADP_Admin admin = new ADP_Admin();
            admin.ImpersonateUser();
            ADP_Lobby lobby2 = new ADP_Lobby();
            lobby2.verifyImpersonatedUserName();
            Logger.endTest();
        }
        [Test, Order(3)]
        [Parallelizable]
        public void EEOC()
        {
            Logger.startLogger("EEOC", "User should be able to open EEOC and see the result charts");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.EEOC);
            EEOC eeoc = new EEOC();
            eeoc.verifyContents();
            Logger.endTest();
        }
        [Test, Order(4)]
        [Parallelizable]
        public void VOE()
        {
            Logger.startLogger("Verification of Employment", "User should be able to access VOE and submit the form");
            ADP_Lobby lobby4 = new ADP_Lobby();
            lobby4.navigate(ADP_Lobby.Tile.VOE);
            VOE_Search voe_search = new VOE_Search();
            voe_search.search_ID();
            VOE_Results voe_results = new VOE_Results();
            voe_results.submit();
            Logger.endTest();
        }
        [Test, Order(5)]
        [Parallelizable]
        public void WorkBench()
        {
            Logger.startLogger("WorkBench", "User should be able to create an activity");
            ADP_Lobby lobby5 = new ADP_Lobby();
            lobby5.navigate(ADP_Lobby.Tile.WorkBench);
        }

        [OneTimeTearDown]
        public void afterTest()
        {
            Logger.endLogger();
        }
    }
}
