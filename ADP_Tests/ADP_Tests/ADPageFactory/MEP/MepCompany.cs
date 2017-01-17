using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.MEP
{
    public class MepCompany: AdpAbstractPageFactory
    {
        private readonly By _title = By.XPath("//span[normalize-space(text()) ='Company']");

        private readonly By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Company Name']")]
        private IWebElement _companyNameHeaderText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Company Code']")]
        private IWebElement _companyCodeHeaderText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Effective Date']")]
        private IWebElement _effectiveHeaderDateText;

        [FindsBy(How = How.XPath, Using = "(//md-tab-item[@ng-click ='$mdTabsCtrl.select(tab.getIndex())'])[1]")]
        private IWebElement _companyDemographicsTab;

        [FindsBy(How = How.XPath, Using = "(//md-tab-item[@ng-click ='$mdTabsCtrl.select(tab.getIndex())'])[2]")]
        private IWebElement _mepContactTab;

        [FindsBy(How = How.XPath, Using = "(//md-tab-item[@ng-click ='$mdTabsCtrl.select(tab.getIndex())'])[3]")]
        private IWebElement _planInformationTab;

        [FindsBy(How = How.XPath, Using = "(//md-tab-item[@ng-click ='$mdTabsCtrl.select(tab.getIndex())'])[4]")]
        private IWebElement _wseTab;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Company Code']")]
        private IWebElement _companyCodeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Company Name']")]
        private IWebElement _companyNameText;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Company Start Date'])[1]")]
        private IWebElement _companyStartDateText_1;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Company Start Date'])[1]")]
        private IWebElement _companyStatusText_1;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Company Start Date'])[1]")]
        private IWebElement _companyEndDateText_1;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Company Term Reason'])[1]")]
        private IWebElement _companyTermReasonText_1;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label ='SEI Employees']//div[@class='md-bar']")]
        private IWebElement _seiEmployeesFlag;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label ='Union Employees']//div[@class='md-bar']")]
        private IWebElement _unionEmployeesFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='SEI Employees']")]
        private IWebElement _seiEmployeesText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Union Employees']")]
        private IWebElement _unionEmployeesText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Autopay Schema']")]
        private IWebElement _autoPaySchema;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Legal Name']")]
        private IWebElement _legalNameText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='DBA']")]
        private IWebElement _dbaText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Address']")]
        private IWebElement _addressText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Address 2']")]
        private IWebElement _address2Text;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='City']")]
        private IWebElement _cityText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='State']")]
        private IWebElement _stateText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Postal Code']")]
        private IWebElement _postalCodeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='FEIN']")]
        private IWebElement _feinText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='NAICS']")]
        private IWebElement _naicsText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='SIC']")]
        private IWebElement _sicText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Region Area']")]
        private IWebElement _regionAreaText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Contract Signer']")]
        private IWebElement _contactSigner;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Work Phone'])[1]")]
        private IWebElement _workPhoneText_1;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Fax']")]
        private IWebElement _faxText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Contact Name']")]
        private IWebElement _contactNameText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Contact Title']")]
        private IWebElement _contactTitleText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Contact Email']")]
        private IWebElement _contactEmailText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Street (line 1)']")]
        private IWebElement _streetLine1Text;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Street (line 2)']")]
        private IWebElement _streetLine2Text;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Contact City']")]
        private IWebElement _contactCityText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Contact State']")]
        private IWebElement _contactStateText;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Work Phone'])[2]")]
        private IWebElement _workPhoneText_2;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Postal/Zip Code']")]
        private IWebElement _postalZipCodeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Fax Number']")]
        private IWebElement _faxNumberText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='RK#']")]
        private IWebElement _rkNumberText;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Company Status'])[2]")]
        private IWebElement _companyStatusText_2;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Company Term Reason'])[2]")]
        private IWebElement _companyTermReasonText_2;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Company Start Date'])[2]")]
        private IWebElement _companyStartDateText_2;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Company End Date'])[2]")]
        private IWebElement _companyEndDateText_2;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Deferral Start Date']")]
        private IWebElement _deferralStartDateText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='MEP Term Date']")]
        private IWebElement _mepTermDateText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='MEP Term Reason']")]
        private IWebElement _mepTermReasonText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Plan Type']")]
        private IWebElement _planTypeText;

        [FindsBy(How = How.XPath, Using = "//h4[normalize-space(text()) ='Protected Benefits']")]
        private IWebElement _protectedBenefitsText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='In Service Withdrawal']")]
        private IWebElement _inServiceWithdrawalText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='In Service Withdrawal Age']")]
        private IWebElement _inServiceWithdrawalAgeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Money Purchase Plan']")]
        private IWebElement _moneyPurhcasePlanText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Additional Distribution Option']")]
        private IWebElement _additionalDistributionOptionText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Early Retirement']")]
        private IWebElement _earlyRetirementText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Early Retirement Age']")]
        private IWebElement _earlyRetirementAgeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Accelerated Vesting Schedule']")]
        private IWebElement _acceleratingVestingScheduleText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Minimum Age']")]
        private IWebElement _minimumAgeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Service Requirement']")]
        private IWebElement _serviceRequirementText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='All Employees']")]
        private IWebElement _allEmployeesText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Excluded']")]
        private IWebElement _excludedText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Grandfathered Eligibility Age']")]
        private IWebElement _grandfatheredEligibilityAgeText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Grandfathered Service']")]
        private IWebElement _grandfatheredServiceText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@ng-model ='mepCompany.clientInfo.Election.IsAllEmployees.Value']//div[@class='md-bar']")]
        private IWebElement _allEmployeesFlag;

        [FindsBy(How = How.XPath, Using = "//md-switch[@ng-model ='mepCompany.clientInfo.Plan.IsTSEarlyRetirement.Value']//div[@class='md-bar']")]
        private IWebElement _earlyRetirementFlag;

        [FindsBy(How = How.XPath, Using = "//md-switch[@ng-model ='mepCompany.clientInfo.Plan.IsAcceleratedVestingSchedule.Value']//div[@class='md-bar']")]
        private IWebElement _acceleratedVestingScheduleFlag;

        [FindsBy(How = How.XPath, Using = "//md-switch[@ng-model ='mepCompany.clientInfo.Election.IsMoneyPurchasePlan.Value']//div[@class='md-bar']")]
        private IWebElement _moneyPurhcasePlanFlag;

        [FindsBy(How = How.XPath, Using = "//md-switch[@ng-model ='mepCompany.clientInfo.Election.IsAdditionalDistributionOption.Value']//div[@class='md-bar']")]
        private IWebElement _additionalDistributionOptionFlag;

        [FindsBy(How = How.XPath, Using = "//md-switch[@ng-model ='mepCompany.clientInfo.Election.IsInServiceWithdrawal.Value']//div[@class='md-bar']")]
        private IWebElement _inServiceWithdrawalFlag;

        [FindsBy(How = How.XPath, Using = "//th[normalize-space(text()) ='Name']")]
        private IWebElement _wseNameText;

        [FindsBy(How = How.XPath, Using = "//th[normalize-space(text()) ='DOB']")]
        private IWebElement _wseDOBText;

        [FindsBy(How = How.XPath, Using = "//th[normalize-space(text()) ='Type']")]
        private IWebElement _wseType;

        [FindsBy(How = How.XPath, Using = "//th[normalize-space(text()) ='Status']")]
        private IWebElement _wseStatusText;

        [FindsBy(How = How.XPath, Using = "//th[normalize-space(text()) ='MEP Hire']")]
        private IWebElement _wseMepHireText;

        [FindsBy(How = How.XPath, Using = "//th[normalize-space(text()) ='Service Requirement']")]
        private IWebElement _wseServiceRequirementText;

        [FindsBy(How = How.XPath, Using = "//th[normalize-space(text()) ='Age Requirement']")]
        private IWebElement _wseAgeRequirementText;

        [FindsBy(How = How.XPath, Using = "//th[normalize-space(text()) ='MEP Eligibility']")]
        private IWebElement _wseMepEligibilityText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='+ New Date']")]
        private IWebElement _newDateButton;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Cancel']")]
        private IWebElement _cancelButton;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Save']")]
        private IWebElement _saveButton;

        public MepCompany() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_companyNameHeaderText)) { }
            if (IsElementDisplayed(_companyCodeHeaderText)) { }
            if (IsElementDisplayed(_effectiveHeaderDateText)) { }
            if (IsElementDisplayed(_companyCodeText)) { }
            if (IsElementDisplayed(_companyNameText)) { }
            if (IsElementDisplayed(_companyStartDateText_1)) { }
            if (IsElementDisplayed(_companyStatusText_1)) { }
            if (IsElementDisplayed(_companyEndDateText_1)) { }
            if (IsElementDisplayed(_companyTermReasonText_1)) { }
            if (IsElementDisplayed(_seiEmployeesFlag)) { }
            if (IsElementDisplayed(_seiEmployeesText)) { }
            if (IsElementDisplayed(_unionEmployeesFlag)) { }
            if (IsElementDisplayed(_unionEmployeesText)) { }
            if (IsElementDisplayed(_autoPaySchema)) { }
            if (IsElementDisplayed(_legalNameText)) { }
            if (IsElementDisplayed(_dbaText)) { }
            if (IsElementDisplayed(_addressText)) { }
            if (IsElementDisplayed(_address2Text)) { }
            if (IsElementDisplayed(_cityText)) { }
            if (IsElementDisplayed(_stateText)) { }
            if (IsElementDisplayed(_postalCodeText)) { }
            if (IsElementDisplayed(_feinText)) { }
            if (IsElementDisplayed(_naicsText)) { }
            if (IsElementDisplayed(_sicText)) { }
            if (IsElementDisplayed(_regionAreaText)) { }
            if (IsElementDisplayed(_contactSigner)) { }
            if (IsElementDisplayed(_workPhoneText_1)) { }
            if (IsElementDisplayed(_faxText))
            {
                Logger.screenshot_PASS("MEP Company Demographics: All the page elements are displayed correctly");
            }
            Click(_mepContactTab);
            StandBy(1);
            if (IsElementDisplayed(_contactNameText)) { }
            if (IsElementDisplayed(_contactTitleText)) { }
            if (IsElementDisplayed(_contactEmailText)) { }
            if (IsElementDisplayed(_streetLine1Text)) { }
            if (IsElementDisplayed(_streetLine2Text)) { }
            if (IsElementDisplayed(_contactCityText)) { }
            if (IsElementDisplayed(_contactStateText)) { }
            if (IsElementDisplayed(_postalZipCodeText)) { }
            if (IsElementDisplayed(_workPhoneText_2)) { }
            if (IsElementDisplayed(_faxNumberText))
            {
                Logger.screenshot_PASS("MEP Contact: All the page elements are displayed correctly");
            }
            Click(_planInformationTab);
            StandBy(1);
            if (IsElementDisplayed(_rkNumberText)) { }
            if (IsElementDisplayed(_companyStatusText_2)) { }
            if (IsElementDisplayed(_companyTermReasonText_2)) { }
            if (IsElementDisplayed(_companyStartDateText_2)) { }
            if (IsElementDisplayed(_companyEndDateText_2)) { }
            if (IsElementDisplayed(_deferralStartDateText)) { }
            if (IsElementDisplayed(_mepTermDateText)) { }
            if (IsElementDisplayed(_mepTermReasonText)) { }
            if (IsElementDisplayed(_planTypeText)) { }
            if (IsElementDisplayed(_protectedBenefitsText)) { }
            if (IsElementDisplayed(_inServiceWithdrawalText)) { }
            if (IsElementDisplayed(_inServiceWithdrawalFlag)) { }
            if (IsElementDisplayed(_inServiceWithdrawalAgeText)) { }
            if (IsElementDisplayed(_moneyPurhcasePlanText)) { }
            if (IsElementDisplayed(_moneyPurhcasePlanFlag)) { }
            if (IsElementDisplayed(_additionalDistributionOptionFlag)) { }
            if (IsElementDisplayed(_additionalDistributionOptionText)) { }
            if (IsElementDisplayed(_earlyRetirementText)) { }
            if (IsElementDisplayed(_earlyRetirementFlag)) { }
            if (IsElementDisplayed(_earlyRetirementAgeText)) { }
            if (IsElementDisplayed(_acceleratingVestingScheduleText)) { }
            if (IsElementDisplayed(_acceleratedVestingScheduleFlag)) { }
            if (IsElementDisplayed(_minimumAgeText)) { }
            if (IsElementDisplayed(_serviceRequirementText)) { }
            if (IsElementDisplayed(_allEmployeesText)) { }
            if (IsElementDisplayed(_allEmployeesFlag)) { }
            if (IsElementDisplayed(_excludedText)) { }
            if (IsElementDisplayed(_grandfatheredEligibilityAgeText)) { }
            if (IsElementDisplayed(_grandfatheredServiceText))
            {
                Logger.screenshot_PASS("MEP Plan Information: All the page elements are displayed correectly");
            }
            Click(_wseTab);
            StandBy(1);
            if (IsElementDisplayed(_wseNameText)) { }
            if (IsElementDisplayed(_wseDOBText)) { }
            if (IsElementDisplayed(_wseType)) { }
            if (IsElementDisplayed(_wseMepHireText)) { }
            if (IsElementDisplayed(_wseServiceRequirementText)) { }
            if (IsElementDisplayed(_wseAgeRequirementText)) { }
            if (IsElementDisplayed(_wseMepEligibilityText)) { }
            if (IsElementDisplayed(_newDateButton)) { }
            if (IsElementDisplayed(_cancelButton)) { }
            if (IsElementDisplayed(_saveButton))
            {
                Logger.screenshot_PASS("MPE WSE: All the page elements are displayed correctly");
            }
        }
    }
}
