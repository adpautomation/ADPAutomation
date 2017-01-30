using System;
using ADP_Tests.ADPageFactory.TotalSolutions.BRET;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using ADP_Tests.ADP_PageFactory_TotalSolutions;

namespace ADP_Tests.tests
{
    [TestFixture]
    [Parallelizable]
    public class WfnSubmissionTest
    {
        [OneTimeSetUp]
        public void OneTimesetUp()
        {
            #region Open the window to insert test parameters 
            var info = new WFN_SubmissionInfo();
            info.TopMost = true;
            info.ShowDialog();
            var window = new TestCredentialsWindow();
            window.ShowDialog();
            #endregion
            #region Initializing remote web driver

            WebDriver.GetDriver(WebDriver.Initialize(WebDriver.Browser.Remote));

            #endregion
            #region Open predefined environment

            WebDriver.OpenUrl(TestCredentialsWindow.Env);

            #endregion 
            #region Start the reporter tool
            Logger.GetLogger("WFN Submission Test");
            #endregion
            #region Login to the Total Solutions
            var login = new Login();
            login.LoginToMobile();
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

        [Test]
        public void SubmitSolution()
        {
            Logger.StartLogger("BRET", "User should be able to submit the solution from Sales");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.Bret);
            var home = new BretHomePage();
            home.search_ERFP();
            var details = new BretDetails();
            details.NavigateToSolutions();
            var solutions = new BretSolutions();
            solutions.NavigateToClassesAndEmployeesSetUp();
            var setup = new BretClassesEmployeesSetupModal();
            setup.NavigateToAddClass();
            var addClass = new BretAddClass();
            setup.CloseModal();
            solutions.NavigateToModifySolution();
            var modify = new BretModifySolution();
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
