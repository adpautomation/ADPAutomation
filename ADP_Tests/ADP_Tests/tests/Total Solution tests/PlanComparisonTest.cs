using ADP_Tests.ADPageFactory.TotalSolutions.BenefitsBOB;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using NUnit.Framework;
using ADP_Tests.ADP_PageFactory_TotalSolutions;

namespace ADP_Tests.tests
{
    [TestFixture]
    [Parallelizable]
    public class PlanComparisonTest
    {

        [SetUp]
        public void SetUp()
        {
            TestCredentialsWindow window = new TestCredentialsWindow();
            window.ShowDialog();
            WebDriver.GetDriver(WebDriver.Initialize(WebDriver.Browser.Remote));
            WebDriver.OpenUrl(TestCredentialsWindow.Env);
            Login login = new Login();
            login.LoginToMobile();
            Logger.GetLogger("Plan Comparison Test");
        }

        [Test]
        public void UnmappedPlansTest()
        {
            Logger.StartLogger("Plan Comparison Test", "Medical plans should not contain UNMAPPED");
            AdpLobby lobby = new AdpLobby();
            lobby.Navigate(AdpLobby.Tile.BenefitsBob);
            BobHomePage home = new BobHomePage();
            home.NavigateClientLevel();
            BobParentDetails details = new BobParentDetails();
            details.NavigateSolutions();
            BobSolutions solutions = new BobSolutions();
            solutions.VerifyUnmapped();
       }
        [TearDown]
        public void Teardown()
        {
            Logger.EndTest();
            Logger.EndLogger();
        }
    }      
 }
