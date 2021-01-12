using System;
using OpenQA.Selenium.Remote;
using TestProjectSelenium.Code.Extensions;

namespace TestProjectSelenium.Code.Utils
{
    class BrowserScreenshot
    {
        public static void Get(RemoteWebDriver driver, string testType)
        {
            try
            {
                //This was used for nUnit. There are no suchc functionality in xUnit
                //if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed &&
                // TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Skipped)
                //{
                    var testName = testType;
                    var filePath = driver.CreateScreenshot(testName);
                    //var uriBuilder = new UriBuilder(filePath) { Host = Environment.MachineName };
                    //var link = uriBuilder.Uri.ToString().Replace("C:", "C$");
                    Logger.Write($"Check screenshot by following path: {filePath}");
                //}
            }
            catch (Exception e)
            {
                Logger.Write(e);
            }
        }
    }
}
