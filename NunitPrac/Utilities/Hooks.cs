using NunitPrac.StepDefinition;
using System.Linq;
using TechTalk.SpecFlow;
using System;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;

namespace NunitPrac.Utilities
{
    [Binding]
    internal class Hooks : BaseClass
    {
        private readonly ScenarioContext scenarioContext;
        private static ExtentTest feature, scenario;
        private static ExtentReports htmlreport;
        private Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        private static void InitializeReports()
        {
            var reports = new ExtentHtmlReporter(Path.Combine(Directory.GetParent(TestContext.CurrentContext.TestDirectory).Parent.Parent + @"//Reports", "index.html"));
            reports.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlreport = new ExtentReports();
            htmlreport.AttachReporter(reports);

        }

        [BeforeFeature]
        private static void BeforeFeature(FeatureContext context)
        {
            feature = htmlreport.CreateTest<Feature>(context.FeatureInfo.Title);
        }
        [BeforeScenario]
        private void BeforeScenario()
        {
            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
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

        [AfterStep]
        private void AfterStep(ScenarioContext context)
        {
            var step = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError == null)
            {

                if (step == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (step == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (step == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                }
            }
            else

            {
                if (step == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.StackTrace);
                }
                else if (step == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.StackTrace);
                }
                else if (step == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.StackTrace);
                }
                else
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.StackTrace);
                }
            }
        }

        [AfterScenario]
        private void AfterScenario()
        {
            htmlreport.Flush();
            if (NUnit.Framework.TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var dir = $@"{Directory.GetParent(NUnit.Framework.TestContext.CurrentContext.TestDirectory).Parent.Parent}/Screenshots";
                Directory.CreateDirectory(dir);
                string PathFile = Path.Combine(Directory.GetParent(NUnit.Framework.TestContext.CurrentContext.TestDirectory).Parent.Parent + @"//Screenshots", "Screenshot" + "_" + DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt).JPG"));
                var screenshot = Driver.TakeScreenshot();
                screenshot.SaveAsFile(PathFile);
                Driver.Dispose();
            }
            else
            {
                Console.WriteLine("Test has passed");
                Driver.Dispose();
            }
        }
    }
}
