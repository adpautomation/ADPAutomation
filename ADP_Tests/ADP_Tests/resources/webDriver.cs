using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace ADP_Tests.resources
{
    public class WebDriver
    {
        
        [ThreadStatic] private static IWebDriver _driver = null;
        [ThreadStatic] private static WebDriverWait _wait;
        private static String _gridUrl = "http://localhost:4444/wd/hub";
        

        public enum Browser
        {
            GoogleChrome, Firefox, Edge, Remote, Phantom
        }

        private static DesiredCapabilities Caps()
        {
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability(CapabilityType.BrowserName, "chrome");
            return caps;
        }

        public static IWebDriver GetDriver(IWebDriver idriver)
        {
            if(_driver == null)
            {
                idriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                idriver.Manage().Window.Maximize();
            }
            return _driver;
        }


        public static IWebDriver Initialize(Browser browser)
        {
            if (_driver == null)
                switch (browser)
                {
                        case Browser.GoogleChrome:                    
                        _driver = new ChromeDriver(@"C:\AznariyRamazanov\Installed software\ChromeDriver");
                        _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        _driver.Manage().Window.Maximize();
                        break;
                    case Browser.Edge:
                        _driver = new EdgeDriver(@"C:\AznariyRamazanov\Installed software\MicrosoftWebDriver");
                        _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        _driver.Manage().Window.Maximize();
                        break;
                    case Browser.Firefox:
                        _driver = new FirefoxDriver();
                        _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        _driver.Manage().Window.Maximize();
                        break;
                    case Browser.Remote:
                        _driver = new RemoteWebDriver(new Uri(_gridUrl), Caps());
                        _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        _driver.Manage().Window.Maximize();                        
                        break;
                    case Browser.Phantom:
                        _driver = new PhantomJSDriver();
                        _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            return _driver;
        }

        public static void ScrollDown(IWebElement element)
        {
            element.SendKeys(Keys.PageDown);
          //  IJavaScriptExecutor jse = (IJavaScriptExecutor)driverWeb.initDriver(browser.GoogleChrome);
          //  jse.ExecuteScript("window.scrollBy(0, 250)", "");
    }
        public static void ScrollUp(IWebElement element)
        {
            element.SendKeys(Keys.PageDown);
         //   IJavaScriptExecutor jse = (IJavaScriptExecutor)webDriver.Initialize(browser.GoogleChrome);
         //   jse.ExecuteScript("window.scrollBy(0, -250)", "");
        }
        
        public static void HoverOverElement(IWebElement element)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        //The method specifically written fot BenefitsBOB test
        public static void NewTab()
        {
            IJavaScriptExecutor jse = ((IJavaScriptExecutor)_driver);
            jse.ExecuteScript("window.open();");
            /*      String currentTab = driver.CurrentWindowHandle;
                  Actions newTab =  new Actions(driver);
                  newTab.KeyDown(Keys.Control).KeyDown(Keys.Shift).Click(element).KeyUp(Keys.Control).KeyUp(Keys.Shift).Build().Perform(); */
                  var openedTab = _driver.WindowHandles[1];
                  _driver.SwitchTo().Window(openedTab);
        }

        public static void CloseTab()
        {
            String currentTab = _driver.CurrentWindowHandle;
            _driver.SwitchTo().Window(currentTab).Close();
            _driver.SwitchTo().Window(_driver.WindowHandles[0]);

        }

         

        public static void OpenUrl(String url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public static void StandBy(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public static void WaitVisibleText(IWebElement element, String text)
        {

            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            try
            {
                _wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
     //           System.Diagnostics.Debug.Write("element that should contain text" + " " + "<<" + text + ">>" + " " + "is found");
            }
            catch (TimeoutException ex)
            {
                Logger.screenshot_FAIL(ex.Message);
     //           System.Diagnostics.Debug.Write("element that should contain text" + " " + "<<" + text + ">>" + " " + "is not found." +  "The text should be" + " " + "<<" + element.Text + ">>" + " " + "|" + " " + e.Message);
            }
        }
        public static void WaitVisibleElement(By by)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            try
            {
                StandBy(3);
                _wait.Until(ExpectedConditions.ElementIsVisible(by));
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "is visible");
            }
            catch (Exception e)
            {
                Logger.Fail("Element" + " " + by.ToString() + " " + "is not visible");
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " +  "is not found |" + " " + e.Message);
            }
        }
        public static void WaitClickableElement(By by)
        {
            _wait = new WebDriverWait(WebDriver.Initialize(Browser.Remote), TimeSpan.FromSeconds(15));
            try
            {
                StandBy(3);
                _wait.Until(ExpectedConditions.ElementToBeClickable(by));
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "is clickable");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "is not clickable |" + " " + e.Message);
            }
        } 

        public static Boolean IsElementDisplayed(IWebElement element)
        {
            try
            {
                return element.Displayed;

            }
            catch (NoSuchElementException ex)
            {
                Logger.Fail(ex.Message);
                return false;
            }
        }
        public static void Click(IWebElement element)
        {
           for (int i = 0; i < 3; i++)
            {
                if (element.Displayed)
                {
                    _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                    _wait.Until(ExpectedConditions.ElementToBeClickable(element));
                    ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0," + element.Location.Y + ")");
                    element.Click();
                    break;
                }
                else
                {
                    Logger.Info("<b><font color = 'orange'>" + "Temporarily unable to click on" + " " + element.Text + "</font></b>");
                    System.Diagnostics.Debug.Write("Unable to click on" + " " + element.Text);
                }
            }
        }

        public static void ClickAnywhere(IWebDriver driver)
        {
            WebDriver.GetDriver(driver).FindElement(By.XPath("//html")).Click();
        }

        public static void HighLight(IWebDriver driver, IWebDriver element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].style.border='3px solid yellow'", element);
        }

        public static void WaitInvisibleElement(By by)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(90));
            try
            {
                StandBy(1);
                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "has disappeared after 90 seconds of waiting");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("Element" + " " + by.ToString() + " " + "is still visible after 90 seconds of waiting |" + " " + e.Message);
            }
        }
    }
}
