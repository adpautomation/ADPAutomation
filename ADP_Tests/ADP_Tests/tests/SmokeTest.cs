using ADP_SeleniumFramework.ADP_PageFactory;
using ADP_SeleniumFramework.resources;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_SeleniumFramework.ADP_PageFactory.BRET;
using ADP_Tests;

namespace tests
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
            Logger.startLogger("Login", "User should be able to login with valid credentials");
            Login login = new Login();
            login.BRET_LoginToMobile();
            Logger.endTest();
        }
        [Test, Order(1)]
        [Parallelizable]
        public void ImpersonateUser()
        {
            Logger.startLogger("Impersonate User", "Verifies that user is able to impersonate another user");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Admin);
            ADP_Admin admin = new ADP_Admin();
            admin.ImpersonateUser();
            ADP_Lobby lobby2 = new ADP_Lobby();
            lobby2.verifyImpersonatedUserName();
            Logger.endTest();
        }

        [TearDown]
        public void afterTest()
        {
            Logger.endLogger();
        }

    }


}
