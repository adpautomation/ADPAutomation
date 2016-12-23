using ADP_SeleniumFramework.resources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace ADP_SeleniumFramework.ADP_PageFactory
{
    public class ADP_Lobby : ADP_AbstractPageFactory
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='user-menu-name']")]
        private IWebElement headerAccountName;

        [FindsBy(How = How.XPath, Using = "//a[@ui-sref='admin.manageUsers']")]
        private IWebElement Admin;

        [FindsBy(How = How.XPath, Using  = "//h2[.='Welcome to ADP TotalSource']")]
        private IWebElement WelcomeToADP;

        [FindsBy(How = How.Id, Using = "icon-lobby-eeoc")]
        private IWebElement EEOC;

        [FindsBy(How = How.Id, Using = "icon-lobby-voe")]
        private IWebElement VOE;

        [FindsBy(How = How.Id, Using = "icon-lobby-workbench-old-app")]
        private IWebElement WorkBench;

        [FindsBy(How = How.Id, Using = "icon-lobby-wbsettings-old-app")]
        private IWebElement WB_Settings;

        [FindsBy(How = How.Id, Using = "icon-lobby-benefitbob")]
        private IWebElement Benefits_BOB;

        [FindsBy(How = How.Id, Using = "icon-lobby-cat")]
        private IWebElement ClientAdminTool;

        [FindsBy(How = How.Id, Using = "icon-lobby-wizard")]
        private IWebElement ACA_Wizard;

        [FindsBy(How = How.Id, Using = "icon-lobby-bret")]
        private IWebElement BRET;

        [FindsBy(How = How.Id, Using = "icon-lobby-ratesheets")]
        private IWebElement RateSheets;

        [FindsBy(How = How.Id, Using = "icon-lobby-videosettings")]
        private IWebElement VideoManagement;

        [FindsBy(How = How.Id, Using = "icon-lobby-mep")]
        private IWebElement MEP;

        [FindsBy(How = How.Id, Using = "icon-lobby-mep-report")]
        private IWebElement MEP_Reports;

        public ADP_Lobby() : base()
        {
            waitVisibleText(WelcomeToADP, "Welcome to ADP TotalSource");
        }

        public enum Tile
        {
            EEOC, VOE, WorkBench, WB_Settings, Benefits_BOB, ClientAdminTool, ACA_Wizard, BRET, RateSheets, VideoManagement, MEP, MEP_Reports, Admin
        }

        public void navigate(Tile tile)
        {
            switch (tile)
            {
                case Tile.EEOC:
                    click(EEOC);
                    Logger.INFO("EEOC is clicked at the Lobby page");
                    break;
                case Tile.VOE:
                    click(VOE);
                    Logger.INFO("VOE is clicked at the Lobby page");
                    break;
                case Tile.WorkBench:
                    click(WorkBench);
                    Logger.INFO("WorkBench is clicked at the Lobby page");
                    break;
                case Tile.Benefits_BOB:
                    click(Benefits_BOB);
                    Logger.INFO("Benefits BOB is clicked at the Lobby page");
                    break;
                case Tile.ClientAdminTool:
                    click(ClientAdminTool);
                    Logger.INFO("Client Admin Tool is clicked at the Lobby page");
                    break;
                case Tile.ACA_Wizard:
                    click(ACA_Wizard);
                    Logger.INFO("ACA Wizard is clicked at the Lobby page");
                    break;
                case Tile.BRET:
                    click(BRET);
                    Logger.INFO("BRET is clicked at the Lobby page");
                    break;
                case Tile.RateSheets:
                    click(RateSheets);
                    Logger.INFO("Rate sheets is clicked at the Lobby page");
                    break;
                case Tile.VideoManagement:
                    click(VideoManagement);
                    Logger.INFO("Video Management is clicked at the Lobby page");
                    break;
                case Tile.MEP:
                    click(MEP);
                    Logger.INFO("401K MEP is clicked at the Lobby page");
                    break;
                case Tile.MEP_Reports:
                    click(MEP_Reports);
                    Logger.INFO("MEP Reports is clicked at the Lobby page");
                    break;
                case Tile.Admin:
                    click(headerAccountName);
                    click(Admin);
                    break;
            }     
        }

        public void verifyImpersonatedUserName()
        {
            try
            {
                Assert.AreSame("Felipe Adams", headerAccountName.Text);
                Logger.screenshot_PASS("Impersonate test has passed");
            }
            catch (AssertionException ex)
            {
                Logger.screenshot_FAIL("Impersonate test has failed");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
