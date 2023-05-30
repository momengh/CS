using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Testing;

public class Tests
{
    IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
}