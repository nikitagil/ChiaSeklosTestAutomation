using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using System.IO;

namespace Framework
{
    internal class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void Initialize()
        {
            driver.Value = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void OpenPage(string url)
        {
            driver.Value.Url = url;
        }

        public static void Quit()
        {
            driver.Value.Quit();
        }

        public static void TakeScreenshot(string testMethodName)
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}/screenshots";
            string screenshotName = $"{screenshotsDirectoryPath}\\scr{testMethodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.png";

            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
        }
    }
}
