﻿using ADP_SeleniumFramework.ADP_PageFactory;
using ADP_SeleniumFramework.resources;
using NUnit.Framework;
using OpenQA.Selenium;
using ADP_Tests;
using ADP_SeleniumFramework.ADP_PageFactory.BenefitsBOB;
using ADP_SeleniumFramework.ADP_PageFactory.EEOC;
using ADP_SeleniumFramework.ADP_PageFactory.VOE;
using ADP_SeleniumFramework.ADP_PageFactory.WorkBench;

namespace ADP_SeleniumFramework.tests
{
    [TestFixture]
    public class SmokeTest
    {
        [OneTimeSetUp]
        public void OneTimesetUp()
        {
            SmokeTestWindow window = new SmokeTestWindow();
            window.ShowDialog();
            webDriver.getDriver(webDriver.Initialize(webDriver.browser.Remote));
            webDriver.openURL(SmokeTestWindow.env);
            Login login = new Login();
            login.LoginToMobile();
            Logger.getLogger("Smoke Test");
        }
        [OneTimeTearDown]
        public void afterEntireTest()
        {
            Logger.endLogger();
        }
        [SetUp]
        public void setUp()
        {
            webDriver.newTab();
            webDriver.openURL(SmokeTestWindow.env);
        }

        [Test, Order(1)]
        [Parallelizable]
        public void Impersonate()
        {
            Logger.startLogger("Impersonate User", "User should be able to impersonate another user");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Admin);
            ADP_Admin admin = new ADP_Admin();
            admin.ImpersonateUser();
            ADP_Lobby lobby2 = new ADP_Lobby();
            lobby2.verifyImpersonatedUserName();
        }

        [Test, Order(2)]
        [Parallelizable]
        public void EEOC()
        {
            Logger.startLogger("EEOC", "User should be able to open EEOC and see the result charts");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.EEOC);
            EEOC eeoc = new EEOC();
            eeoc.verifyContents();
        }

        [Test, Order(3)]
        [Parallelizable]
        public void VOE()
        {
            Logger.startLogger("Verification of Employment", "User should be able to access VOE and submit the form");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.VOE);
            VOE_Search voe_search = new VOE_Search();
            voe_search.search_ID();
            VOE_Results voe_results = new VOE_Results();
            voe_results.submit();
        }

        [Test, Order(4)]
        [Parallelizable]
        public void WorkBench()
        {
            Logger.startLogger("WorkBench", "User should be able to create an activity");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.WorkBench);
            WorkBench_Lobby wrklobby = new WorkBench_Lobby();
            wrklobby.navegateToLobbyPage();
        }

        [Test, Order(5)]
        [Parallelizable]
        public void BOB_ParentLookUp()
        {
            Logger.startLogger("BOB Home Page", "User should be able to open BOB LookUp page and apply different filters");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Benefits_BOB);
            BOB_HomePage home = new BOB_HomePage();
            home.verifyContents();
            home.verifyFilters();
            home.navigateClientLevel();
        }

        [Test, Order(6)]
        [Parallelizable]
        public void BOB_ParentSummary()
        {
            Logger.startLogger("BOB Parent Page", "User should be able to download Roster and WSE Presentation");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Benefits_BOB);
            BOB_HomePage home = new BOB_HomePage();
            home.navigateClientLevel();
            BOB_ParentDetails details = new BOB_ParentDetails();
            details.verifyContents();
            details.download_WSE_Presentation();
            details.download_Roster();
        }

        [Test, Order(7)]
        [Parallelizable]
        public void BOB_Solutions()
        {
            Logger.startLogger("BOB Solutions", "User should be able to navigate to Solutions page");
            ADP_Lobby lobby = new ADP_Lobby();
            lobby.navigate(ADP_Lobby.Tile.Benefits_BOB);
            BOB_HomePage home = new BOB_HomePage();
            home.navigateClientLevel();
            BOB_ParentDetails details = new BOB_ParentDetails();
            details.navigateSolutions();
            BOB_Solutions solutions = new BOB_Solutions();
            solutions.verifyContents();
        }

        [Test, Order(8)]
        [Parallelizable]
        public void BOB_UnmappedPlans()
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
        [Parallelizable]
        public void teardown()
        {
            webDriver.closeTab();
            Logger.endTest();
        }


    }
}
