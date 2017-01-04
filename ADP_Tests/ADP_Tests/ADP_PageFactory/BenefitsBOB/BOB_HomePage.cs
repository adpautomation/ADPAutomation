using ADP_SeleniumFramework.resources;
using ADP_Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_SeleniumFramework.ADP_PageFactory.BenefitsBOB
{
    public class BOB_HomePage : ADP_AbstractPageFactory
    {
        private By title = By.XPath("//div[@class='layout-align-start-center layout-row']//a[@class='md-primary md-hue-1 md-button ng-scope md-ink-ripple']");

        private By loading_bar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = ("//div[@class='col-xs-4 pb-10 text-center']//a[.='Clear All']"))]
        private IWebElement clearAll;

        [FindsBy(How = How.XPath, Using = ("//div[@class='key-value-edit']//button[@class = 'btn edit-button pull-left']"))]
        private IWebElement clear;

        [FindsBy(How = How.XPath, Using = ("//a[@class='font-size-18 mb-6 ng-binding']"))]
        private IWebElement companyName;

        [FindsBy(How = How.XPath, Using = ("//input[@name='paygroup']"))]
        private IWebElement paygroupCodeOrName_field;

        [FindsBy(How = How.XPath, Using = ("//button[@ng-click='findPaygroup()']"))]
        private IWebElement search_icon;

        [FindsBy(How = How.XPath, Using = ("//button[.='BOB']"))]
        private IWebElement BOB_button;

        [FindsBy(How = How.XPath, Using = ("//button[.='OE']"))]
        private IWebElement OE_button;

        [FindsBy(How = How.XPath, Using = ("//button[@aria-label='Save Results']"))]
        private IWebElement saveResults_button;

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

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='In OE']")]
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

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Central')]]")]
        private IWebElement market_Central;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Mid Atlantic')]]")]
        private IWebElement market_MidAtlantic;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Northeast')]]")]
        private IWebElement market_Northeast;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'South')]]")]
        private IWebElement market_South;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'West')]]")]
        private IWebElement market_West;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'EV4')]]")]
        private IWebElement system_EV4;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'WFN')]]")]
        private IWebElement system_WFN;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Exact Match')]]")]
        private IWebElement products_ExactMatch;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Medical')]]")]
        private IWebElement products_Medical;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Dental')]]")]
        private IWebElement products_Dental;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Vision')]]")]
        private IWebElement products_Vision;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Life')]]")]
        private IWebElement products_Life;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'STD')]]")]
        private IWebElement products_STD;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'LTD')]]")]
        private IWebElement products_LTD;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'HSA')]]")]
        private IWebElement products_HSA;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'FSA')]]")]
        private IWebElement products_FSA;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'401k')]]")]
        private IWebElement products_401K;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Yes')]]")]
        private IWebElement inOE_YES;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'No')]]")]
        private IWebElement inOE_NO;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Active')]]")]
        private IWebElement clientStatus_Active;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Future Start')]]")]
        private IWebElement clientStatus_FutureStart;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Future Term')]]")]
        private IWebElement clientStatus_FutureTerm;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Terminated')]]")]
        private IWebElement clientStatus_Terminated;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Untouched')]]")]
        private IWebElement renewalStatus_Untouched;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'In Progress')]]")]
        private IWebElement renewalStatus_inProgress;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Client Ready')]]")]
        private IWebElement renewalStatus_ClientReady;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Signed CBE')]]")]
        private IWebElement renewalStatus_SignedCBE;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Submission In Progress')]]")]
        private IWebElement renewalStatus_SubmissionInProgress;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Client Review')]]")]
        private IWebElement renewalStatus_ClientReview;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Resubmission Required')]]")]
        private IWebElement renewalStatus_ResubmissionRequired;



        private By parentDetails = By.XPath("(//span[.='Parent Details'])[1]");

        public BOB_HomePage() : base()
        {
            waitVisibleElement(title);
        }

        public void verifyContents()
        {
            try
            {
                isElementDisplayed(paygroupCodeOrName_field, "");
                isElementDisplayed(search_icon, "");
                isElementDisplayed(filterBy_button, "");
                isElementDisplayed(saveResults_button, "");
                isElementDisplayed(BOB_button, "");
                isElementDisplayed(OE_button, "");
                Logger.screenshot_PASS("All the header elements are displayed correctly");
            }catch(NoSuchElementException ex)
            {
                Logger.FAIL("Not all the page elements are displayed on the page. Missing" + " " + ex.Message);
            }
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
            try
            {
                isElementDisplayed(market_Central, "");
                isElementDisplayed(market_MidAtlantic, "");
                isElementDisplayed(market_Northeast, "");
                isElementDisplayed(market_South, "");
                isElementDisplayed(market_West, "");
                Logger.screenshot_PASS("All the markets are listed correctly");
            }
            catch(NoSuchElementException ex)
            {
                Logger.screenshot_FAIL("Markets listed incorrectly. Missing" + " " + ex.Message);
            }
            click(filterBy_button);
            click(filterBy_System);
            click(filterBy_dropDown);
            try
            {
                isElementDisplayed(system_EV4, "");
                isElementDisplayed(system_WFN, "");
                Logger.screenshot_PASS("All the systems are displayed correctly");
            }catch(NoSuchElementException ex)
            {
                Logger.screenshot_FAIL("Systems listed incorrectly. Missing" + " " + ex.Message);
            }
            click(filterBy_button);
            click(filterBy_Products);
            click(filterBy_dropDown);
            try
            {
                isElementDisplayed(products_ExactMatch, "");
                isElementDisplayed(products_Medical, "");
                isElementDisplayed(products_Dental, "");
                isElementDisplayed(products_Vision, "");
                isElementDisplayed(products_Life, "");
                isElementDisplayed(products_STD, "");
                isElementDisplayed(products_LTD, "");
                isElementDisplayed(products_HSA, "");
                isElementDisplayed(products_FSA, "");
                isElementDisplayed(products_401K, "");
                Logger.screenshot_PASS("All the products are listed correctly");
            }
            catch (NoSuchElementException ex)
            {
                Logger.screenshot_FAIL("Products listed incorrectly. Missing" + " " + ex.Message);
            }
            click(filterBy_button);
            click(filterBy_In_OE);
            click(filterBy_dropDown);
            try
            {
                isElementDisplayed(inOE_YES, "");
                isElementDisplayed(inOE_NO, "");
                Logger.screenshot_PASS("In OE items are displayed correctly");
            }
            catch (NoSuchElementException ex)
            {
                Logger.screenshot_FAIL("In OE items listed incorrectly. Missing" + " " + ex.Message);
            }
            click(filterBy_button);
            click(filterBy_Client_Status);
            click(filterBy_dropDown);
            try
            {
                isElementDisplayed(clientStatus_Active, "");
                isElementDisplayed(clientStatus_FutureStart, "");
                isElementDisplayed(clientStatus_FutureTerm, "");
                isElementDisplayed(clientStatus_Terminated, "");
                Logger.screenshot_PASS("All client statuses are displayed correctly");
            }
            catch (NoSuchElementException ex)
            {
                Logger.screenshot_FAIL("Client statuses listed incorrectly. Missing" + " " + ex.Message);
            }
            click(filterBy_button);
            click(filterBy_OE_Renewal_Status);
            click(filterBy_dropDown);
            try
            {
                isElementDisplayed(renewalStatus_Untouched, "");
                isElementDisplayed(renewalStatus_inProgress, "");
                isElementDisplayed(renewalStatus_ClientReady, "");
                isElementDisplayed(renewalStatus_ClientReview, "");
                isElementDisplayed(renewalStatus_SignedCBE, "");
                isElementDisplayed(renewalStatus_SubmissionInProgress, "");
                isElementDisplayed(renewalStatus_ResubmissionRequired, "");
                Logger.screenshot_PASS("All client renewal statuses are displayed correctly");
            }
            catch (NoSuchElementException ex)
            {
                Logger.screenshot_FAIL("Client renewal statuses listed incorrectly. Missing" + " " + ex.Message);
            }
        }
        public void navigateClientLevel()
        {
            waitInvisibleElement(loading_bar);
            click(paygroupCodeOrName_field);
            paygroupCodeOrName_field.SendKeys(SmokeTestWindow.validCompanyCode);
            click(search_icon);
            waitVisibleText(companyName, "");
            click(companyName);
        }
    }
}
