using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADP_SeleniumFramework.ADP_PageFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ADP_SeleniumFramework.resources;

namespace ADP_SeleniumFramework.ADP_PageFactory.BenefitsBOB
{
    public class BOB_ParentDetails : ADP_AbstractPageFactory
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "adp-breadcrumb-Parent Details")]
        private IWebElement title;

        [FindsBy(How = How.XPath, Using = "//h3[@class='no-margin ng-binding']")]
        private IWebElement companyName;

        public BOB_ParentDetails() : base()
        {
        }

        public void headerVerification()
        {
            if (companyName.Displayed)
            {
                Console.WriteLine("<<" + companyName.Text + ">>"  + " " + "successfully opened");
            }
            closeTab();
        }
    }
}
