using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NunitPrac.PageObjects
{
    internal class Pageobjects
    {
        protected internal Pageobjects(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a.btn.btn-success-outline")]
        protected internal IWebElement registry;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/h2")]
        protected internal IWebElement registrytitle;

        [FindsBy(How = How.Id, Using = "username")]
        protected internal IWebElement usrtxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[1]/label")]
        protected internal IWebElement loginlbl;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[2]/label")]
        protected internal IWebElement firstnamelbl;

        [FindsBy(How = How.Id, Using = "firstName")]
        protected internal IWebElement firstnametxt;

        [FindsBy(How = How.Id, Using = "lastName")]
        protected internal IWebElement lastnametxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[3]/label")]
        protected internal IWebElement lastnamelbl;

        [FindsBy(How = How.Id, Using = "password")]
        protected internal IWebElement pwdtxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[4]/label")]
        protected internal IWebElement pwdlbl;

        [FindsBy(How = How.Id, Using = "confirmPassword")]
        protected internal IWebElement cnfpwdtxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[5]/label")]
        protected internal IWebElement cnfpwdlbl;

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-default")]
        protected internal IWebElement submitbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/a")]
        protected internal IWebElement cancelbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[6]")]
        protected internal IWebElement cnfmsg;

        [FindsBy(How = How.CssSelector, Using = "a.navbar-brand")]
        protected internal IWebElement brandlbl;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/header/div/div/div/div[1]/h1")]
        protected internal IWebElement title;

        [FindsBy(How = How.CssSelector, Using = "img.img-fluid")]
        protected internal IWebElement imgmain;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[1]/div/a/img")]
        protected internal IWebElement img1;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[2]/div/a/img")]
        protected internal IWebElement img2;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[3]/div/a/img")]
        protected internal IWebElement img3;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[1]/div/h2")]
        protected internal IWebElement txt1;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[2]/div/h2")]
        protected internal IWebElement txt2;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[3]/div/h2")]
        protected internal IWebElement txt3;

        [FindsBy(How = How.CssSelector, Using = "input.form-control.form-control-sm.input-sm.ng-untouched.ng-pristine.ng-invalid")]
        protected internal IWebElement loginusrtxt;

        [FindsBy(How = How.CssSelector, Using = "input.form-control.form-control-sm.ng-untouched.ng-pristine.ng-invalid")]
        protected internal IWebElement loginpwdtxt;

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-success")]
        protected internal IWebElement loginbtn, votingbtn;

        [FindsBy(How = How.XPath, Using = "//table")]
        protected internal IWebElement table;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/my-pager/div/div/a[2]")]
        protected internal IWebElement forward;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/my-pager/div/div/a[1]")]
        protected internal IWebElement backward;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[2]/a")]
        protected internal IWebElement car;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[3]/a")]
        protected internal IWebElement model;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[4]")]
        protected internal IWebElement rank;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[5]")]
        protected internal IWebElement vote;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[6]")]
        protected internal IWebElement engine;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/div/table/tbody/tr[1]/td[1]/a/img")]
        protected internal IWebElement firstvote;

        [FindsBy(How = How.Id, Using = "comment")]
        protected internal IWebElement votingtxtfield;

        [FindsBy(How = How.CssSelector, Using = "p.card-text")]
        protected internal IWebElement votingmsg;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/header/nav/div/my-login/div/ul/li[3]/a")]
        protected internal IWebElement logoutbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/div/table/tbody/tr[1]/td[7]/a")]
        protected internal IWebElement viewmore;

        [FindsBy(How = How.Id, Using = "xl-form-email")]
        protected internal IWebElement email;

        [FindsBy(How = How.Id, Using = "xl-form-password")]
        protected internal IWebElement pass;

        [FindsBy(How = How.Id, Using = "xl-form-submit")]
        protected internal IWebElement loginbutton;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/header/div/div[2]/div/div/button")]
        protected internal IWebElement addorg;

        [FindsBy(How = How.Name, Using = "OrganisationName")]
        protected internal IWebElement orgname;

        [FindsBy(How = How.XPath, Using = "//*[@id='industrysearchcombofield-1025-inputEl']")]
        protected internal IWebElement select;

        [FindsBy(How = How.Id, Using = "simplebutton-1035")]
        protected internal IWebElement buynow;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/div/div[2]/div[2]/div/footer/button")]
        protected internal IWebElement proceed;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/div/div[2]/div[2]/div/footer/button[1]")]
        protected internal IWebElement proceed2;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/div/div[2]/div[1]/div/div/div[1]/label/div/div")]
        protected internal IWebElement ba;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/section/div[1]/div[4]/a")]
        protected internal IWebElement done;

        [FindsBy(How = How.CssSelector, Using = "button[data-automationid='payment-confirm-button']")]
        protected internal IWebElement label;

        [FindsBy(How = How.CssSelector, Using = "button[data-automationid='continueButton']")]
        protected internal IWebElement cont;

        [FindsBy(How = How.Id, Using = "FirstName")]
        protected internal IWebElement fname;

        [FindsBy(How = How.Id, Using = "LastName")]
        protected internal IWebElement lname;

        [FindsBy(How = How.Id, Using = "EmailAddress")]
        protected internal IWebElement emailid;

        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        protected internal IWebElement phone;

        [FindsBy(How = How.Id, Using = "LocationCode")]
        protected internal IWebElement location;

        [FindsBy(How = How.CssSelector, Using = "div.recaptcha-checkbox-border")]
        protected internal IWebElement captcha;

        [FindsBy(How = How.Id, Using = "TermsAccepted")]
        protected internal IWebElement terms;

        [FindsBy(How = How.Id, Using = "submitButton")]
        protected internal IWebElement create;

    }


}
