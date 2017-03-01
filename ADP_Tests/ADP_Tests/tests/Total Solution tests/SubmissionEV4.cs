using ADP_Tests.ADP_PageFactory_TotalSolutions;
using ADP_Tests.resources;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADPageFactory.TotalSolutions.BenefitsBOB;
using NUnit.Framework.Interfaces;

namespace ADP_Tests.tests.Total_Solution_tests
{
    public class SubmissionEV4
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
            Logger.GetLogger("EV4 Clients Submission Test");
            #endregion
            #region Login to the Total Solutions
            var login = new Login();
            login.LoginToMobile();
            #endregion     
        }

        [SetUp]
        public void SetUp()
        {
            WebDriver.OpenUrl(TestCredentialsWindow.Env);
        }

        [Test]
        public void submissionEV4Clients()
        {
            Logger.StartLogger("EV4 clients Submisson Test", "User should be able to verify that EV4 clients data is written over to Ebis");
            var lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.BenefitsBob);
            var bob = new BobHomePage();
            bob.NavigateClientLevel();
            var parent = new BobParentDetails();
            parent.NavigateSolutions();
            var solutions =  new BobSolutions();
            solutions.GetSubmittedPlans();
            solutions.GetRenewalClasses();
        }
        [TearDown]
        public void Teardown()
        {
            if ((TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Failure)) ||
                (TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Error)))
            {
                string problem = TestContext.CurrentContext.Result.Message;
                Logger.screenshot_FAIL(problem);
            }
            Logger.EndTest();
            Logger.EndLogger();
        }
    }
}
