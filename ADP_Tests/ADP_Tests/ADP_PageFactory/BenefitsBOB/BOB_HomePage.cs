using ADP_SeleniumFramework.ADP_PageFactory;
using ADP_SeleniumFramework.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ADP_SeleniumFramework.ADP_PageFactory.BenefitsBOB
{
    public class BenefitsBOB_HomePage : ADP_AbstractPageFactory
    {
        private By title = By.XPath("//div[@class='layout-align-start-center layout-row']//a[@class='md-primary md-hue-1 md-button ng-scope md-ink-ripple']");

        [FindsBy(How = How.XPath, Using = ("//div[@class='key-value-edit']//button[@class = 'btn edit-button pull-left']"))]
        private IWebElement clear;

        [FindsBy(How = How.XPath, Using = ("//div[@class='col-xs-4 pb-10 text-center']//a[.='Clear All']"))]
        private IWebElement clearAll;

        [FindsBy(How = How.XPath, Using = "//div[@class='key-select']//button[@class='btn key-select ng-binding']")]
        private IWebElement filterBy_button;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Revenue Centers']")]
        private IWebElement filterBy_RevenueCenters;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Markets']")]
        private IWebElement filterBy_Markets;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='System']")]
        private IWebElement filterBy_System;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Products']")]
        private IWebElement filterBy_Products;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='HRBP']")]
        private IWebElement filterBy_HRBP;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='CRE']")]
        private IWebElement filterBy_CRE;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Providers']")]
        private IWebElement filterBy_Providers;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='BSR']")]
        private IWebElement filterBy_BSR;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='HWE']")]
        private IWebElement filterBy_HWE;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='OE Owner']")]
        private IWebElement filterBy_OE_Owner;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Ops Owner']")]
        private IWebElement filterBy_Ops_Owner;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='In OE]")]
        private IWebElement filterBy_In_OE;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Client Status']")]
        private IWebElement filterBy_Client_Status;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='OE Renewal Status']")]
        private IWebElement filterBy_OE_Renewal_Status;

        [FindsBy(How = How.XPath, Using = "//div[@class='value-select']//button[@type='button']")]
        private IWebElement filterBy_dropDown;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Atlanta')]]")]
        private IWebElement revenueCenter_Atlanta;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Auburn Hills')]]")]
        private IWebElement revenueCenter_Auburn_Hills;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Austin')]]")]
        private IWebElement revenueCenter_Austin;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Boston')]]")]
        private IWebElement revenueCenter_Boston;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Charlotte')]]")]
        private IWebElement revenueCenter_Charlotte;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Chicago')]]")]
        private IWebElement revenueCenter_Chicago;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Cleveland')]]")]
        private IWebElement revenueCenter_Cleveland;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Dallas')]]")]
        private IWebElement revenueCenter_Dallas;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Denver')]]")]
        private IWebElement revenueCenter_Denver;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Des Moines')]]")]
        private IWebElement revenueCenter_Des_Moines;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' El Paso')]]")]
        private IWebElement revenueCenter_El_Paso;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Ft. Lauderdale')]]")]
        private IWebElement revenueCenter_Ft_Lauderdale;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Grand Junction')]]")]
        private IWebElement revenueCenter_Grand_Junction;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Grand Rapids')]]")]
        private IWebElement revenueCenter_Grand_Rapids;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Green Bay')]]")]
        private IWebElement revenueCenter_Green_Bay;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Houston')]]")]
        private IWebElement revenueCenter_Houston;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Indianapolis')]]")]
        private IWebElement revenueCenter_Indianapolis;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Jacksonville')]]")]
        private IWebElement revenueCenter_Jacksonville;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Kansas City')]]")]
        private IWebElement revenueCenter_Kansas_City;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Las Vegas')]]")]
        private IWebElement revenueCenter_Las_Vegas;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Los Angeles')]]")]
        private IWebElement revenueCenter_Los_Angeles;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Louisville')]]")]
        private IWebElement revenueCenter_Lousville;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Madison')]]")]
        private IWebElement revenueCenter_Madison;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Manchester')]]")]
        private IWebElement revenueCenter_Manchester;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Melville, LI')]]")]
        private IWebElement revenueCenter_Melville;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Metro Detroit')]]")]
        private IWebElement revenueCenter_Metro_Detroit;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Miami')]]")]
        private IWebElement revenueCenter_Miami;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Milwaukee')]]")]
        private IWebElement revenueCenter_Milwaukee;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Minneapolis')]]")]
        private IWebElement revenueCenter_Minneapolis;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' New Jersey')]]")]
        private IWebElement revenueCenter_New_Jersey;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[31]")]
        private IWebElement revenueCenter_New_Orleans;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[32]")]
        private IWebElement revenueCenter_New_York;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[33]")]
        private IWebElement revenueCenter_Novi;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[34]")]
        private IWebElement revenueCenter_Oklahoma;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[35]")]
        private IWebElement revenueCenter_Omaha;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[36]")]
        private IWebElement revenueCenter_Orange;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[37]")]
        private IWebElement revenueCenter_Orlando;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[38]")]
        private IWebElement revenueCenter_Philadelhia;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[39]")]
        private IWebElement revenueCenter_Phoenix;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[40]")]
        private IWebElement revenueCenter_Pittsburg;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[41]")]
        private IWebElement revenueCenter_Portland;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[42]")]
        private IWebElement revenueCenter_Prime;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[43]")]
        private IWebElement revenueCenter_Prime_Central;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[44]")]
        private IWebElement revenueCenter_Prime_MidAtlantic;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[45]")]
        private IWebElement revenueCenter_Prime_South;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[46]")]
        private IWebElement revenueCenter_Prime_WestCentral;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[47]")]
        private IWebElement revenueCenter_Princeton;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[48]")]
        private IWebElement revenueCenter_Raleigh;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[49]")]
        private IWebElement revenueCenter_Richmond;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[50]")]
        private IWebElement revenueCenter_Rochester;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[51]")]
        private IWebElement revenueCenter_Rockville;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[52]")]
        private IWebElement revenueCenter_Sacramento;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[53]")]
        private IWebElement revenueCenter_SaltLakeCity;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[54]")]
        private IWebElement revenueCenter_San_Antonio;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[55]")]
        private IWebElement revenueCenter_San_Diego;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[56]")]
        private IWebElement revenueCenter_San_Francisco;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[57]")]
        private IWebElement revenueCenter_Seattle;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[58]")]
        private IWebElement revenueCenter_St_Louis;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[59]")]
        private IWebElement revenueCenter_Tampa;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[60]")]
        private IWebElement revenueCenter_Tennessee;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[61]")]
        private IWebElement revenueCenter_Upstate_NY;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[62]")]
        private IWebElement revenueCenter_Washington_DC;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[63]")]
        private IWebElement revenueCenter_West_Palm;





        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[1]")]
        private IWebElement companyName_1;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[2]")]
        private IWebElement companyName_2;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[3]")]
        private IWebElement companyName_3;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[4]")]
        private IWebElement companyName_4;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[5]")]
        private IWebElement companyName_5;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[6]")]
        private IWebElement companyName_6;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[7]")]
        private IWebElement companyName_7;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[8]")]
        private IWebElement companyName_8;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[9]")]
        private IWebElement companyName_9;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[10]")]
        private IWebElement companyName_10;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[11]")]
        private IWebElement companyName_11;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[12]")]
        private IWebElement companyName_12;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[13]")]
        private IWebElement companyName_13;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[14]")]
        private IWebElement companyName_14;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[15]")]
        private IWebElement companyName_15;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[16]")]
        private IWebElement companyName_16;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[17]")]
        private IWebElement companyName_17;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[18]")]
        private IWebElement companyName_18;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[19]")]
        private IWebElement companyName_19;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[20]")]
        private IWebElement companyName_20;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[21]")]
        private IWebElement companyName_21;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[22]")]
        private IWebElement companyName_22;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[23]")]
        private IWebElement companyName_23;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[24]")]
        private IWebElement companyName_24;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[25]")]
        private IWebElement companyName_25;

        [FindsBy(How = How.XPath, Using = "(//div[@class='bob-row ng-scope layout-row']//a[@class='font-size-18 mb-6 ng-binding'])[26]")]
        private IWebElement companyName_26;

        private By parentDetails = By.XPath("(//span[.='Parent Details'])[1]");

        public BenefitsBOB_HomePage() : base()
        {
            waitVisibleElement(title);
        }

        public void loopThroughCompanies()
        {
            clear.Click();
            clearAll.Click();
            standBy(2);
            newTab(companyName_1);
            BOB_ParentDetails pd = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_2);
            BOB_ParentDetails pd2 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_3);
            BOB_ParentDetails pd3 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_4);
            BOB_ParentDetails pd4 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_5);
            BOB_ParentDetails pd5 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_6);
            BOB_ParentDetails pd6 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_7);
            BOB_ParentDetails pd7 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_8);
            BOB_ParentDetails pd8 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_9);
            BOB_ParentDetails pd9 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_10);
            BOB_ParentDetails pd10 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_11);
            BOB_ParentDetails pd11 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_12);
            BOB_ParentDetails pd12 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_13);
            BOB_ParentDetails pd13 = new BOB_ParentDetails();
            pd.headerVerification();
            scrollDown(companyName_13);
            newTab(companyName_1);
            BOB_ParentDetails pd14 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_2);
            BOB_ParentDetails pd15 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_3);
            BOB_ParentDetails pd16 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_4);
            BOB_ParentDetails pd17 = new BOB_ParentDetails();
            pd.headerVerification();
            scrollDown(companyName_4);
            newTab(companyName_1);
            BOB_ParentDetails pd18 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_2);
            BOB_ParentDetails pd19 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_3);
            BOB_ParentDetails pd20 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_4);
            BOB_ParentDetails pd21 = new BOB_ParentDetails();
            pd.headerVerification();
            scrollDown(companyName_4);
            newTab(companyName_1);
            BOB_ParentDetails pd22 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_2);
            BOB_ParentDetails pd23 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_3);
            BOB_ParentDetails pd24 = new BOB_ParentDetails();
            pd.headerVerification();
            newTab(companyName_4);
            BOB_ParentDetails pd25 = new BOB_ParentDetails();
            pd.headerVerification();
            scrollDown(companyName_4);
            newTab(companyName_1);
            BOB_ParentDetails pd26 = new BOB_ParentDetails();
            pd.headerVerification();



            //       hoverOverElement(companyName, );
            //      scrollDown(companyName);


        }

        public void verifyFilters()
        {
            click(clear);
            click(clearAll);
            click(filterBy_button);
            click(filterBy_RevenueCenters);
            click(filterBy_dropDown);
            try
            {
                isElementDisplayed(revenueCenter_Atlanta, "");
                isElementDisplayed(revenueCenter_Auburn_Hills, "");
                isElementDisplayed(revenueCenter_Austin, "");
                isElementDisplayed(revenueCenter_Boston, "");
                isElementDisplayed(revenueCenter_Charlotte, "");
                isElementDisplayed(revenueCenter_Chicago, "");
                isElementDisplayed(revenueCenter_Cleveland, "");
                isElementDisplayed(revenueCenter_Dallas, "");
                isElementDisplayed(revenueCenter_Denver, "");
                isElementDisplayed(revenueCenter_Des_Moines, "");
                isElementDisplayed(revenueCenter_El_Paso, "");
                isElementDisplayed(revenueCenter_Ft_Lauderdale, "");
                isElementDisplayed(revenueCenter_Grand_Rapids, "");
                isElementDisplayed(revenueCenter_Green_Bay, "");
                isElementDisplayed(revenueCenter_Houston, "");
                isElementDisplayed(revenueCenter_Indianapolis, "");
                isElementDisplayed(revenueCenter_Jacksonville, "");
                isElementDisplayed(revenueCenter_Kansas_City, "");
                isElementDisplayed(revenueCenter_Las_Vegas, "");
                isElementDisplayed(revenueCenter_Los_Angeles, "");
                isElementDisplayed(revenueCenter_Lousville, "");
                isElementDisplayed(revenueCenter_Madison, "");
                isElementDisplayed(revenueCenter_Manchester, "");
                isElementDisplayed(revenueCenter_Melville, "");
                isElementDisplayed(revenueCenter_Metro_Detroit, "");
                isElementDisplayed(revenueCenter_Miami, "");
                isElementDisplayed(revenueCenter_Milwaukee, "");
                isElementDisplayed(revenueCenter_Minneapolis, "");
                isElementDisplayed(revenueCenter_New_Jersey, "");
                isElementDisplayed(revenueCenter_New_Orleans, "");
                isElementDisplayed(revenueCenter_New_York, "");
                isElementDisplayed(revenueCenter_Novi, "");
                isElementDisplayed(revenueCenter_Oklahoma, "");
                isElementDisplayed(revenueCenter_Omaha, "");
                isElementDisplayed(revenueCenter_Orange, "");
                isElementDisplayed(revenueCenter_Orlando, "");
                isElementDisplayed(revenueCenter_Philadelhia, "");
                isElementDisplayed(revenueCenter_Phoenix, "");
                isElementDisplayed(revenueCenter_Pittsburg, "");
                isElementDisplayed(revenueCenter_Portland, "");
                isElementDisplayed(revenueCenter_Prime, "");
                isElementDisplayed(revenueCenter_Prime_Central, "");
                isElementDisplayed(revenueCenter_Prime_MidAtlantic, "");
                isElementDisplayed(revenueCenter_Prime_South, "");
                isElementDisplayed(revenueCenter_Prime_WestCentral, "");
                isElementDisplayed(revenueCenter_Princeton, "");
                isElementDisplayed(revenueCenter_Raleigh, "");
                isElementDisplayed(revenueCenter_Richmond, "");
                isElementDisplayed(revenueCenter_Rochester, "");
                isElementDisplayed(revenueCenter_Rockville, "");
                isElementDisplayed(revenueCenter_Sacramento, "");
                isElementDisplayed(revenueCenter_SaltLakeCity, "");
                isElementDisplayed(revenueCenter_San_Antonio, "");
                isElementDisplayed(revenueCenter_San_Diego, "");
                isElementDisplayed(revenueCenter_San_Francisco, "");
                isElementDisplayed(revenueCenter_Seattle, "");
                isElementDisplayed(revenueCenter_St_Louis, "");
                isElementDisplayed(revenueCenter_Tampa, "");
                isElementDisplayed(revenueCenter_Tennessee, "");
                isElementDisplayed(revenueCenter_Upstate_NY, "");
                isElementDisplayed(revenueCenter_Washington_DC, "");
                isElementDisplayed(revenueCenter_West_Palm, "");
                Logger.screenshot_PASS("All the revenue centers are listed correctly");
            }
            catch (NoSuchElementException ex)
            {
                Logger.screenshot_FAIL("Revenue Centers listed incorrectly. Missing" + " " + ex.Message);
            }
            click(filterBy_button);
            click(filterBy_Markets);
            click(filterBy_dropDown);


        }
    }
}
