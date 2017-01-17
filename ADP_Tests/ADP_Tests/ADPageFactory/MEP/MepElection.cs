using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADP_PageFactory;
using ADP_Tests.resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.MEP
{
    public class MepElection : AdpAbstractPageFactory
    {
        private readonly By _title = By.XPath("//span[normalize-space(text()) ='Election']");

        private readonly By _loadingBar = By.Id("adp-bar-loading-indicator");

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Change State']//span[normalize-space(text()) ='401K MEP']")]
        private readonly IWebElement _401Title;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) ='Approved by']")]
        private readonly IWebElement _approvedByText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Plan Effective Date']")]
        private readonly IWebElement _planEffectiveDateText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Termination Date']")]
        private IWebElement _terminationDateText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Lead Origination']")]
        private IWebElement _leadOrganizationText;

        [FindsBy(How = How.XPath, Using = "(//label[normalize-space(text()) ='Effective Date'])[1]")]
        private IWebElement _effectiveDateText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Cancel']")]
        private IWebElement _cancelButton;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Save']")]
        private IWebElement _saveButton;

        [FindsBy(How = How.XPath, Using = "(//md-tab-item[@ng-click ='$mdTabsCtrl.select(tab.getIndex())'])[1]")]
        private IWebElement _overviewTab;

        [FindsBy(How = How.XPath, Using = "(//md-tab-item[@ng-click ='$mdTabsCtrl.select(tab.getIndex())'])[2]")]
        private IWebElement _contributionTab;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='401K Plan']")]
        private IWebElement _401KText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Parent Paygroup']")]
        private IWebElement _parentPaygroupText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='401(k) Specialist']")]
        private IWebElement _401KSpecialistText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Adoption Agreement Version']")]
        private IWebElement _adoptionAgreementVersionText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Plan Type']")]
        private IWebElement _planTypeText;

        [FindsBy(How = How.XPath, Using = "//h4[normalize-space(text()) ='Eligibility']")]
        private IWebElement _eligibilityText;

        [FindsBy(How = How.XPath, Using = "//h4[normalize-space(text()) ='Enrollment']")]
        private IWebElement _enrollmentText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'All Employees']//div[@class ='md-bar']")]
        private IWebElement _allEmployeesFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='All Employees']")]
        private IWebElement _allEmployeesText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Exclude']")]
        private IWebElement _excludeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Minimum Age']")]
        private IWebElement _minimumAgeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Service Requirement']")]
        private IWebElement _serviceRequirementText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'Auto Enroll']//div[@class ='md-bar']")]
        private IWebElement _autoEnrollFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Auto Enroll']")]
        private IWebElement _autoEnrollText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Auto Enroll Percentage']")]
        private IWebElement _autoEnrollPercentageText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'Auto Enroll Annual Increase']//div[@class ='md-bar']")]
        private IWebElement _autoEnrollAnnualIncreaseFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Auto Enroll Annual Increase']")]
        private IWebElement _autoEnrollAnnualIncreaseText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Annual Increase Percentage']")]
        private IWebElement _annualIncreasePercentageText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Grandfathered Eligibility Age']")]
        private IWebElement _grandfatheredEligibilityAgeText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Grandfathered Service']")]
        private IWebElement _grandfatheredService;

        [FindsBy(How = How.XPath, Using = "//h4[normalize-space(text()) ='Compliance']")]
        private IWebElement _complianceText;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Top Heavy Minimum Contribution']")]
        private IWebElement _topHeavyMinimumContributionText;

        [FindsBy(How = How.XPath, Using = "//h4[normalize-space(text()) ='Exclusions']")]
        private IWebElement _exclutionsText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'Exclude Commisions']//div[@class ='md-bar']")]
        private IWebElement _excludeComissionsFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Exclude Commisions']")]
        private IWebElement _excludeComissionsText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'Exclude Bonuses']//div[@class ='md-bar']")]
        private IWebElement _excldeBonusesFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Exclude Bonuses']")]
        private IWebElement _excludeBonusesText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'True Up']//div[@class ='md-bar']")]
        private IWebElement _trueUpFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='True Up']")]
        private IWebElement _trueUpText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'Top Paid Group']//div[@class ='md-bar']")]
        private IWebElement _topPaidGroupFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Top Paid Group']")]
        private IWebElement _topPaidGroupText;

        [FindsBy(How = How.XPath, Using = "//h4[normalize-space(text()) ='Protected Benefits']")]
        private IWebElement _protectedBenefitsText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'In Service Withdrawal']//div[@class ='md-bar']")]
        private IWebElement _inServiceWithdrawalFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='In Service Withdrawal']")]
        private IWebElement _inServiceWithdrawalText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='In Service Withdrawal Age']")]
        private IWebElement _inserviceWithdrawalAgeText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'Money Purchase Plan']//div[@class ='md-bar']")]
        private IWebElement _moneyPurhcasePlanFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Money Purchase Plan']")]
        private IWebElement _moneyPurhcasePlanText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'Additional Distribution Option']//div[@class ='md-bar']")]
        private IWebElement _additionalDistributionOptionFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Additional Distribution Option']")]
        private IWebElement _additionalDistributionOptionText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'Early Retirement']//div[@class ='md-bar']")]
        private IWebElement _earlyRetirementFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Early Retirement']")]
        private IWebElement _earlyRetirementText;

        [FindsBy(How = How.XPath, Using = "//label[normalize-space(text()) ='Early Retirement Age']")]
        private IWebElement _earlyRetirementAgeText;

        [FindsBy(How = How.XPath, Using = "//md-switch[@aria-label = 'Accelerated Vesting Schedule']//div[@class ='md-bar']")]
        private IWebElement _acceleratingVestingScheduleFlag;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space(text()) ='Accelerated Vesting Schedule']")]
        private IWebElement _acceleratingVestingScheduleText;

        [FindsBy(How = How.XPath, Using = "//md-select[@aria-label ='Add an Employer Contribution Type ']")]
        private IWebElement _addEmployerContributionType;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) ='D - Discretionary Match']")]
        private IWebElement _discretionaryMatch;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) ='E - Discretionary Profit Sharing']")]
        private IWebElement _discretionaryProfitSharing;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) ='K2 - QACA Base']")]
        private IWebElement _QACABase;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) ='U - Safe Harbor Match']")]
        private IWebElement _safeHarborMatch;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) ='K3 - QACA Match']")]
        private IWebElement _QACAMatch;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) ='Y - Safe Harbor Base']")]
        private IWebElement _safeHarborBase;

        [FindsBy(How = How.XPath, Using = "//div[normalize-space(text()) ='Z - Simple']")]
        private IWebElement _simple;

        public MepElection() : base()
        {
            WaitInvisibleElement(_loadingBar);
            WaitVisibleElement(_title);
        }

        public void VerifyContents()
        {
            if (IsElementDisplayed(_approvedByText)) { }
            if (IsElementDisplayed(_effectiveDateText)) { }
            if (IsElementDisplayed(_planEffectiveDateText)) { }
            if (IsElementDisplayed(_terminationDateText)) { }
            if (IsElementDisplayed(_leadOrganizationText)) { }
            if (IsElementDisplayed(_401KText)) { }
            if (IsElementDisplayed(_401KSpecialistText)) { }
            if (IsElementDisplayed(_overviewTab)) { }
            if (IsElementDisplayed(_contributionTab)) { }
            if (IsElementDisplayed(_parentPaygroupText)) { }
            if (IsElementDisplayed(_adoptionAgreementVersionText)) { }
            if (IsElementDisplayed(_planTypeText)) { }
            if (IsElementDisplayed(_eligibilityText)) { }
            if (IsElementDisplayed(_excludeText)) { }
            if (IsElementDisplayed(_minimumAgeText)) { }
            if (IsElementDisplayed(_serviceRequirementText)) { }
            if (IsElementDisplayed(_enrollmentText)) { }
            if (IsElementDisplayed(_autoEnrollPercentageText)) { }
            if (IsElementDisplayed(_annualIncreasePercentageText)) { }
            if (IsElementDisplayed(_allEmployeesText)) { }
            if (IsElementDisplayed(_autoEnrollText)) { }
            if (IsElementDisplayed(_autoEnrollAnnualIncreaseText)) { }
            if (IsElementDisplayed(_grandfatheredEligibilityAgeText)) { }
            if (IsElementDisplayed(_grandfatheredService)) { }
            if (IsElementDisplayed(_complianceText)) { }
            if (IsElementDisplayed(_topHeavyMinimumContributionText)) { }
            if (IsElementDisplayed(_exclutionsText)) { }
            if (IsElementDisplayed(_excludeComissionsText)) { }
            if (IsElementDisplayed(_excludeBonusesText)) { }
            if (IsElementDisplayed(_trueUpText)) { }
            if (IsElementDisplayed(_topPaidGroupText)) { }
            if (IsElementDisplayed(_protectedBenefitsText)) { }
            if (IsElementDisplayed(_inServiceWithdrawalText)) { }
            if (IsElementDisplayed(_inserviceWithdrawalAgeText)) { }
            if (IsElementDisplayed(_moneyPurhcasePlanText)) { }
            if (IsElementDisplayed(_additionalDistributionOptionText)) { }
            if (IsElementDisplayed(_earlyRetirementText)) { }
            if (IsElementDisplayed(_earlyRetirementAgeText)) { }
            if (IsElementDisplayed(_acceleratingVestingScheduleText))
            {
                Logger.screenshot_PASS("All the OVERVIEW page elements are displayed correctly");
            }
            Click(_contributionTab);
            Click(_addEmployerContributionType);
            if (IsElementDisplayed(_discretionaryMatch)) { }
            if (IsElementDisplayed(_discretionaryProfitSharing)) { }
            if (IsElementDisplayed(_QACABase)) { }
            if (IsElementDisplayed(_QACAMatch)) { }
            if (IsElementDisplayed(_safeHarborMatch)) { }
            if (IsElementDisplayed(_safeHarborBase)) { }
            if (IsElementDisplayed(_simple))
            {
                Logger.screenshot_PASS("All the Employment Contribution Types are displayed correctly");
            }
            Click(_discretionaryMatch);
            Click(_401Title);
        }
    }
}
