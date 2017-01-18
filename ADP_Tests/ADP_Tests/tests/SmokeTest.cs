using ADP_Tests.ADPageFactory.MEP;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.ADP_PageFactory.ACAWizard;
using ADP_Tests.ADP_PageFactory.BenefitsBOB;
using ADP_Tests.ADP_PageFactory.BRET;
using ADP_Tests.ADP_PageFactory.CAT;
using ADP_Tests.ADP_PageFactory.EEOC;
using ADP_Tests.ADP_PageFactory.RateSheets;
using ADP_Tests.ADP_PageFactory.VOE;
using ADP_Tests.ADP_PageFactory.WorkBench;
using ADP_Tests.resources;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using Logger = ADP_Tests.resources.Logger;
using System;

namespace ADP_Tests.tests
{
    [TestFixture]
    [Parallelizable]
    public class SmokeTest
    {

        [OneTimeSetUp]
        public void OneTimesetUp()
        {
            #region Open the window to insert test parameters 

            var window = new TestCredentialsWindow();
            window.ShowDialog();

            #endregion

            #region Initializing remote web driver

            WebDriver.GetDriver(WebDriver.Initialize(WebDriver.Browser.Remote));

            #endregion

            #region Open predefined environment

            WebDriver.OpenUrl(TestCredentialsWindow.Env);

            #endregion

            #region Login to the Total Solutions

            var login = new Login();
            login.LoginToMobile();

            #endregion

            #region Start the reporter tool

            Logger.GetLogger("Smoke Test");

            #endregion
        }

        [OneTimeTearDown]
        public void AfterEntireTest()
        {
            Logger.EndLogger();
        }

        [SetUp]
        public void SetUp()
        {
            WebDriver.OpenUrl(TestCredentialsWindow.Env);
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
        }

        [Test, Order(5)]
        public void BOB_ParentLookUp()
        {
            Logger.StartLogger("BOB Home Page",
                "User should be able to open BOB LookUp page and apply different filters");
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
        public void Bret()
        {
            Logger.StartLogger("BRET", "User should be able to navigate to BRET Solutions");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.Bret);
            var home = new BretHomePage();
            home.search_ERFP();
            var details = new BretDetails();
            details.VerifyHeaderInfo();
            details.NavigateToSolutions();
            var solutions = new BretSolutions();
            solutions.VerifyHeaderInfo();
            solutions.NavigateToClassesAndEmployeesSetUp();
            var setup = new BretClassesEmployeesSetupModal();
            setup.VerifyModalContent();
            setup.NavigateToAddClass();
            var addClass = new BretAddClass();
            addClass.VerifyModalContents();
            setup.CloseModal();
            solutions.NavigateToModifySolution();
            var modify = new BretModifySolution();
            modify.VerifyContents();
        }

        [Test, Order(10)]
        public void RateSheets()
        {
            Logger.StartLogger("Rate Sheets", "User should be able to navigate to Rate Sheets and generate the report");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.RateSheets);
            var sheets = new RateSheetsHomePage();
            sheets.VerifyContents();
            sheets.NavigatetoSheets();
        }

        [Test, Order(11)]
        public void Mep()
        {
            Logger.StartLogger("MEP", "User should be able to look for and navigate to Company Level");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.Mep);
            var home = new MepHomePage();
            home.VerifyContents();
            home.NavigateElection();
            var elections = new MepElection();
            elections.VerifyContents();
            var home2 = new MepHomePage();
            home2.NavigateCompany();
            var company = new MepCompany();
            company.VerifyContents();

        }

        [Test, Order(12)]
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
        public void Teardown()
        {
            if ((TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Failure)) ||
                (TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Error)))
            {
                string problem = TestContext.CurrentContext.Result.Message;
                Logger.screenshot_FAIL(problem);
                Console.WriteLine();
            }
            Logger.EndTest();
        }
    }
}
