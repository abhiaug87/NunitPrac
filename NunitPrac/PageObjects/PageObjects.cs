using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NunitPrac.PageObjects
{
    public class Pageobjects
    {
        public Pageobjects(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a.btn.btn-success-outline")]
        public IWebElement registry;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/h2")]
        public IWebElement registrytitle;

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement usrtxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[1]/label")]
        public IWebElement loginlbl;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[2]/label")]
        public IWebElement firstnamelbl;

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement firstnametxt;

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement lastnametxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[3]/label")]
        public IWebElement lastnamelbl;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement pwdtxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[4]/label")]
        public IWebElement pwdlbl;

        [FindsBy(How = How.Id, Using = "confirmPassword")]
        public IWebElement cnfpwdtxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[5]/label")]
        public IWebElement cnfpwdlbl;

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-default")]
        public IWebElement submitbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/a")]
        public IWebElement cancelbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[6]")]
        public IWebElement cnfmsg;

        [FindsBy(How = How.CssSelector, Using = "a.navbar-brand")]
        public IWebElement brandlbl;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/header/div/div/div/div[1]/h1")]
        public IWebElement title;

        [FindsBy(How = How.CssSelector, Using = "img.img-fluid")]
        public IWebElement imgmain;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[1]/div/a/img")]
        public IWebElement img1;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[2]/div/a/img")]
        public IWebElement img2;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[3]/div/a/img")]
        public IWebElement img3;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[1]/div/h2")]
        public IWebElement txt1;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[2]/div/h2")]
        public IWebElement txt2;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[3]/div/h2")]
        public IWebElement txt3;

        [FindsBy(How = How.CssSelector, Using = "input.form-control.form-control-sm.input-sm.ng-untouched.ng-pristine.ng-invalid")]
        public IWebElement loginusrtxt;

        [FindsBy(How = How.CssSelector, Using = "input.form-control.form-control-sm.ng-untouched.ng-pristine.ng-invalid")]
        public IWebElement loginpwdtxt;

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-success")]
        public IWebElement loginbtn, votingbtn;

        [FindsBy(How = How.XPath, Using = "//table")]
        public IWebElement table;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/my-pager/div/div/a[2]")]
        public IWebElement forward;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/my-pager/div/div/a[1]")]
        public IWebElement backward;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[2]/a")]
        public IWebElement car;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[3]/a")]
        public IWebElement model;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[4]")]
        public IWebElement rank;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[5]")]
        public IWebElement vote;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[6]")]
        public IWebElement engine;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/div/table/tbody/tr[1]/td[1]/a/img")]
        public IWebElement firstvote;

        [FindsBy(How = How.Id, Using = "comment")]
        public IWebElement votingtxtfield;

        [FindsBy(How = How.CssSelector, Using = "p.card-text")]
        public IWebElement votingmsg;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/header/nav/div/my-login/div/ul/li[3]/a")]
        public IWebElement logoutbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/div/table/tbody/tr[1]/td[7]/a")]
        public IWebElement viewmore;

        [FindsBy(How = How.Id, Using = "xl-form-email")]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "xl-form-password")]
        public IWebElement pass;

        [FindsBy(How = How.Id, Using = "xl-form-submit")]
        public IWebElement loginbutton;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/header/div/div[2]/div/div/button")]
        public IWebElement addorg;

        [FindsBy(How = How.Name, Using = "OrganisationName")]
        public IWebElement orgname;

        [FindsBy(How = How.XPath, Using = "//*[@id='industrysearchcombofield-1025-inputEl']")]
        public IWebElement select;

        [FindsBy(How = How.Id, Using = "simplebutton-1035")]
        public IWebElement buynow;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/div/div[2]/div[2]/div/footer/button")]
        public IWebElement proceed;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/div/div[2]/div[2]/div/footer/button[1]")]
        public IWebElement proceed2;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/div/div[2]/div[1]/div/div/div[1]/label/div/div")]
        public IWebElement ba;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/section/div[1]/div[4]/a")]
        public IWebElement done;

        [FindsBy(How = How.CssSelector, Using = "button[data-automationid='payment-confirm-button']")]
        public IWebElement label;

        [FindsBy(How = How.CssSelector, Using = "button[data-automationid='continueButton']")]
        public IWebElement cont;

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement fname;

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement lname;

        [FindsBy(How = How.Id, Using = "EmailAddress")]
        public IWebElement emailid;

        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        public IWebElement phone;

        [FindsBy(How = How.Id, Using = "LocationCode")]
        public IWebElement location;

        [FindsBy(How = How.CssSelector, Using = "div.recaptcha-checkbox-border")]
        public IWebElement captcha;

        [FindsBy(How = How.Id, Using = "TermsAccepted")]
        public IWebElement terms;

        [FindsBy(How = How.Id, Using = "submitButton")]
        public IWebElement create;

    }


}
