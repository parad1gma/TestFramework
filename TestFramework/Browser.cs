using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFramework
{
    public class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver();

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static IWebDriver Driver
        {
            get { return webDriver; }
        }

        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
    }
}