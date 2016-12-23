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
        public void setup()
        {
            BRET_SmokeTestWindow window = new BRET_SmokeTestWindow();
            window.ShowDialog();
            webDriver.getDriver(webDriver.Initialize(webDriver.browser.Remote));
            webDriver.openURL(BRET_SmokeTestWindow.env);
            Logger.getLogger("Smoke Test");
            
        }

        [Test]
        public void Login()
        {
            Logger.startLogger("Login", "Verifies that user is able to Login with valid credentials");
            Login login = new Login();
            login.BRET_LoginToMobile();
            
        }
        [Test]
        public void ImpersonateUser()
        {
            Logger.startLogger("Impersonate User", "Verifies that user is able to impersonate anoter user");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Admin);
            ADP_Admin admin = new ADP_Admin();
            admin.ImpersonateUser();
            lobby.verifyImpersonatedUserName();
        }

        [TearDown]
        public void afterTest()
        {
            Logger.endLogger();
        }

    }


}
