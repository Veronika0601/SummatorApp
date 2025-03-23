# 📱 SummatorApp Automation Tests

This is an automated test suite written in **C#**, using **Appium** and **NUnit**, for testing the Android application **SummatorApp**. The tests validate the app's main functionality by performing UI interactions and verifying its calculation logic.

---

## ⚙️ Technologies Used

- **C#**
- **NUnit**
- **Appium**
- **Selenium Appium WebDriver**
- **Android Emulator / Physical Device**

---

## 🚀 Project Overview

This project automates the testing of **SummatorApp**, an Android application that sums two numbers.  
The tests:
- Enter values in two input fields
- Tap the "Calculate" button
- Validate the result
- Check for proper handling of invalid input

 **Start Appium Server**:
   Open a terminal/command prompt and run:
   appium

   Connect Your Android Device:
   adb devices

Configure Appium Options in SummatorAppTests.cs:
appiumOptions.PlatformName = "Android";
appiumOptions.PlatformVersion = "14";    //  device version
appiumOptions.DeviceName = "R5CR92WHYBT"; // device name
appiumOptions.App = "com.example.androidappsummator.apk""; // Path to APK

Run the Tests
