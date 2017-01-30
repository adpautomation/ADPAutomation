using ADP_Tests.ADP_PageFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADP_Tests.ADPageFactory.WFN
{
    class Login : AdpAbstractPageFactory
    {
        [FindsBy(How = How.Id, Using = "adminLogin")]
        private IWebElement _adminLoginLink;

        [FindsBy(How = How.Id, Using = "USER")]
        private IWebElement _userName;

        [FindsBy(How = How.XPath, Using = "//div[.='Submit']")]
        private IWebElement _submitButton;

        [FindsBy(How = How.Id, Using = "passwordForm:password")]
        private IWebElement _password;


        public Login() : base()
        {
        }

        public void LoginToWFN()
        {
            Click(_adminLoginLink);
            _userName.Clear();
            _userName.SendKeys(TestCredentialsWindow.ValidWfnUsername);
            Click(_submitButton);
            _password.Clear();
            _password.SendKeys(TestCredentialsWindow.ValidWfnPassword);
            StandBy(2);
            Click(_submitButton);
        }
    }
}