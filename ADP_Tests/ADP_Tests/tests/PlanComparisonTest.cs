using ADP_SeleniumFramework.ADP_PageFactory;
using ADP_SeleniumFramework.resources;
using CsvHelper;
using CsvHelper.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using ADP_SeleniumFramework.resources;
using ADP_Tests;

namespace ADP_SeleniumFramework.tests
{
    public class PlanComparisonTest
    {

        [Test]
        public void getCompanyCode()
        {
            var reader = new StreamReader(File.OpenRead("C:/AznariyRamazanov/JMeter Scripts/ErrorLog.csv"));
            List<string> companyCodes = new List<string>();
            List<string> testStatus = new List<string>();
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                companyCodes.Add(values[0]);
                testStatus.Add(values[1]);
            }
            SmokeTestWindow window = new SmokeTestWindow();
            window.ShowDialog();
            webDriver.getDriver(webDriver.Initialize(webDriver.browser.Remote));
            webDriver.openURL(SmokeTestWindow.env);
            Logger.getLogger("Plan Comparison Test");
           
            Login login = new Login();
            login.LoginToMobile();
            foreach (string companyCode in companyCodes)
            { 
                webDriver.openURL("http://bsg-mobile-dev/dist/#/bobcat/parent-details/EV4/" + companyCode + "/benefits/solutions");
            }
        }      
        }
        }
