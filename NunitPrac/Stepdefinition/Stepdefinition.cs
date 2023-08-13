using NUnit.Framework;
using NunitPrac.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using System;
using System.IO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using NunitPrac.Data;

namespace NunitPrac.Stepdefinition
{
    [Binding]
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(EdgeDriver))]
    [Parallelizable]
    internal class Stepdefinition : BaseClass
    {
        private readonly Pageobjects po = new Pageobjects(Driver);
        private readonly WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 5));
        private readonly DataReader Config = new DataReader();

        [Given(@"I am on the main page")]
        private void GivenIAmOnTheMainPage()
        {
            Driver.Navigate().GoToUrl(Config.ReadItem("TestData.json", "url"));
        }


        [Given(@"I click on ""([^""]*)""")]
        private void GivenIClickOn(string register)
        {
            Assert.IsTrue(po.registry.Text.Contains(register), "Text does not match as expected");
            po.registry.Click();
        }


        [When(@"I add my details")]
        private void WhenIAddMyDetails()
        {
            StreamWriter writer = new StreamWriter("..//username.txt");
            Random rnd = new Random();
            int number = rnd.Next(0, 1000000);
            int num = rnd.Next(0, 57);
            char rc = (char)('A' + num);
            var randomuser = "username" + rc + number + "@gmail.com";
            Assert.IsTrue(po.registry.Text.Contains(Config.ReadItem("TestData.json", "registry")), "Text does not match as expected");
            Assert.IsTrue(po.registrytitle.Text.Contains(Config.ReadItem("TestData.json", "registrytitle")), "Text does not match as expected");
            Assert.IsTrue(po.loginlbl.Text.Contains(Config.ReadItem("TestData.json", "loginlbl")), "Text does not match as expected");
            po.usrtxt.SendKeys(randomuser);
            Assert.IsTrue(po.firstnamelbl.Text.Contains(Config.ReadItem("TestData.json", "firstnamelbl")), "Text does not match as expected");
            po.firstnametxt.SendKeys(Config.ReadItem("TestData.json", "firstname"));
            Assert.IsTrue(po.lastnamelbl.Text.Contains(Config.ReadItem("TestData.json", "lastnamelbl")), "Text does not match as expected");
            po.lastnametxt.SendKeys(Config.ReadItem("TestData.json", "lastname"));
            Assert.IsTrue(po.pwdlbl.Text.Contains(Config.ReadItem("TestData.json", "pwdlbl")), "Text does not match as expected");
            po.pwdtxt.SendKeys(Config.ReadItem("TestData.json", "password"));
            Assert.IsTrue(po.cnfpwdlbl.Text.Contains(Config.ReadItem("TestData.json", "cnflbl")), "Text does not match as expected");
            po.cnfpwdtxt.SendKeys(Config.ReadItem("TestData.json", "password"));
            Assert.IsTrue(po.submitbtn.Text.Contains(Config.ReadItem("TestData.json", "registry")), "Text does not match as expected");
            po.submitbtn.Click();
            writer.Write(randomuser);
            writer.Close();
        }

        [Then(@"I see the message ""([^""]*)""")]
        private void ThenISeeTheMessage(string message)
        {
            Assert.IsTrue(po.cnfmsg.Text.Contains(message), "Text does not match as expected");
        }

        [When(@"I click ""([^""]*)""")]
        private void WhenIClick(string cancel)
        {
            Assert.IsTrue(po.cancelbtn.Text.Contains(cancel), "Text does not match as expected");
            po.cancelbtn.Click();
        }


        [Then(@"I am redirected to the main page")]
        [Given(@"I am redirected to the main page")]
        private void ThenIAmRedirectedToTheMainPage()
        {
            Driver.Navigate().GoToUrl(Config.ReadItem("TestData.json", "url"));
            Assert.IsTrue(po.brandlbl.Text.Contains(Config.ReadItem("TestData.json", "brandlbl")), "Text does not match as expected");
            Assert.IsTrue(po.imgmain.Displayed, "Image does not exist");
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[1]/div/a/img")).Displayed);
            Assert.IsTrue(po.img1.Displayed, "Image does not exist");
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[2]/div/a/img")).Displayed);
            Assert.IsTrue(po.img2.Displayed, "Image does not exist");
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[3]/div/a/img")).Displayed);
            Assert.IsTrue(po.img3.Displayed, "Image does not exist");
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[1]/div/h2")).Displayed);
            Assert.IsTrue(po.txt1.Text.Contains(Config.ReadItem("TestData.json", "txt1")), "Text does not match as expected");
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[2]/div/h2")).Displayed);
            Assert.IsTrue(po.txt2.Text.Contains(Config.ReadItem("TestData.json", "txt2")), "Text does not match as expected");
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[3]/div/h2")).Displayed);
            Assert.IsTrue(po.txt3.Text.Contains(Config.ReadItem("TestData.json", "txt3")), "Text does not match as expected");

        }


        [Given(@"I login to the application")]
        private void GivenILoginToTheApplication()
        {
            Assert.IsTrue(po.loginbtn.Text.Contains(Config.ReadItem("TestData.json", "logintxt")), "Text does not match as expected");
            StreamReader reader = new StreamReader("..//username.txt");
            var result = reader.ReadToEnd();
            po.loginusrtxt.SendKeys(result);
            po.loginpwdtxt.SendKeys(Config.ReadItem("TestData.json", "password"));
            po.loginbtn.Click();
        }

        [Given(@"I select my favorite car")]
        private void GivenISelectMyFavoriteCar()
        {
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[3]/div/a/img")).Displayed);
            Assert.IsTrue(po.img3.Displayed, "Image is not displayed");
            po.img3.Click();
            Assert.IsTrue(po.firstvote.Displayed, "Image is not displayed");
            po.firstvote.Click();
        }


        [When(@"I cast a vote for my favorite car")]
        private void WhenICastAVoteForMyFavoriteCar()
        {
            var i = Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-model/div/div[1]/div[3]/div[2]/div[1]/h4/strong")).Text;
            po.votingtxtfield.SendKeys(Config.ReadItem("TestData.json", "carvoting"));
            Assert.IsTrue(po.votingbtn.Text.Contains(Config.ReadItem("TestData.json", "votetxt")), "Text does not match as expected");
            po.votingbtn.Click();
            wait.Until(Driver => Driver.FindElement(By.CssSelector("p.card-text")).Displayed);
            var j = Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-model/div/div[1]/div[3]/div[2]/div[1]/h4/strong")).Text;
            Assert.Greater(j, i);
        }

        [Then(@"I am able to see the message ""([^""]*)""")]
        private void ThenIAmAbleToSeeTheMessage(string message)
        {
            Assert.IsTrue(po.votingmsg.Text.Contains(message), "Text does not match as expected");
        }


        [Given(@"I click on the list of cars")]
        private void GivenIclickonthelistofcars()
        {
            po.img3.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table")).Displayed);
            Assert.IsTrue(po.car.Text.Contains(Config.ReadItem("TestData.json", "car1")), "Text does not match as expected");
            Assert.IsTrue(po.model.Text.Contains(Config.ReadItem("TestData.json", "model1")), "Text does not match as expected");
            Assert.IsTrue(po.rank.Text.Contains(Config.ReadItem("TestData.json", "rank1")), "Text does not match as expected");
            Assert.IsTrue(po.engine.Text.Contains(Config.ReadItem("TestData.json", "engine1")), "Text does not match as expected");
        }


        [When(@"I traverse forward through the pages")]
        private void WhenITraverseForwardThroughThePages()
        {
            po.forward.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table")).Displayed);

            po.forward.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table")).Displayed);

            po.forward.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table")).Displayed);

            po.forward.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table")).Displayed);


        }

        [When(@"I traverse back through the pages")]
        private void WhenITraverseBackThroughThePages()
        {
            po.backward.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table")).Displayed);

            po.backward.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table")).Displayed);

            po.backward.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table")).Displayed);

            po.backward.Click();
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-overall/div/div/table")).Displayed);

        }

        [Then(@"I am able to see the different cars")]
        private void ThenIAmAbleToSeeTheDifferentCars()
        {
            Assert.IsTrue(po.car.Text.Contains(Config.ReadItem("TestData.json", "car1")), "Text does not match as expected");
            Assert.IsTrue(po.model.Text.Contains(Config.ReadItem("TestData.json", "model1")), "Text does not match as expected");
            Assert.IsTrue(po.rank.Text.Contains(Config.ReadItem("TestData.json", "rank1")), "Text does not match as expected");
            Assert.IsTrue(po.engine.Text.Contains(Config.ReadItem("TestData.json", "engine1")), "Text does not match as expected");

        }

        [Then(@"I logout of the application")]
        private void ThenILogoutOfTheApplication()
        {
            Assert.IsTrue(po.logoutbtn.Text.Contains(Config.ReadItem("TestData.json", "logout")), "Text does not match as expected");
            po.logoutbtn.Click();
        }

        [When(@"I proceed to vote")]
        private void WhenIProceedToVote()
        {
            wait.Until(Driver => Driver.FindElement(By.XPath("/html/body/my-app/div/main/my-home/div/div[3]/div/a/img")).Displayed);
            Assert.IsTrue(po.img3.Displayed, "Image is not displayed");
            po.img3.Click();
            Assert.IsTrue(po.firstvote.Displayed, "Image is not displayed");
            Assert.IsTrue(po.viewmore.Text.Contains(Config.ReadItem("TestData.json", "viewmore")), "Text does not match as expected");
            po.viewmore.Click();
            Assert.IsTrue(po.imgmain.Displayed, "Image not displayed");
        }




    }
}

