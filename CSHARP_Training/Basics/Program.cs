using System;
using System.Collections.Immutable;
using System.Net.Http.Headers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V110.Debugger;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            /* Proxy Example
            ChromeOptions options = new ChromeOptions();
            Proxy proxy = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            proxy.SslProxy = "<HOST:PORT>";
            options.Proxy = proxy;
            options.AddArgument("ignore-certificate-errors");
            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.google.com");
            */

            /* Chrome Options Example
            var chromeOptions = new ChromeOptions();
            chromeOptions.PageLoadStrategy = PageLoadStrategy.None;
            IWebDriver driver = new ChromeDriver(chromeOptions);
            try
            {
                driver.Navigate().GoToUrl("https://example.com");
            }
            finally
            {
                driver.Quit();
            }
            */


            //var chromeOptions = new ChromeOptions();
            //chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            //IWebDriver driver = new ChromeDriver(chromeOptions);
            //try
            //{
            //    driver.Navigate().GoToUrl("https://google.com");
            //}
            //finally
            //{
            //    driver.Quit();
            //}

            //var targetURL = "https://google.com";
            //var searchInput = "Youtube";
            //var chromeOptions = new ChromeOptions();
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(targetURL);

            //var platformName = chromeOptions.PlatformName;
            //var proxy = chromeOptions.Proxy;
            //var browserVersion = chromeOptions.BrowserVersion;
            //Console.WriteLine("Platform name: {0}, Proxy: {1}, Version: {2}", platformName, proxy, browserVersion);

            //var title = driver.Title;
            //Console.WriteLine(title);

            //IWebElement acceptCoockied = driver.FindElement(By.Id("L2AGLb"));
            //acceptCoockied.Click();

            //IWebElement googleSearch = driver.FindElement(By.Id("APjFqb"));
            //googleSearch.SendKeys(searchInput);
            //googleSearch.Submit();

            //IWebElement youtubeLink = driver.FindElement(By.XPath("//href[text() = 'https://www.youtube.com/?gl=CZ&hl=cs']"));
            //youtubeLink.Click();

            Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();
            var numbers = new List<Int16>();
            
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt16(number));

                for (var i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] != numbers[i-1] + 1) 
                }
            }


            
        }
    }

}

