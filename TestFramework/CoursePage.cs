using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestFramework
{
    public class CoursePage
    {
        [FindsBy(How = How.CssSelector, Using = "div.title h2")]
        private IWebElement courseTitle;
        public string CourseTitle
        {
            get
            {
                var wait = new WebDriverWait(Browser.Driver, TimeSpan.FromMinutes(1));
                var courseTitle = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div.title h2")));

                return courseTitle.Text;
            }
        }
    }
}