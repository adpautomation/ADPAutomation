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
        

        [SetUp]
        public void setUp()
        {
            BRET_SmokeTestWindow window = new BRET_SmokeTestWindow();
            window.ShowDialog();
            webDriver.getDriver(webDriver.Initialize(webDriver.browser.Remote));
            webDriver.openURL(BRET_SmokeTestWindow.env);
            Logger.getLogger("Smoke Test");
        }

        [Test, Order(1)]
        [Parallelizable]
        public void Main_Features_SmokeTest()
        {
            Logger.startLogger("Login", "User should be able to login with valid credentials");
            Login login = new Login();
            login.BRET_LoginToMobile();
            Logger.endTest();
            Logger.startLogger("Impersonate User", "User should be able to impersonate another user");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Admin);
            ADP_Admin admin = new ADP_Admin();
            admin.ImpersonateUser();
            ADP_Lobby lobby2 = new ADP_Lobby();
            lobby2.verifyImpersonatedUserName();
            Logger.endTest();
            Logger.startLogger("EEOC", "User should be able to open EEOC and see the results charts");
            ADP_Lobby lobby3 = new ADP_Lobby();
            lobby3.navigate(ADP_Lobby.Tile.EEOC);
            EEOC eeoc = new EEOC();
            eeoc.verifyContents();
            Logger.endTest();
            Logger.startLogger("Verification of Employment", "User should be able to open EEOC and see the results charts");
            ADP_Lobby lobby4 = new ADP_Lobby();
            lobby4.navigate(ADP_Lobby.Tile.VOE);
            VOE_Search voe_search = new VOE_Search();
            voe_search.search_ID();
            VOE_Results voe_results = new VOE_Results();


        }

        [TearDown]
        public void afterTest()
        {
            Logger.endLogger();
        }

    }


}
