using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_Tests.ADP_PageFactory;

namespace ADP_Tests.ADP_PageFactory_TotalSolutions
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
            _userName.SendKeys("ramazana");
            _password.Clear();
            _password.SendKeys("ILosha#15121985");
            StandBy(2);
            Click(_loginButton);
        }
    }
}



