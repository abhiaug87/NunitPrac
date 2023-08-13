using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NunitPrac.PageObjects
{
    public class Pageobjects
    {
        internal Pageobjects(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a.btn.btn-success-outline")]
        internal IWebElement registry;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/h2")]
        internal IWebElement registrytitle;

        [FindsBy(How = How.Id, Using = "username")]
        internal IWebElement usrtxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[1]/label")]
        internal IWebElement loginlbl;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[2]/label")]
        internal IWebElement firstnamelbl;

        [FindsBy(How = How.Id, Using = "firstName")]
        internal IWebElement firstnametxt;

        [FindsBy(How = How.Id, Using = "lastName")]
        internal IWebElement lastnametxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[3]/label")]
        internal IWebElement lastnamelbl;

        [FindsBy(How = How.Id, Using = "password")]
        internal IWebElement pwdtxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[4]/label")]
        internal IWebElement pwdlbl;

        [FindsBy(How = How.Id, Using = "confirmPassword")]
        internal IWebElement cnfpwdtxt;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[5]/label")]
        internal IWebElement cnfpwdlbl;

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-default")]
        internal IWebElement submitbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/a")]
        internal IWebElement cancelbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-register/div/div/form/div[6]")]
        internal IWebElement cnfmsg;

        [FindsBy(How = How.CssSelector, Using = "a.navbar-brand")]
        internal IWebElement brandlbl;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/header/div/div/div/div[1]/h1")]
        internal IWebElement title;

        [FindsBy(How = How.CssSelector, Using = "img.img-fluid")]
        internal IWebElement imgmain;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[1]/div/a/img")]
        internal IWebElement img1;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[2]/div/a/img")]
        internal IWebElement img2;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[3]/div/a/img")]
        internal IWebElement img3;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[1]/div/h2")]
        internal IWebElement txt1;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[2]/div/h2")]
        internal IWebElement txt2;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-home/div/div[3]/div/h2")]
        internal IWebElement txt3;

        [FindsBy(How = How.CssSelector, Using = "input.form-control.form-control-sm.input-sm.ng-untouched.ng-pristine.ng-invalid")]
        internal IWebElement loginusrtxt;

        [FindsBy(How = How.CssSelector, Using = "input.form-control.form-control-sm.ng-untouched.ng-pristine.ng-invalid")]
        internal IWebElement loginpwdtxt;

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-success")]
        internal IWebElement loginbtn, votingbtn;

        [FindsBy(How = How.XPath, Using = "//table")]
        internal IWebElement table;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/my-pager/div/div/a[2]")]
        internal IWebElement forward;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/my-pager/div/div/a[1]")]
        internal IWebElement backward;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[2]/a")]
        internal IWebElement car;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[3]/a")]
        internal IWebElement model;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[4]")]
        internal IWebElement rank;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[5]")]
        internal IWebElement vote;

        [FindsBy(How = How.XPath, Using = "//tr[5]/td[6]")]
        internal IWebElement engine;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/div/table/tbody/tr[1]/td[1]/a/img")]
        internal IWebElement firstvote;

        [FindsBy(How = How.Id, Using = "comment")]
        internal IWebElement votingtxtfield;

        [FindsBy(How = How.CssSelector, Using = "p.card-text")]
        internal IWebElement votingmsg;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/header/nav/div/my-login/div/ul/li[3]/a")]
        internal IWebElement logoutbtn;

        [FindsBy(How = How.XPath, Using = "/html/body/my-app/div/main/my-overall/div/div/table/tbody/tr[1]/td[7]/a")]
        internal IWebElement viewmore;

        [FindsBy(How = How.Id, Using = "xl-form-email")]
        internal IWebElement email;

        [FindsBy(How = How.Id, Using = "xl-form-password")]
        internal IWebElement pass;

        [FindsBy(How = How.Id, Using = "xl-form-submit")]
        internal IWebElement loginbutton;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/header/div/div[2]/div/div/button")]
        internal IWebElement addorg;

        [FindsBy(How = How.Name, Using = "OrganisationName")]
        internal IWebElement orgname;

        [FindsBy(How = How.XPath, Using = "//*[@id='industrysearchcombofield-1025-inputEl']")]
        internal IWebElement select;

        [FindsBy(How = How.Id, Using = "simplebutton-1035")]
        internal IWebElement buynow;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/div/div[2]/div[2]/div/footer/button")]
        internal IWebElement proceed;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/div/div[2]/div[2]/div/footer/button[1]")]
        internal IWebElement proceed2;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/div/div[2]/div[1]/div/div/div[1]/label/div/div")]
        internal IWebElement ba;

        [FindsBy(How = How.XPath, Using = "//*[@id='react-app']/section/div[1]/div[4]/a")]
        internal IWebElement done;

        [FindsBy(How = How.CssSelector, Using = "button[data-automationid='payment-confirm-button']")]
        internal IWebElement label;

        [FindsBy(How = How.CssSelector, Using = "button[data-automationid='continueButton']")]
        internal IWebElement cont;

        [FindsBy(How = How.Id, Using = "FirstName")]
        internal IWebElement fname;

        [FindsBy(How = How.Id, Using = "LastName")]
        internal IWebElement lname;

        [FindsBy(How = How.Id, Using = "EmailAddress")]
        internal IWebElement emailid;

        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        internal IWebElement phone;

        [FindsBy(How = How.Id, Using = "LocationCode")]
        internal IWebElement location;

        [FindsBy(How = How.CssSelector, Using = "div.recaptcha-checkbox-border")]
        internal IWebElement captcha;

        [FindsBy(How = How.Id, Using = "TermsAccepted")]
        internal IWebElement terms;

        [FindsBy(How = How.Id, Using = "submitButton")]
        internal IWebElement create;

    }


}
