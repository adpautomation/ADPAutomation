using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using System.IO;
using System.Collections;
using System.Drawing.Imaging;
using System.Drawing.Design;
using ADP_SeleniumFramework.resources;
using NUnit.Framework;
using ADP_Tests;

namespace ADP_SeleniumFramework.resources
{
    public class Logger
    {
        private static IWebDriver driver;
        private static String curentTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
        private static String basePath = "C:\\AznariyRamazanov\\TestResults\\";
        [ThreadStatic]
        private static Logger instance = null;
        private static String ReportPath = System.IO.Path.Combine(basePath, ("Report_" + curentTime + "\\"));
        [ThreadStatic]
        public static ExtentReports report;
        private static String testName;
        [ThreadStatic]
        private static ExtentTest test;


        public Logger(String testSuiteName)
        {
            testName = testSuiteName;
        }

        public static Logger getLogger(String testSuiteName)
        {
            if (instance == null)
            {
                instance = new Logger(testSuiteName);
                System.IO.Directory.CreateDirectory(ReportPath);
                String currentTimeStamp = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
                String HTMLReportPath = ReportPath + testSuiteName + "_" + currentTimeStamp + ".html";
                report = new ExtentReports(HTMLReportPath, false, DisplayOrder.NewestFirst);
            }
            return instance;

        }

        public static void startLogger(String name, String description)
        {
            String date = DateTime.Now.ToString("MMMM dd, yyyy");
            String time = DateTime.Now.ToString("HH : mm");
            test = report.StartTest(name, description);
            test.AssignCategory(date, time);
            test.AssignAuthor("Environment:" + " " + "<b>" + BRET_SmokeTestWindow.env + "</b>");
        }
        public static String takeScreenShot()
        {
            String currentTimeStamp = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            String imageAbsolutePath = ReportPath + currentTimeStamp + ".png";
            String imageRelativePath = currentTimeStamp + ".png";
            var fileName = new StringBuilder(imageAbsolutePath);
            var screenShot = ((ITakesScreenshot)webDriver.getDriver(driver)).GetScreenshot();
            screenShot.SaveAsFile(fileName.ToString(), ImageFormat.Png);
            return imageRelativePath;
        }

        public static void screenshot_FAIL(String details)
        {
            test.Log(LogStatus.Fail, test.AddScreenCapture(Logger.takeScreenShot()), "<b><font color = 'red'>" + details + "</font></b>");
        }
        public static void screenshot_PASS(String details)
        {
            test.Log(LogStatus.Pass, test.AddScreenCapture(Logger.takeScreenShot()), details);

        }
        public static void INFO(String details)
        {
            test.Log(LogStatus.Info, details);
        }

        public static void FAIL(String details)
        {
            test.Log(LogStatus.Fail, "<b><font color = 'red'>" + details + "</font></b>");
        }

        public static void PASS(String details)
        {
            test.Log(LogStatus.Pass, details);
        }

        public static void endLogger()
        {
            report.EndTest(test);
       //    report.Flush();
            report.Close();
            webDriver.getDriver(driver).Quit();

        }

        private static DirectoryInfo newFolder()
        {
            DirectoryInfo info = new DirectoryInfo(basePath);
            info.CreateSubdirectory(basePath);
            return info;
        }

        public static void AssertThat(Boolean condition)
        {
            try
            {
                Assert.That(condition);
            }
            catch(AssertionException e)
            {
                Logger.screenshot_FAIL(condition + "is not met");
                Console.WriteLine(e.Message);
            }
        }

        public void AssertSameObjects(object expected, object actual, String message)
        {
            try
            {
                Assert.AreSame(expected, actual, message);
                Console.WriteLine(message);
            }
            catch (AssertionException e)
            {
                Logger.screenshot_FAIL(message + "is not met");
                Console.WriteLine(e.Message);
            }
        }
    }
}