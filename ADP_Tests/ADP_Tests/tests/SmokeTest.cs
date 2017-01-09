using ADP_Tests.ADP_PageFactory;
using ADP_Tests.ADP_PageFactory.ACAWizard;
using ADP_Tests.ADP_PageFactory.BenefitsBOB;
using ADP_Tests.ADP_PageFactory.CAT;
using ADP_Tests.ADP_PageFactory.EEOC;
using ADP_Tests.ADP_PageFactory.VOE;
using ADP_Tests.ADP_PageFactory.WorkBench;
using ADP_Tests.resources;
using NUnit.Framework;

namespace ADP_Tests.tests
{
    [TestFixture]
    [Parallelizable]
    public class SmokeTest
    {

        [OneTimeSetUp]
        public void OneTimesetUp()
        {
            var window = new SmokeTestWindow();
            window.ShowDialog();
            WebDriver.GetDriver(WebDriver.Initialize(WebDriver.Browser.Remote));
            WebDriver.OpenUrl(SmokeTestWindow.Env);
            var login = new Login();
            login.LoginToMobile();
            Logger.GetLogger("Smoke Test");
        }
        [OneTimeTearDown]
        public void AfterEntireTest()
        {
            Logger.EndLogger();
        }
        [SetUp]
        public void SetUp()
        {
            WebDriver.OpenUrl(SmokeTestWindow.Env);
        }

        [Test, Order(1)]
        public void Impersonate()
        {
            Logger.StartLogger("Impersonate User", "User should be able to impersonate another user");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.Admin);
            var admin = new AdpAdmin();
            admin.ImpersonateUser();
            var lobby2 = new AdpLobby();
            lobby2.VerifyImpersonatedUserName();
        }

        [Test, Order(2)]
        public void Eeoc()
        {
            Logger.StartLogger("EEOC", "User should be able to open EEOC and see the result charts");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.Eeoc);
            var eeoc = new Eeoc();
            eeoc.VerifyContents();
        }

        [Test, Order(3)]
        public void Voe()
        {
            Logger.StartLogger("Verification of Employment", "User should be able to access VOE and submit the form");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.Voe);
            var voeSearch = new VoeSearch();
            voeSearch.search_ID();
            var voeResults = new VoeResults();
            voeResults.Submit();
        }

        [Test, Order(4)]
        public void WorkBench()
        {
            Logger.StartLogger("WorkBench", "User should be able to create an activity");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.WorkBench);
            var wrklobby = new WorkBenchLobby();
            wrklobby.NavegateToLobbyPage();
        }

        [Test, Order(5)]
        public void BOB_ParentLookUp()
        {
            Logger.StartLogger("BOB Home Page", "User should be able to open BOB LookUp page and apply different filters");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.BenefitsBob);
            var home = new BobHomePage();
            home.VerifyContents();
            home.VerifyFilters();
            home.NavigateClientLevel();
        }

        [Test, Order(6)]
        public void BOB_ParentSummary()
        {
            Logger.StartLogger("BOB Parent Page", "User should be able to download Roster and WSE Presentation");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.BenefitsBob);
            var home = new BobHomePage();
            home.NavigateClientLevel();
            var details = new BobParentDetails();
            details.VerifyContents();
            details.download_WSE_Presentation();
            details.download_Roster();
        }

        [Test, Order(7)]
        public void BOB_Solutions()
        {
            Logger.StartLogger("BOB Solutions", "User should be able to navigate to Solutions page");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.BenefitsBob);
            var home = new BobHomePage();
            home.NavigateClientLevel();
            var details = new BobParentDetails();
            details.NavigateSolutions();
            var solutions = new BobSolutions();
            solutions.VerifyContents();
        }

        [Test, Order(8)]
        public void Cat()
        {
            Logger.StartLogger("CAT Home Page", "User should be able to navigate to CAT page");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.ClientAdminTool);
            var home = new CatHomePage();
            home.NavigateClientLevel();
            var summary = new CatSummary();
            summary.VerifyContents();
            summary.Navigate(CatSummary.Tab.RateLevelManager);
            var rate = new CatRateLevelManager();
            rate.VerifyContents();
            summary.Navigate(CatSummary.Tab.ExceptionManager);
            var manager = new CatExceptionManager();
            manager.VerifyContents();
            summary.Navigate(CatSummary.Tab.DisabilityRatingsManager);
            var disability = new CatDisabilityRatingsManager();
            disability.VerifyContents();
        }

        [Test, Order(9)]
        public void ACA_Wizard()
        {
            Logger.StartLogger("ACA Wizard", "User should be able to see the report");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.AcaWizard);
            var home = new AcaWizardHomePage();
            home.NavigateAca();
            var report = new AcaWizardReport();
            report.VerifyContents();
            report.VerifyFinalReport();
        }

        [TearDown]
        [Parallelizable]
        public void Teardown()
        {
            Logger.EndTest();
        }
    }
}
