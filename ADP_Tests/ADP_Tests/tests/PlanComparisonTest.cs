using ADP_SeleniumFramework.ADP_PageFactory;
using ADP_SeleniumFramework.resources;
using NUnit.Framework;
using ADP_Tests;
using ADP_SeleniumFramework.ADP_PageFactory.BenefitsBOB;

namespace ADP_SeleniumFramework.tests
{
    [TestFixture]
    [Parallelizable]
    public class PlanComparisonTest
    {

        [SetUp]
        public void setUp()
        {
            SmokeTestWindow window = new SmokeTestWindow();
            window.ShowDialog();
            webDriver.getDriver(webDriver.Initialize(webDriver.browser.Remote));
            webDriver.openURL(SmokeTestWindow.env);
            Login login = new Login();
            login.LoginToMobile();
            Logger.getLogger("Plan Comparison Test");
        }

        [Test]
        public void UnmappedPlansTest()
        {
            Logger.startLogger("Plan Comparison Test", "Medical plans should not contain UNMAPPED");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Benefits_BOB);
            BOB_HomePage home = new BOB_HomePage();
            home.navigateClientLevel();
            BOB_ParentDetails details = new BOB_ParentDetails();
            details.navigateSolutions();
            BOB_Solutions solutions = new BOB_Solutions();
            solutions.verifyUNMAPPED();
       }
        [TearDown]
        public void teardown()
        {
            Logger.endTest();
            Logger.endLogger();
        }
    }      
 }
