using System;
using ADP_Tests.ADP_PageFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_Tests.resources;

namespace ADP_Tests.ADPageFactory.WFN
{
    public class WfnAddClient: AdpAbstractPageFactory
    {
        private static string GetCompanyCode = Guid.NewGuid().ToString().Substring(0, 3);

        private static string GetCompanyCode2 = Guid.NewGuid().ToString().Substring(0, 3);

        private static string GetCompanyCode3 = Guid.NewGuid().ToString().Substring(0, 3);

        private static string GetCompanyCode4 = Guid.NewGuid().ToString().Substring(0, 3);

        private static string GetCompanyCode5 = Guid.NewGuid().ToString().Substring(0, 3);

        private readonly By _title = By.XPath("//span[.='Add Client']");

        private readonly By _products = By.XPath("//span[.= 'Products']");

        private readonly By _options = By.XPath("//span[.= 'Options']");

        [FindsBy(How = How.Id, Using = "portalClientClass")]
        private IWebElement _portalClientClassificationDropDown;

        [FindsBy(How = How.Id, Using = "isiClientId")]
        private IWebElement _clientIDField;

        [FindsBy(How = How.Id, Using = "clientName")]
        private IWebElement _clientNameField;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) = 'Client with Employees']")]
        private IWebElement _UncheckClientWithEmployees;

        [FindsBy(How = How.Id, Using = "passcode1")]
        private IWebElement _registrationPasscode;

        [FindsBy(How = How.Id, Using = "wfnVersion")]
        private IWebElement _wfnVersion;

        [FindsBy(How = How.Id, Using = "defaultLang")]
        private IWebElement _defaultLanguage;

        [FindsBy(How = How.Id, Using = "selectedLanguage_productLocale_Left")]
        private IWebElement _availableLanguages;

        [FindsBy(How = How.Id, Using = "productsColumn2")]
        private IWebElement secondColumn;

        [FindsBy(How = How.Id, Using = "inhwizard_tablist_addNewClientPane")]
        private IWebElement _addClientID;

        [FindsBy(How = How.XPath, Using = "//span[.='Choose Products']")]
        private IWebElement _chooseProducts;

        [FindsBy(How = How.XPath, Using = "//span[.='Client Options']")]
        private IWebElement _clientOptions;

        [FindsBy(How = How.Id, Using = "inhwizard_tablist_addCompanyCodesPane")]
        private IWebElement _createCompany;

        [FindsBy(How = How.XPath, Using = "//div[@widgetid='totalSource']")]
        private IWebElement _totalSourceClient;

        [FindsBy(How = How.XPath, Using = "//div[@widgetid='benefits']")]
        private IWebElement _benefits;

        [FindsBy(How = How.XPath, Using = "//div[@widgetid='enhancedBenefits']")]
        private IWebElement _enhancedBenefits;

        [FindsBy(How = How.Id, Using = "inhwizard_tablist_addNewClientUserPane")]
        private IWebElement _createUser;

        [FindsBy(How = How.XPath, Using = "//div[@widgetid='effectiveDating']")]
        private IWebElement _effecitveDating;

        [FindsBy(How = How.Id, Using = "clientGrid_toolbar_add")]
        private IWebElement _addClient;

        [FindsBy(How = How.Id, Using = "addCompany_companyCode")]
        private IWebElement _companyCode;

        [FindsBy(How = How.Id, Using = "addCompany_companyName")]
        private IWebElement _companyName;

        [FindsBy(How = How.XPath, Using = "//div[@widgetid='addCompany_isParent']")]
        private IWebElement _isParent;

        [FindsBy(How = How.Id, Using = "companyListValidateSubmitButton")]
        private IWebElement _addButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='clientGrid_rows_scrollpane']//div[@class='revitCheckBoxIcon']")]
        private IWebElement _addCompanyCodeButton;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement _email;
        
        [FindsBy(How = How.XPath, Using = "//span[@class='revitWizardControlComplete dijitInline']")]
        private IWebElement _doneButton;

        [FindsBy(How = How.XPath, Using = "//span[.='IN PROGRESS']")]
        private IWebElement _inProgress;

        [FindsBy(How = How.XPath, Using = "//div[.='Duplicate company codes are not allowed within a selling region, please enter a unique company code']")]
        private IWebElement _errorMessage;

        public WfnAddClient() : base()
        {
            WaitVisibleElement(_title);
        }

        public void AddClientId()
        {
            Click(_portalClientClassificationDropDown);
            _portalClientClassificationDropDown.SendKeys("ADP Support");
            _portalClientClassificationDropDown.SendKeys(Keys.Enter);
            StandBy(1);
            _clientIDField.SendKeys(GetCompanyCode);
            _clientNameField.SendKeys("Team Pan Test Client");
            _wfnVersion.Clear();
            _wfnVersion.SendKeys("12.00.000");
            _wfnVersion.SendKeys(Keys.Enter);
            Click(_UncheckClientWithEmployees);
            Click(_registrationPasscode);
            _registrationPasscode.SendKeys("1234");
            Click(_defaultLanguage);
            _defaultLanguage.SendKeys("English (United States)");
            _defaultLanguage.SendKeys(Keys.Enter);
            Click(_availableLanguages);
            Logger.screenshot_PASS("Add Client page is filled with info");
            Click(_chooseProducts);
        }

        public void ChooseProducts()
        {
            WaitVisibleElement(_products);
            ScrollDown(secondColumn);
            Click(_totalSourceClient);
            Click(_benefits);
            Click(_enhancedBenefits);
            Logger.screenshot_PASS("Choose Products page is filled with info");
            Click(_clientOptions);   
        }

        public void ClientOptions()
        {
            WaitVisibleElement(_options);
            Click(_effecitveDating);
            Logger.screenshot_PASS("Client Options page is filled with info");
            Click(_createCompany);
        }

        public void CreateCompany()
        {
            Click(_addClient);
            _companyCode.SendKeys(GetCompanyCode);
            _companyName.SendKeys("Team Pan Test Client");
            Click(_isParent);
            Click(_addButton);
            if (IsElementDisplayed(_errorMessage))
            {
                Logger.screenshot_WARNING("Company Code already exist in the system. Trying another one");
                Click(_addClientID);
                _clientIDField.Clear();
                _clientIDField.SendKeys(GetCompanyCode2);
                Click(_createCompany);
                Click(_addClient);
                _companyCode.SendKeys(GetCompanyCode2);
                _companyName.SendKeys("Team Pan Test Client");
                Click(_isParent);
                Click(_addButton);
            }
            else
            {
                Logger.screenshot_PASS("Successfully added" + " " + GetCompanyCode2 + " " + "Company Code");
            }
            if (IsElementDisplayed(_errorMessage))
            {
                Logger.screenshot_WARNING("Company Code already exist in the system. Trying another one");
                Click(_addClientID);
                _clientIDField.Clear();
                _clientIDField.SendKeys(GetCompanyCode3);
                Click(_createCompany);
                Click(_addClient);
                _companyCode.SendKeys(GetCompanyCode3);
                _companyName.SendKeys("Team Pan Test Client");
                Click(_isParent);
                Click(_addButton);
            }
            else
            {
                Logger.screenshot_PASS("Successfully added" + " " + GetCompanyCode3 + " " + "Company Code");
            }
            if (IsElementDisplayed(_errorMessage))
            {
                Logger.screenshot_WARNING("Company Code already exist in the system. Trying another one");
                Click(_addClientID);
                _clientIDField.Clear();
                _clientIDField.SendKeys(GetCompanyCode4);
                Click(_createCompany);
                Click(_addClient);
                _companyCode.SendKeys(GetCompanyCode4);
                _companyName.SendKeys("Team Pan Test Client");
                Click(_isParent);
                Click(_addButton);
            }
            else
            {
                Logger.screenshot_PASS("Successfully added" + " " + GetCompanyCode4 + " " + "Company Code");
            }
            if (IsElementDisplayed(_errorMessage))
            {
                Logger.screenshot_WARNING("Company Code already exist in the system. Trying another one");
                Click(_addClientID);
                _clientIDField.Clear();
                _clientIDField.SendKeys(GetCompanyCode5);
                Click(_createCompany);
                Click(_addClient);
                _companyCode.SendKeys(GetCompanyCode5);
                _companyName.SendKeys("Team Pan Test Client");
                Click(_isParent);
                Click(_addButton);
            }
            else
            {
                Logger.screenshot_PASS("Successfully added" + " " + GetCompanyCode5 + " " + "Company Code");
            }
            Logger.screenshot_PASS("Create user page is filled with info");
            Click(_addCompanyCodeButton);
            Click(_createUser);
        }

        public void CreateUser()
        {
            _email.SendKeys("aznariy.ramazanov@adp.com");
            Click(_doneButton);
            WaitVisibleText(_inProgress, "");
            if (IsElementDisplayed(_inProgress))
            {
                Logger.screenshot_PASS("Client creation is in progress");
            }
            else
            {
                Logger.screenshot_FAIL("Client creation has failed");
            }
            Click(_inProgress);
            StandBy(10);
        }
    }
}
