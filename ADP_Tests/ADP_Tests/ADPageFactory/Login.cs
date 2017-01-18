using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ADP_Tests.ADP_PageFactory
{

    class Login: AdpAbstractPageFactory
    {
        
        [FindsBy(How = How.Id, Using = "txUserName")]
        private IWebElement _userName;

        [FindsBy(How = How.Id, Using = "txPassword")]
        private IWebElement _password;

        [FindsBy(How = How.Id, Using = "bLogin")]
        private IWebElement _loginButton;


        public Login():base()
        {
        }

        public void LoginToMobile()
        {
            _userName.Clear();
            _userName.SendKeys(TestCredentialsWindow.Username);
            _password.Clear();
            _password.SendKeys(TestCredentialsWindow.Password);
            Click(_loginButton);
        }
    }
}



