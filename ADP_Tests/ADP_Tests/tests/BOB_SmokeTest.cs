using ADP_SeleniumFramework.ADP_PageFactory;
using ADP_SeleniumFramework.resources;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_SeleniumFramework.ADP_PageFactory.BenefitsBOB;
using OpenQA.Selenium;
using ADP_Tests;

namespace tests
{
    [TestFixture]
    [Parallelizable]
    class BOB_SmokeTest
    {
        private IWebDriver driver;

        [SetUp]
        public void setup()
        {
            SmokeTestWindow window = new SmokeTestWindow();
            window.ShowDialog();
            webDriver.getDriver(webDriver.Initialize(webDriver.browser.Remote));
            webDriver.openURL(SmokeTestWindow.env);
            Logger.getLogger("BOB Smoke Test");
            Logger.startLogger("BOB Smoke Test", "Quick smoke test of UI");
        }

        [Test]
        public void BOB_Smoke_Test()
        {
            Login login = new Login();
            login.LoginToMobile();
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Benefits_BOB);
            BenefitsBOB_HomePage bob = new BenefitsBOB_HomePage();
            bob.verifyFilters();



        }

        [TearDown]
        public void afterTest()
        {
            Logger.endLogger();
        }
    }
}
