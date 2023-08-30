using NunitPrac.StepDefinition;
using System.Linq;
using TechTalk.SpecFlow;
using System;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Support.Extensions;

namespace NunitPrac.Utilities
{
    [Binding]
    internal class Hooks : BaseClass
    {
        private readonly ScenarioContext scenarioContext;
        private Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }
        [BeforeScenario]
        private void BeforeScenario()
        {
            if (scenarioContext.ScenarioInfo.Tags.Contains("Chrome"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.ChromeBrowser);
            }
            else if (scenarioContext.ScenarioInfo.Tags.Contains("Edge"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.EdgeBrowser);
            }
            else if (scenarioContext.ScenarioInfo.Tags.Contains("FireFox"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.FireFoxBrowser);
            }
            else
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.HeadlessBrowser);
            }
        }

        [AfterScenario]
        private void AfterScenario()
        {
            if (NUnit.Framework.TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var dir = $@"{Directory.GetParent(NUnit.Framework.TestContext.CurrentContext.TestDirectory).Parent.Parent}/Screenshots";
                Directory.CreateDirectory(dir);
                string PathFile = Path.Combine(Directory.GetParent(NUnit.Framework.TestContext.CurrentContext.TestDirectory).Parent.Parent + @"//Screenshots", "Screenshot" + "_" + DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt).JPG"));
                var screenshot = Driver.TakeScreenshot();
                screenshot.SaveAsFile(PathFile, ScreenshotImageFormat.Jpeg);
            }
            Console.WriteLine("Test has passed");
            Driver.Dispose();
        }
    }
}
