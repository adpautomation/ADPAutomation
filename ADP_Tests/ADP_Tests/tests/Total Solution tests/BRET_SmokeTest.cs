using ADP_Tests.ADPageFactory.TotalSolutions.BRET;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using NUnit.Framework;
using OpenQA.Selenium;
using ADP_Tests.ADP_PageFactory_TotalSolutions;

namespace ADP_Tests.tests
{
    [TestFixture]
    [Parallelizable]
    public class BretSmokeTest
    {
        private IWebDriver _driver;
        Data _data = new Data();

        [SetUp]
        public void Setup()
        {
            TestCredentialsWindow window = new TestCredentialsWindow();
            window.ShowDialog();
            WebDriver.GetDriver(WebDriver.Initialize(WebDriver.Browser.Remote));
            WebDriver.OpenUrl(TestCredentialsWindow.Env);
            Logger.GetLogger("BRET Smoke Test");
            Logger.StartLogger("BRET Smoke Test", "Quick smoke test of UI");
            
        }
        [Test]
        public void BRET_Smoke_Test()
        {
            Login login = new Login();
            login.LoginToMobile();
            AdpLobby lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.Bret);
            BretHomePage hp = new BretHomePage();
            hp.search_ERFP();
            BretDetails details = new BretDetails();
            details.VerifyHeaderInfo();
            details.NavigateToSolutions();
            BretSolutions solutions = new BretSolutions();
            solutions.VerifyHeaderInfo();
            solutions.NavigateToClassesAndEmployeesSetUp();
            BretClassesEmployeesSetupModal setup = new BretClassesEmployeesSetupModal();
            setup.VerifyModalContent();
            setup.NavigateToAddClass();
            BretAddClass addClass = new BretAddClass();
            addClass.VerifyModalContents();
            setup.CloseModal();
            solutions.NavigateToModifySolution();
            BretModifySolution modify = new BretModifySolution();
            modify.VerifyContents();








        }
        [TearDown]
        public void AfterTest()
        {
            Logger.EndLogger();
        }

    }


}
