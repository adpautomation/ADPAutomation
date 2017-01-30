using System;
using ADP_Tests.resources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_Tests.ADP_PageFactory;

namespace ADP_Tests.ADP_PageFactory_TotalSolutions
{
    public class AdpLobby : AdpAbstractPageFactory
    {
        private By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//span[@class='user-menu-name']")]
        private IWebElement _headerAccountName;

        [FindsBy(How = How.XPath, Using = "//a[@ng-click='unimpersonate()']")]
        private IWebElement _unImpersonateButton;

        [FindsBy(How = How.XPath, Using = "//a[@ui-sref='admin.manageUsers']")]
        private IWebElement _admin;

        [FindsBy(How = How.XPath, Using  = "//h3[.='Welcome to ADP TotalSource']")]
        private IWebElement _welcomeToAdp;

        [FindsBy(How = How.Id, Using = "icon-lobby-eeoc")]
        private IWebElement _eeoc;

        [FindsBy(How = How.Id, Using = "icon-lobby-voe")]
        private IWebElement _voe;

        [FindsBy(How = How.Id, Using = "icon-lobby-workbench-old-app")]
        private IWebElement _workBench;

        [FindsBy(How = How.Id, Using = "icon-lobby-wbsettings-old-app")]
        private IWebElement _wbSettings;

        [FindsBy(How = How.Id, Using = "icon-lobby-benefitbob")]
        private IWebElement _benefitsBob;

        [FindsBy(How = How.Id, Using = "icon-lobby-cat")]
        private IWebElement _clientAdminTool;

        [FindsBy(How = How.Id, Using = "icon-lobby-wizard")]
        private IWebElement _acaWizard;

        [FindsBy(How = How.Id, Using = "icon-lobby-bret")]
        private IWebElement _bret;

        [FindsBy(How = How.Id, Using = "icon-lobby-ratesheets")]
        private IWebElement _rateSheets;

        [FindsBy(How = How.Id, Using = "icon-lobby-videosettings")]
        private IWebElement _videoManagement;

        [FindsBy(How = How.Id, Using = "icon-lobby-mep")]
        private IWebElement _mep;

        [FindsBy(How = How.Id, Using = "icon-lobby-mep-report")]
        private IWebElement _mepReports;

        public AdpLobby() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleText(_welcomeToAdp, "Welcome to ADP TotalSource");
            Logger.screenshot_PASS("Lobby page successfully opens");
        }

        public enum Tile
        {
            Eeoc, Voe, WorkBench, WbSettings, BenefitsBob, ClientAdminTool, AcaWizard, Bret, RateSheets, VideoManagement, Mep, MepReports, Admin
        }

        public void Navigate(Tile tile)
        {
            switch (tile)
            {
                case Tile.Eeoc:
                    Click(_eeoc);
                    Logger.Info("EEOC is clicked at the Lobby page");
                    break;
                case Tile.Voe:
                    Click(_voe);
                    Logger.Info("VOE is clicked at the Lobby page");
                    break;
                case Tile.WorkBench:
                    Click(_workBench);
                    Logger.Info("WorkBench is clicked at the Lobby page");
                    break;
                case Tile.BenefitsBob:
                    Click(_benefitsBob);
                    Logger.Info("Benefits BOB is clicked at the Lobby page");
                    break;
                case Tile.ClientAdminTool:
                    Click(_clientAdminTool);
                    Logger.Info("Client Admin Tool is clicked at the Lobby page");
                    break;
                case Tile.AcaWizard:
                    Click(_acaWizard);
                    Logger.Info("ACA Wizard is clicked at the Lobby page");
                    break;
                case Tile.Bret:
                    Click(_bret);
                    Logger.Info("BRET is clicked at the Lobby page");
                    break;
                case Tile.RateSheets:
                    Click(_rateSheets);
                    Logger.Info("Rate sheets is clicked at the Lobby page");
                    break;
                case Tile.VideoManagement:
                    Click(_videoManagement);
                    Logger.Info("Video Management is clicked at the Lobby page");
                    break;
                case Tile.Mep:
                    Click(_mep);
                    Logger.Info("401K MEP is clicked at the Lobby page");
                    break;
                case Tile.MepReports:
                    Click(_mepReports);
                    Logger.Info("MEP Reports is clicked at the Lobby page");
                    break;
                case Tile.Admin:
                    Click(_headerAccountName);
                    Click(_admin);
                    Logger.Info("Admin is clicked at the Lobby page");
                    break;
            }     
        }

        public void VerifyImpersonatedUserName()
        {
            try
            {
                WaitInvisibleElement(_loadingBar);
                StringAssert.AreEqualIgnoringCase(TestCredentialsWindow.ImpersonatedUser, _headerAccountName.Text);
                Logger.screenshot_PASS("Impersonate test has passed");
            }
            catch (AssertionException ex)
            {
                Logger.screenshot_FAIL("Impersonate test has failed");
                Console.WriteLine(ex.ToString());
            }
            Click(_headerAccountName);
            Click(_unImpersonateButton);
        }
    }
}
