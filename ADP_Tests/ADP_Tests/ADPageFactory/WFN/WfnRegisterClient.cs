using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_Tests.ADP_PageFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADPageFactory.WFN
{
   public class WfnRegisterClient: AdpAbstractPageFactory
   {
        private readonly By _step_1_Title = By.XPath("//span[.='Register for Administrator Access']");

        private readonly By _step_2_Title = By.XPath("//span[.='Enter Activation Code']");

        private readonly By _step_4_Title = By.XPath("//span[.='Select Computer Type']");

        [FindsBy(How = How.Id, Using = "createPasswordForm:password")]
        private IWebElement _newPassword;

        [FindsBy(How = How.Id, Using = "createPasswordForm:cPassword")]
        private IWebElement _confirmPassword;

        [FindsBy(How = How.XPath, Using = "//div[@widgetid='registerWizard_tablist_activationCodePane']")]
        private IWebElement _step2;

        [FindsBy(How = How.XPath, Using = "//td[@align='center']")]
        private IWebElement _activationCodeValue;

        [FindsBy(How = How.Id, Using = "acCode")]
        private IWebElement _activationCodeField;

        [FindsBy(How = How.XPath, Using = "//div[@widgetid='registerWizard_tablist_securityQuestionsPane']")]
        private IWebElement _step3;

        [FindsBy(How = How.Id, Using = "tAgreeButton_label")]
        private IWebElement _agreeButton;

        [FindsBy(How = How.Id, Using = "question1")]
        private IWebElement _question1;

        [FindsBy(How = How.Id, Using = "answer1")]
        private IWebElement _answer1;

        [FindsBy(How = How.Id, Using = "question2")]
        private IWebElement _question2;

        [FindsBy(How = How.Id, Using = "answer2")]
        private IWebElement _answer2;

        [FindsBy(How = How.Id, Using = "question3")]
        private IWebElement _question3;

        [FindsBy(How = How.Id, Using = "answer3")]
        private IWebElement _answer3;

        [FindsBy(How = How.XPath, Using = "//div[@widgetid='registerWizard_tablist_computerTypePane']")]
        private IWebElement _step4;

        [FindsBy(How = How.XPath, Using = "//span[@class = 'dijit dijitReset revitWizardControlDone revitButtonHasIcon revitButton3']")]
        private IWebElement _doneButton;

        public WfnRegisterClient() : base()
        {
          WaitVisibleElement(_step_1_Title);   
        }

       public void CreatePassword()
       {
           Click(_newPassword);
           _newPassword.SendKeys("adpadp01");
           Click(_confirmPassword);
           _confirmPassword.SendKeys("adpadp01");
           Click(_step2);
       }

       public void EnterActivationCode()
       {
           WaitVisibleElement(_step_2_Title);
           string code = _activationCodeValue.GetAttribute("innerText");
           Click(_activationCodeField);
           _activationCodeField.SendKeys(code);
            Click(_step3);
       }

       public void QuestionsAnswers()
       {
           Click(_agreeButton);
            StandBy(2);
            Click(_question1);
            _question1.SendKeys("What was your childhood nickname that most people do not know?");
            Click(_answer1);
            _answer1.SendKeys("know");
            Click(_question2);
            _question2.SendKeys("What was the name of your first pet?");
            Click(_answer2);
            _answer2.SendKeys("pet");
            Click(_question3);
            _question3.SendKeys("What was the first and last name of your first manager?");
            Click(_answer3);
            _answer3.SendKeys("manager");
            Click(_step4);
        }

       public void ComputerType()
       {
            WaitVisibleElement(_step_4_Title);
            Click(_doneButton);         
       }     
    }
}
