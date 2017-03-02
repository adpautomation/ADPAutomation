using System;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace ADP_Tests.resources
{
    public class Logger
    {
        private static IWebDriver _driver;
        private static String _curentTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
        private static String _basePath = "C:\\AznariyRamazanov\\TestResults\\";
        [ThreadStatic]
        private static Logger _instance = null;
        private static String _reportPath = System.IO.Path.Combine(_basePath, ("Report_" + _curentTime + "\\"));
        [ThreadStatic]
        public static ExtentReports Report;
        private static String _testName;
        [ThreadStatic]
        private static ExtentTest _test;


        public Logger(String testSuiteName)
        {
            _testName = testSuiteName;
        }

        public static Logger GetLogger(String testSuiteName)
        {
            if (_instance == null)
            {
                _instance = new Logger(testSuiteName);
                System.IO.Directory.CreateDirectory(_reportPath);
                String currentTimeStamp = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
                String htmlReportPath = _reportPath + testSuiteName + "_" + currentTimeStamp + ".html";
                Report = new ExtentReports(htmlReportPath, false, DisplayOrder.NewestFirst);
            }
            return _instance;

        }

        public static void StartLogger(String name, String description)
        {
            String date = DateTime.Now.ToString("MMMM dd, yyyy");
            String time = DateTime.Now.ToString("HH : mm");
            _test = Report.StartTest(name, description);
            _test.AssignCategory(date, time);
            _test.AssignAuthor("Environment:" + " " + "<b>" + Jenkins.Env() + "</b>");
        }
        public static String TakeScreenShot()
        {
            String currentTimeStamp = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            String imageAbsolutePath = _reportPath + currentTimeStamp + ".png";
            String imageRelativePath = currentTimeStamp + ".png";
            var fileName = new StringBuilder(imageAbsolutePath);
            var screenShot = ((ITakesScreenshot)WebDriver.GetDriver(_driver)).GetScreenshot();
            screenShot.SaveAsFile(fileName.ToString(), ImageFormat.Png);
            return imageRelativePath;
        }

        public static void screenshot_FAIL(String details)
        {
            _test.Log(LogStatus.Fail, _test.AddScreenCapture(Logger.TakeScreenShot()), "<b><font color = 'red'>" + details + "</font></b>");
        }
        public static void screenshot_PASS(String details)
        {
            _test.Log(LogStatus.Pass, _test.AddScreenCapture(Logger.TakeScreenShot()), details);

        }

        public static void screenshot_WARNING(String details)
        {
            _test.Log(LogStatus.Warning, _test.AddScreenCapture(Logger.TakeScreenShot()), details);
        }
        public static void Info(String details)
        {
            _test.Log(LogStatus.Info, details);
        }

        public static void Fail(String details)
        {
            _test.Log(LogStatus.Fail, "<b><font color = 'red'>" + details + "</font></b>");
        }

        public static void Pass(String details)
        {
            _test.Log(LogStatus.Pass, details);
        }

        public static void EndTest()
        {
            Report.EndTest(_test);
        }

        public static void EndLogger()
        {
     //       report.Flush();
     //       report.EndTest(test);   
            Report.Close();
            WebDriver.GetDriver(_driver).Quit();

        }
        public static void CloseWebDriver()
        {
            WebDriver.GetDriver(_driver).Quit();
        }

        private static DirectoryInfo NewFolder()
        {
            DirectoryInfo info = new DirectoryInfo(_basePath);
            info.CreateSubdirectory(_basePath);
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