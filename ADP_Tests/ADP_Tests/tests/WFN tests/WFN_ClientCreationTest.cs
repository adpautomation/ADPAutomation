using System;
using ADP_Tests.ADPageFactory.WFN;
using ADP_Tests.resources;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace ADP_Tests.tests.WFN_tests
{
    public class WfnClientCreation
    {
        [OneTimeSetUp]
        public void OneTimesetUp()
        {

            #region Open the window to insert test parameters 
            var info = new WFN_CreateClientInfo();
            info.TopMost = true;
            info.ShowDialog();
            var window = new TestCredentialsWindow();
            window.ShowDialog();
            #endregion
            #region Initializing remote web driver

            WebDriver.GetDriver(WebDriver.Initialize(WebDriver.Browser.Remote));

            #endregion
            #region Open predefined environment

            WebDriver.OpenUrl(TestCredentialsWindow.WFN_Env);

            #endregion           
            #region Login to the Total Solutions
            var login = new Login();
            login.LoginToWFN();
            #endregion
            #region Start the reporter tool
            Logger.GetLogger("WFN Client Creation Test");
            #endregion
        }
        [OneTimeTearDown]
        public void AfterEntireTest()
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

        [Test]
        public void VerifyWfnClientCreation()
        {
            Logger.StartLogger("WFN Client Creation", "User should be able to create practitioner account");
            var home =  new WfnAdminHomePage();
            home.NavigateToClientCreation();
            var addClient = new WfnAddClient();
            addClient.AddClientId();
            addClient.ChooseProducts();
            addClient.ClientOptions();
            addClient.CreateCompany();
            addClient.CreateUser();
        }
    }
}
