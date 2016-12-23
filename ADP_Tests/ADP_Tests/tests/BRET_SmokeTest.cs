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
    public class BRET_SmokeTest
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
            Logger.getLogger("BRET Smoke Test");
            Logger.startLogger("BRET Smoke Test", "Quick smoke test of UI");
            
        }
        [Test]
        public void BRET_Smoke_Test()
        {
            Login login = new Login();
            login.BRET_LoginToMobile();
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.BRET);
            BRET_HomePage hp = new BRET_HomePage();
            hp.search_ERFP();
            BRET_Details details = new BRET_Details();
            details.verifyHeaderInfo();
            details.navigateToSolutions();
            BRET_Solutions solutions = new BRET_Solutions();
            solutions.verifyHeaderInfo();
            solutions.navigateToClassesAndEmployeesSetUp();
            BRET_ClassesEmployeesSetup_Modal setup = new BRET_ClassesEmployeesSetup_Modal();
            setup.verifyModalContent();
            setup.navigateToAddClass();
            BRET_AddClass addClass = new BRET_AddClass();
            addClass.verifyModalContents();
            setup.closeModal();
            solutions.navigateToModifySolution();
            BRET_ModifySolution modify = new BRET_ModifySolution();
            modify.verifyContents();








        }
        [TearDown]
        public void afterTest()
        {
            Logger.endLogger();
        }

    }


}
