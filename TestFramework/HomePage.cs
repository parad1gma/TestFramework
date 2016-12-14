using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestFramework
{
    public class HomePage
    {
        static string Url = "http://pluralsight.com";
        private static string PageTitle = "Pluralsight | Unlimited Online Developer, IT and Creative Training";

        [FindsBy(How = How.LinkText, Using = "Courses")]
        private IWebElement coursesLink;

        public void GoTo()
        {
            Browser.GoTo(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectCourse(string courseTitle)
        {

            var wait = new WebDriverWait(Browser.Driver, TimeSpan.FromMinutes(1));
            var coursesLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Courses")));

            coursesLink.Click();

            var wait1 = new WebDriverWait(Browser.Driver, TimeSpan.FromMinutes(1));
            var courseLink = wait1.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(courseTitle)));

            courseLink.Click();
        }

        public bool IsAtCoursePage(string courseTitle)
        {
            var coursePage = new CoursePage();
            PageFactory.InitElements(Browser.Driver, coursePage);
            return coursePage.CourseTitle == courseTitle;
        }
    }
}
