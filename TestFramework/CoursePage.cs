using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class CoursePage
    {
        [FindsBy(How = How.CssSelector, Using = "div.title h2")]
        private IWebElement courseTitle;
        public string CourseTitle
        {
            get { return courseTitle.Text; }
        }
    }
}