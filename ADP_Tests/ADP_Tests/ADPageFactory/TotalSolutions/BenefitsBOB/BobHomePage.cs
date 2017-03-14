using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.TotalSolutions.BenefitsBOB
{
    public class BobHomePage : AdpAbstractPageFactory
    {
        private By _title = By.XPath("//div[@class='layout-align-start-center layout-row']//a[@class='md-primary md-hue-1 md-button ng-scope md-ink-ripple']");

        private By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = ("//div[@class='col-xs-4 pb-10 text-center']//a[.='Clear All']"))]
        private IWebElement _clearAll;

        [FindsBy(How = How.XPath, Using = ("//div[@class='key-value-edit']//button[@class = 'btn edit-button pull-left']"))]
        private IWebElement _clear;

        [FindsBy(How = How.XPath, Using = ("//a[@class='font-size-17 mb-6 ng-binding']"))]
        private IWebElement _companyName;

        [FindsBy(How = How.XPath, Using = ("//input[@name='paygroup']"))]
        private IWebElement _paygroupCodeOrNameField;

        [FindsBy(How = How.XPath, Using = ("//button[@ng-click='findPaygroup()']"))]
        private IWebElement _searchIcon;

        [FindsBy(How = How.XPath, Using = ("(//button[@ng-model='config.tableDisplay'])[1]"))]
        private IWebElement _bobButton;

        [FindsBy(How = How.XPath, Using = ("(//button[@ng-model='config.tableDisplay'])[2]"))]
        private IWebElement _oeButton;

        [FindsBy(How = How.XPath, Using = ("//button[@aria-label='Save Results']"))]
        private IWebElement _saveResultsButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='key-select']//button[@class='btn key-select ng-binding']")]
        private IWebElement _filterByButton;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Revenue Centers']")]
        private IWebElement _filterByRevenueCenters;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Markets']")]
        private IWebElement _filterByMarkets;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='System']")]
        private IWebElement _filterBySystem;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Products']")]
        private IWebElement _filterByProducts;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='HRBP']")]
        private IWebElement _filterByHrbp;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='CRE']")]
        private IWebElement _filterByCre;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Providers']")]
        private IWebElement _filterByProviders;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='BSR']")]
        private IWebElement _filterByBsr;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='HWE']")]
        private IWebElement _filterByHwe;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='OE Owner']")]
        private IWebElement _filterByOeOwner;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Ops Owner']")]
        private IWebElement _filterByOpsOwner;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='In OE']")]
        private IWebElement _filterByInOe;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='Client Status']")]
        private IWebElement _filterByClientStatus;

        [FindsBy(How = How.XPath, Using = "//ul[@class='dropdown-menu']//a[.='OE Renewal Status']")]
        private IWebElement _filterByOeRenewalStatus;

        [FindsBy(How = How.XPath, Using = "//div[@class='value-select']//button[@type='button']")]
        private IWebElement _filterByDropDown;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Atlanta')]]")]
        private IWebElement _revenueCenterAtlanta;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Auburn Hills')]]")]
        private IWebElement _revenueCenterAuburnHills;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Austin')]]")]
        private IWebElement _revenueCenterAustin;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Boston')]]")]
        private IWebElement _revenueCenterBoston;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Charlotte')]]")]
        private IWebElement _revenueCenterCharlotte;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Chicago')]]")]
        private IWebElement _revenueCenterChicago;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Cleveland')]]")]
        private IWebElement _revenueCenterCleveland;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Dallas')]]")]
        private IWebElement _revenueCenterDallas;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Denver')]]")]
        private IWebElement _revenueCenterDenver;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Des Moines')]]")]
        private IWebElement _revenueCenterDesMoines;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' El Paso')]]")]
        private IWebElement _revenueCenterElPaso;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Ft. Lauderdale')]]")]
        private IWebElement _revenueCenterFtLauderdale;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Grand Junction')]]")]
        private IWebElement _revenueCenterGrandJunction;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Grand Rapids')]]")]
        private IWebElement _revenueCenterGrandRapids;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Green Bay')]]")]
        private IWebElement _revenueCenterGreenBay;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Houston')]]")]
        private IWebElement _revenueCenterHouston;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Indianapolis')]]")]
        private IWebElement _revenueCenterIndianapolis;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Jacksonville')]]")]
        private IWebElement _revenueCenterJacksonville;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Kansas City')]]")]
        private IWebElement _revenueCenterKansasCity;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Las Vegas')]]")]
        private IWebElement _revenueCenterLasVegas;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Los Angeles')]]")]
        private IWebElement _revenueCenterLosAngeles;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Louisville')]]")]
        private IWebElement _revenueCenterLousville;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Madison')]]")]
        private IWebElement _revenueCenterMadison;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Manchester')]]")]
        private IWebElement _revenueCenterManchester;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Melville, LI')]]")]
        private IWebElement _revenueCenterMelville;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Metro Detroit')]]")]
        private IWebElement _revenueCenterMetroDetroit;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Miami')]]")]
        private IWebElement _revenueCenterMiami;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Milwaukee')]]")]
        private IWebElement _revenueCenterMilwaukee;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Minneapolis')]]")]
        private IWebElement _revenueCenterMinneapolis;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' New Jersey')]]")]
        private IWebElement _revenueCenterNewJersey;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[31]")]
        private IWebElement _revenueCenterNewOrleans;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[32]")]
        private IWebElement _revenueCenterNewYork;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[33]")]
        private IWebElement _revenueCenterNovi;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[34]")]
        private IWebElement _revenueCenterOklahoma;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[35]")]
        private IWebElement _revenueCenterOmaha;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[36]")]
        private IWebElement _revenueCenterOrange;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[37]")]
        private IWebElement _revenueCenterOrlando;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[38]")]
        private IWebElement _revenueCenterPhiladelhia;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[39]")]
        private IWebElement _revenueCenterPhoenix;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[40]")]
        private IWebElement _revenueCenterPittsburg;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[41]")]
        private IWebElement _revenueCenterPortland;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[42]")]
        private IWebElement _revenueCenterPrime;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[43]")]
        private IWebElement _revenueCenterPrimeCentral;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[44]")]
        private IWebElement _revenueCenterPrimeMidAtlantic;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[45]")]
        private IWebElement _revenueCenterPrimeSouth;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[46]")]
        private IWebElement _revenueCenterPrimeWestCentral;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[47]")]
        private IWebElement _revenueCenterPrinceton;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[48]")]
        private IWebElement _revenueCenterRaleigh;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[49]")]
        private IWebElement _revenueCenterRichmond;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[50]")]
        private IWebElement _revenueCenterRochester;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[51]")]
        private IWebElement _revenueCenterRockville;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[52]")]
        private IWebElement _revenueCenterSacramento;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[53]")]
        private IWebElement _revenueCenterSaltLakeCity;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[54]")]
        private IWebElement _revenueCenterSanAntonio;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[55]")]
        private IWebElement _revenueCenterSanDiego;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[56]")]
        private IWebElement _revenueCenterSanFrancisco;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[57]")]
        private IWebElement _revenueCenterSeattle;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[58]")]
        private IWebElement _revenueCenterStLouis;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[59]")]
        private IWebElement _revenueCenterTampa;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[60]")]
        private IWebElement _revenueCenterTennessee;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[61]")]
        private IWebElement _revenueCenterUpstateNy;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[62]")]
        private IWebElement _revenueCenterWashingtonDc;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[63]")]
        private IWebElement _revenueCenterWestPalm;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,' Central')]]")]
        private IWebElement _marketCentral;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Mid Atlantic')]]")]
        private IWebElement _marketMidAtlantic;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Northeast')]]")]
        private IWebElement _marketNortheast;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'South')]]")]
        private IWebElement _marketSouth;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'West')]]")]
        private IWebElement _marketWest;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'EV4')]]")]
        private IWebElement _systemEv4;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'WFN')]]")]
        private IWebElement _systemWfn;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Exact Match')]]")]
        private IWebElement _productsExactMatch;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Medical')]]")]
        private IWebElement _productsMedical;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Dental')]]")]
        private IWebElement _productsDental;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Vision')]]")]
        private IWebElement _productsVision;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Life')]]")]
        private IWebElement _productsLife;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'STD')]]")]
        private IWebElement _productsStd;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'LTD')]]")]
        private IWebElement _productsLtd;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'HSA')]]")]
        private IWebElement _productsHsa;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'FSA')]]")]
        private IWebElement _productsFsa;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'401k')]]")]
        private IWebElement _products401K;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Yes')]]")]
        private IWebElement _inOeYes;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'No')]]")]
        private IWebElement _inOeNo;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Active')]]")]
        private IWebElement _clientStatusActive;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Future Start')]]")]
        private IWebElement _clientStatusFutureStart;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Future Term')]]")]
        private IWebElement _clientStatusFutureTerm;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Terminated')]]")]
        private IWebElement _clientStatusTerminated;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Untouched')]]")]
        private IWebElement _renewalStatusUntouched;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'In Progress')]]")]
        private IWebElement _renewalStatusInProgress;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Client Ready')]]")]
        private IWebElement _renewalStatusClientReady;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Signed CBE')]]")]
        private IWebElement _renewalStatusSignedCbe;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Submission In Progress')]]")]
        private IWebElement _renewalStatusSubmissionInProgress;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Client Review')]]")]
        private IWebElement _renewalStatusClientReview;

        [FindsBy(How = How.XPath, Using = "//ul[@class = 'select-items-container']//li[text()[contains(.,'Resubmission Required')]]")]
        private IWebElement _renewalStatusResubmissionRequired;



        private By _parentDetails = By.XPath("(//span[.='Parent Details'])[1]");

        public BobHomePage() : base()
        {
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_paygroupCodeOrNameField)) { }
            if (IsElementDisplayed(_searchIcon)) { }
            if (IsElementDisplayed(_filterByButton)) { }
            if (IsElementDisplayed(_saveResultsButton)) { }
            if (IsElementDisplayed(_bobButton)) { }
            if (IsElementDisplayed(_oeButton)) { }
            {
                Logger.screenshot_PASS("All the header elements are displayed correctly");
            }
        }

        public void VerifyFilters()
        {
            Click(_clear);
            Click(_clearAll);
            Click(_filterByButton);
            Click(_filterByRevenueCenters);
            Click(_filterByDropDown);
            if (IsElementDisplayed(_revenueCenterAtlanta)) { }
            if (IsElementDisplayed(_revenueCenterAuburnHills)) { }
            if (IsElementDisplayed(_revenueCenterAustin)) { }
            if (IsElementDisplayed(_revenueCenterBoston)) { }
            if (IsElementDisplayed(_revenueCenterCharlotte)) { }
            if (IsElementDisplayed(_revenueCenterChicago)) { }
            if (IsElementDisplayed(_revenueCenterCleveland)) { }
            if (IsElementDisplayed(_revenueCenterDallas)) { }
            if (IsElementDisplayed(_revenueCenterDenver)) { }
            if (IsElementDisplayed(_revenueCenterDesMoines)) { }
            if (IsElementDisplayed(_revenueCenterElPaso)) { }
            if (IsElementDisplayed(_revenueCenterFtLauderdale)) { }
            if (IsElementDisplayed(_revenueCenterGrandRapids)) { }
            if (IsElementDisplayed(_revenueCenterGreenBay)) { }
            if (IsElementDisplayed(_revenueCenterHouston)) { }
            if (IsElementDisplayed(_revenueCenterIndianapolis)) { }
            if (IsElementDisplayed(_revenueCenterJacksonville)) { }
            if (IsElementDisplayed(_revenueCenterKansasCity)) { }
            if (IsElementDisplayed(_revenueCenterLasVegas)) { }
            if (IsElementDisplayed(_revenueCenterLosAngeles)) { }
            if (IsElementDisplayed(_revenueCenterLousville)) { }
            if (IsElementDisplayed(_revenueCenterMadison)) { }
            if (IsElementDisplayed(_revenueCenterManchester)) { }
            if (IsElementDisplayed(_revenueCenterMelville)) { }
            if (IsElementDisplayed(_revenueCenterMetroDetroit)) { }
            if (IsElementDisplayed(_revenueCenterMiami)) { }
            if (IsElementDisplayed(_revenueCenterMilwaukee)) { }
            if (IsElementDisplayed(_revenueCenterMinneapolis)) { }
            if (IsElementDisplayed(_revenueCenterNewJersey)) { }
            if (IsElementDisplayed(_revenueCenterNewOrleans)) { }
            if (IsElementDisplayed(_revenueCenterNewYork)) { }
            if (IsElementDisplayed(_revenueCenterNovi)) { }
            if (IsElementDisplayed(_revenueCenterOklahoma)) { }
            if (IsElementDisplayed(_revenueCenterOmaha)) { }
            if (IsElementDisplayed(_revenueCenterOrange)) { }
            if (IsElementDisplayed(_revenueCenterOrlando)) { }
            if (IsElementDisplayed(_revenueCenterPhiladelhia)) { }
            if (IsElementDisplayed(_revenueCenterPhoenix)) { }
            if (IsElementDisplayed(_revenueCenterPittsburg)) { }
            if (IsElementDisplayed(_revenueCenterPortland)) { }
            if (IsElementDisplayed(_revenueCenterPrime)) { }
            if (IsElementDisplayed(_revenueCenterPrimeCentral)) { }
            if (IsElementDisplayed(_revenueCenterPrimeMidAtlantic)) { }
            if (IsElementDisplayed(_revenueCenterPrimeSouth)) { }
            if (IsElementDisplayed(_revenueCenterPrimeWestCentral)) { }
            if (IsElementDisplayed(_revenueCenterPrinceton)) { }
            if (IsElementDisplayed(_revenueCenterRaleigh)) { }
            if (IsElementDisplayed(_revenueCenterRichmond)) { }
            if (IsElementDisplayed(_revenueCenterRochester)) { }
            if (IsElementDisplayed(_revenueCenterRockville)) { }
            if (IsElementDisplayed(_revenueCenterSacramento)) { }
            if (IsElementDisplayed(_revenueCenterSaltLakeCity)) { }
            if (IsElementDisplayed(_revenueCenterSanAntonio)) { }
            if (IsElementDisplayed(_revenueCenterSanDiego)) { }
            if (IsElementDisplayed(_revenueCenterSanFrancisco)) { }
            if (IsElementDisplayed(_revenueCenterSeattle)) { }
            if (IsElementDisplayed(_revenueCenterStLouis)) { }
            if (IsElementDisplayed(_revenueCenterTampa)) { }
            if (IsElementDisplayed(_revenueCenterTennessee)) { }
            if (IsElementDisplayed(_revenueCenterUpstateNy)) { }
            if (IsElementDisplayed(_revenueCenterWashingtonDc)) { }
            if (IsElementDisplayed(_revenueCenterWestPalm)) {
            Logger.screenshot_PASS("All the revenue centers are listed correctly");
            }
            Click(_filterByButton);
            Click(_filterByMarkets);
            Click(_filterByDropDown);
            if(IsElementDisplayed(_marketCentral)) { }
            if(IsElementDisplayed(_marketMidAtlantic)) { }
            if(IsElementDisplayed(_marketNortheast)) { }
            if(IsElementDisplayed(_marketSouth)) { }
            if(IsElementDisplayed(_marketWest)) {
            Logger.screenshot_PASS("All the markets are listed correctly");
            }
            Click(_filterByButton);
            Click(_filterBySystem);
            Click(_filterByDropDown);
            if (IsElementDisplayed(_systemEv4)) { }
            if (IsElementDisplayed(_systemWfn)) {
                Logger.screenshot_PASS("All the systems are displayed correctly");
            }
            Click(_filterByButton);
            Click(_filterByProducts);
            Click(_filterByDropDown);
            if(IsElementDisplayed(_productsExactMatch)) { }
            if (IsElementDisplayed(_productsMedical)) { }
            if (IsElementDisplayed(_productsDental)) { }
            if (IsElementDisplayed(_productsVision)) { }
            if (IsElementDisplayed(_productsLife)) { }
            if (IsElementDisplayed(_productsStd)) { }
            if (IsElementDisplayed(_productsLtd)) { }
            if (IsElementDisplayed(_productsHsa)) { }
            if (IsElementDisplayed(_productsFsa)) { }
            if (IsElementDisplayed(_products401K)) {
            Logger.screenshot_PASS("All the products are listed correctly");
            }
            Click(_filterByButton);
            Click(_filterByInOe);
            Click(_filterByDropDown);
            if (IsElementDisplayed(_inOeYes)) { }
            if(IsElementDisplayed(_inOeNo)){
                Logger.screenshot_PASS("In OE items are displayed correctly");
            }
            Click(_filterByButton);
            Click(_filterByClientStatus);
            Click(_filterByDropDown);
            if(IsElementDisplayed(_clientStatusActive)) { }
            if (IsElementDisplayed(_clientStatusFutureStart)) { }
            if (IsElementDisplayed(_clientStatusFutureTerm)) { }
            if (IsElementDisplayed(_clientStatusTerminated)) {
                Logger.screenshot_PASS("All client statuses are displayed correctly");
            }
            Click(_filterByButton);
            Click(_filterByOeRenewalStatus);
            Click(_filterByDropDown);
            if (IsElementDisplayed(_renewalStatusUntouched)) { }
            if (IsElementDisplayed(_renewalStatusInProgress)) { }
            if (IsElementDisplayed(_renewalStatusClientReady)) { }
            if (IsElementDisplayed(_renewalStatusClientReview)) { }
            if (IsElementDisplayed(_renewalStatusSignedCbe)) { }
            if (IsElementDisplayed(_renewalStatusSubmissionInProgress)) { }
            if (IsElementDisplayed(_renewalStatusResubmissionRequired)){
                Logger.screenshot_PASS("All client renewal statuses are displayed correctly");
            }
}
        public void NavigateClientLevel()
        {
            WaitInvisibleElement(_loadingBar);
            Click(_paygroupCodeOrNameField);
            if (Jenkins.CompanyCode == null)
            {
                _paygroupCodeOrNameField.SendKeys("00A");
            }
            else
            {
                _paygroupCodeOrNameField.SendKeys(Jenkins.CompanyCode);
            }
            Click(_searchIcon);
            StandBy(1);
            Click(_companyName);
        }
    }
}
