using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace Specflow2019
{
    [Binding]
    public class AmazonSteps
    {
        IWebDriver driver = new ChromeDriver(@"E:\Drivers\chromedriver_win32");
        [Given(@"I am navigate to ""(.*)""")]
        public void GivenIAmNavigateTo(string p0)
        {
            driver.Url = p0;
        }

        [Given(@"I have clicked on Sign in link")]
        public void GivenIHaveClickedOnSignInLink()
        {
            IWebElement accountsAndList = driver.FindElement(By.XPath("//*[text()='Account & Lists']"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(accountsAndList).Perform();
            IWebElement signInLink = driver.FindElement(By.ClassName("nav-action-inner"));
            signInLink.Click();
        }


        [When(@"I enter email or phone number ""(.*)""")]
        public void WhenIEnterEmailOrPhoneNumber(Decimal p0)
        {
            string username = Convert.ToString(p0);
            IWebElement emailOrPhoneNumber = driver.FindElement(By.Id("ap_email"));
            emailOrPhoneNumber.SendKeys(username);
        }

        [When(@"I click on continue button")]
        public void WhenIClickOnContinueButton()
        {
            driver.FindElement(By.Id("continue")).Click();
        }

        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            IWebElement password = driver.FindElement(By.Id("ap_password"));
            password.SendKeys("xyz");
        }

        [When(@"I click on Sign in button")]
        public void WhenIClickOnSignInButton()
        {
            driver.FindElement(By.Id("signInSubmit")).Click();
        }


        [Then(@"I should get error message ""(.*)""")]
        public void ThenIShouldGetErrorMessage(string p0)
        {
            IWebElement message = driver.FindElement(By.XPath("//*[@id='auth-error-message-box']/descendant::span"));
            string actualMessage = message.Text;
            Assert.AreEqual(p0, actualMessage);
        }
    }
}
