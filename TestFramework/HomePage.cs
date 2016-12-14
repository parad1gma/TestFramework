using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class HomePage
    {
        static string Url = "http://pluralsight.com";
        private static string PageTitle = "Pluralsight | Unlimited Online Developer, IT and Creative Training";

        [FindsBy(How = How.LinkText, Using = "C# Fundamentals with Visual Studio 2015")]
        private IWebElement courseLink;

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
            Browser.Driver.Navigate().GoToUrl(Url + "/browse/");
            courseLink.Click();
            //Browser.Driver.Navigate().GoToUrl(Url + "/courses/" + courseTitle);
        }

        public bool IsAtCoursePage(string courseTitle)
        {
            var coursePage = new CoursePage();
            PageFactory.InitElements(Browser.Driver, coursePage);

            //var titleSection = Browser.Driver.FindElement(By.ClassName("title"));
            //var titleText = titleSection.FindElement(By.TagName("h2"));
            //return titleText.Text == courseName;

            return coursePage.CourseTitle == courseTitle;
        }
    }
}
