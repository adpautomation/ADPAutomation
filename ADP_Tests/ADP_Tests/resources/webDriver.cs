using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using System.IO;

namespace ADP_SeleniumFramework.resources
{
    public class webDriver
    {
        
        [ThreadStatic] private static IWebDriver driver = null;
        [ThreadStatic] private static WebDriverWait wait;
        private static String Grid_URL = "http://localhost:4444/wd/hub";
        

        public enum browser
        {
            GoogleChrome, Firefox, Edge, Remote, Phantom
        }

        private static DesiredCapabilities caps()
        {
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability(CapabilityType.BrowserName, "chrome");
            return caps;
        }

        public static IWebDriver getDriver(IWebDriver Idriver)
        {
            if(driver == null)
            {
                Idriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                Idriver.Manage().Window.Maximize();
            }
            return driver;
        }


        public static IWebDriver Initialize(browser Browser)
        {
            if (driver == null)
                switch (Browser)
                {
                        case browser.GoogleChrome:                    
                        driver = new ChromeDriver(@"C:\AznariyRamazanov\Installed software\ChromeDriver");
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        driver.Manage().Window.Maximize();
                        break;
                    case browser.Edge:
                        driver = new EdgeDriver(@"C:\AznariyRamazanov\Installed software\MicrosoftWebDriver");
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        driver.Manage().Window.Maximize();
                        break;
                    case browser.Firefox:
                        driver = new FirefoxDriver();
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        driver.Manage().Window.Maximize();
                        break;
                    case browser.Remote:
                        driver = new RemoteWebDriver(new Uri(Grid_URL), caps());
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        driver.Manage().Window.Maximize();                        
                        break;
                    case browser.Phantom:
                        driver = new PhantomJSDriver();
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            return driver;
        }

        public static void scrollDown(IWebElement element)
        {
            element.SendKeys(Keys.PageDown);
          //  IJavaScriptExecutor jse = (IJavaScriptExecutor)driverWeb.initDriver(browser.GoogleChrome);
          //  jse.ExecuteScript("window.scrollBy(0, 250)", "");
    }
        public static void scrollUp(IWebElement element)
        {
            element.SendKeys(Keys.PageDown);
         //   IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver.Initialize(browser.GoogleChrome);
         //   jse.ExecuteScript("window.scrollBy(0, -250)", "");
        }
        
        public static void hoverOverElement(IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        //The method specifically written fot BenefitsBOB test
        public static void newTab()
        {
            IJavaScriptExecutor jse = ((IJavaScriptExecutor)driver);
            jse.ExecuteScript("window.open();");
            /*      String currentTab = driver.CurrentWindowHandle;
                  Actions newTab =  new Actions(driver);
                  newTab.KeyDown(Keys.Control).KeyDown(Keys.Shift).Click(element).KeyUp(Keys.Control).KeyUp(Keys.Shift).Build().Perform(); */
                  var openedTab = driver.WindowHandles[1];
                  driver.SwitchTo().Window(openedTab);
        }

        public static void closeTab()
        {
            String currentTab = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(currentTab).Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);

        }

         

        public static void openURL(String URL)
        {
            driver.Navigate().GoToUrl(URL);
        }

        public static void standBy(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public static void waitVisibleText(IWebElement element, String text)
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            try
            {
                standBy(3);
                wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
                System.Diagnostics.Debug.Write("element that should contain text" + " " + "<<" + text + ">>" + " " + "is found");
            }
            catch (Exception e)
            {
                Logger.screenshot_FAIL(element.Text + " " + "is not found");
                System.Diagnostics.Debug.Write("element that should contain text" + " " + "<<" + text + ">>" + " " + "is not found." +  "The text should be" + " " + "<<" + element.Text + ">>" + " " + "|" + " " + e.Message);
            }
        }
        public static void waitVisibleElement(By by)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            try
            {
                standBy(3);
                wait.Until(ExpectedConditions.ElementIsVisible(by));
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "is visible");
            }
            catch (Exception e)
            {
                Logger.FAIL("Element" + " " + by.ToString() + " " + "is not visible");
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " +  "is not found |" + " " + e.Message);
            }
        }
        public static void waitClickableElement(By by)
        {
            wait = new WebDriverWait(webDriver.Initialize(browser.Remote), TimeSpan.FromSeconds(15));
            try
            {
                standBy(3);
                wait.Until(ExpectedConditions.ElementToBeClickable(by));
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "is clickable");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "is not clickable |" + " " + e.Message);
            }
        } 

        public static Boolean isElementDisplayed(IWebElement element, String message)
        {
            try
            {
                System.Diagnostics.Debug.Write(message + " " + element.Text + " " + "is displayed on the page");
                return element.Displayed;

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Unable to find" + element.Text);
                return false;
            }
        }
        public static void click(IWebElement element)
        {
           for (int i = 0; i < 3; i++)
            {
                if (element.Displayed)
                {
                    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    wait.Until(ExpectedConditions.ElementToBeClickable(element));
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0," + element.Location.Y + ")");
                    element.Click();
                    break;
                }
                else
                {
                    Logger.screenshot_FAIL("Unable to click on" + " " + element.Text);
                    System.Diagnostics.Debug.Write("Unable to click on" + " " + element.Text);
                }
            }
        }

        public static void clickAnywhere(IWebDriver driver)
        {
            webDriver.getDriver(driver).FindElement(By.XPath("//html")).Click();
        }

        public static void highLight(IWebDriver driver, IWebDriver element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].style.border='3px solid yellow'", element);
        }

        public static void waitInvisibleElement(By by)
        {
            wait = new WebDriverWait(webDriver.Initialize(browser.Remote), TimeSpan.FromSeconds(90));
            try
            {
                standBy(1);
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "has disappeared after 90 seconds of waiting");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "is still visible after 90 seconds of waiting |" + " " + e.Message);
            }
        }
    }
}
