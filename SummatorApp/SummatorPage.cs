using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace SummatorApp
{
    public  class SummatorPage
    {

        private readonly AndroidDriver driver;

      public SummatorPage(AndroidDriver driver) 
        {
            this.driver = driver;
        }

        public IWebElement firstField => driver.FindElement(MobileBy.Id("com.example.androidappsummator:id/editText1"));


        public IWebElement secondField => driver.FindElement(MobileBy.Id("com.example.androidappsummator:id/editText2"));

        public IWebElement calcButton => driver.FindElement(MobileBy.ClassName("android.widget.Button"));

        public IWebElement result => driver.FindElement(MobileBy.XPath("//android.widget.EditText[@resource-id=\"com.example.androidappsummator:id/editTextSum\"]"));

        public string Calculate(string num1 , string num2)
        {
            firstField.Clear();
            firstField.SendKeys(num1);


            secondField.Clear();
            secondField.SendKeys(num2);


            calcButton.Click();

            return result.Text;
        }


    }
}
