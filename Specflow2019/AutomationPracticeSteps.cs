using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace Specflow2019
{
    [Binding]
    public class AutomationPracticeSteps
    {
        IWebDriver driver = new ChromeDriver(@"C:\driver\chromedriver_win32");

        [Given(@"I am navigated to ""(.*)""")]
        public void GivenIAmNavigatedTo(string p0)
        {
            driver.Url = p0;
        }


        [Given(@"I enter the below information")]
        public void GivenIEnterTheBelowInformation(Table table)
        {
            var tableData = table.CreateDynamicSet();
            foreach (var item in tableData)
            {
                driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys((string)item.FirstName);
                driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys((string)item.LastName);
                driver.FindElement(By.TagName("textarea")).SendKeys((string)item.Address);
            }
        }
    }
}
