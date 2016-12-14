using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanGoToHomePage()
        {
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void CanGoToCoursesPage()
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.SelectCourse("C# Fundamentals with Visual Studio 2015");
            Assert.IsTrue(Pages.HomePage.IsAtCoursePage("C# Fundamentals with Visual Studio 2015"));
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
