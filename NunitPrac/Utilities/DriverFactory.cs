using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace NunitPrac.Utilities
{
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(EdgeDriver))]
    abstract class DriverFactory
    {
        protected internal static IWebDriver InitiateWebDriver(string browser)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(
            "--window-size=1920,1080",
            "--allow-insecure-localhost",
            "--headless",
            "--disable-gpu",
            "--no-sandbox"
         );
            IWebDriver driver = null;
            if (browser.Equals(CommonConstants.DriverSettings.FireFoxBrowser))
            {
                driver = new FirefoxDriver(CommonConstants.DriverSettings.BinaryLocationFireFox);
            }
            else if (browser.Equals(CommonConstants.DriverSettings.ChromeBrowser))
            {
                driver = new ChromeDriver(CommonConstants.DriverSettings.BinaryLocationChrome);
            }
            else if (browser.Equals(CommonConstants.DriverSettings.EdgeBrowser))
            {
                driver = new EdgeDriver(CommonConstants.DriverSettings.BinaryLocationEdge);
            }
            else
            {
                driver = new ChromeDriver(CommonConstants.DriverSettings.BinaryLocationChrome, chromeOptions);
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(CommonConstants.DriverSettings.DefaultWaitTime);
            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}
