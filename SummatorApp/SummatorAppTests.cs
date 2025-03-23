using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace SummatorApp
{
    public  class SummatorAppTests 
    {

        private AndroidDriver driver;
        private SummatorPage summatorPage;


        [OneTimeSetUp]

        public void OneTimeSetUp()
        {

            var appiumOptions = new AppiumOptions();

            appiumOptions.PlatformName = "Android";
            appiumOptions.AutomationName = "UiAutomator2";
            appiumOptions.PlatformVersion = "14";
            appiumOptions.DeviceName = "R5CR92WHYBT";
            appiumOptions.App = "C:\\Users\\veron\\Desktop\\com.example.androidappsummator.apk";

            driver = new AndroidDriver(appiumOptions);
            summatorPage = new SummatorPage(driver);


        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void Test_With_ValidData()
        {

            var result = summatorPage.Calculate("5", "10");

            Assert.That(result, Is.EqualTo("15"));

        }

        [Test]
        public void Test_With_InvalidData()
        {
            var result = summatorPage.Calculate("", "10");

            Assert.That(result, Is.EqualTo("error"));
        }

    }
}
