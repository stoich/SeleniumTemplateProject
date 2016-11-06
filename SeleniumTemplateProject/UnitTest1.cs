using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;

namespace SeleniumTemplateProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchWikipedia()
        {
            var title = "Integration testing";

            // InternetExplorerDriver ieDriver
            InternetExplorerDriver ie = new InternetExplorerDriver(Environment.CurrentDirectory);
            ie.Navigate().GoToUrl("https://www.wikipedia.org/");
            ie.FindElement(By.Id("searchInput")).SendKeys(title);
            ie.FindElement(By.ClassName("pure-button-primary-progressive")).Click();
            var heading = ie.FindElement(By.Id("firstHeading"));
            Assert.AreEqual(heading.Text, title);
            ie.Close();

        }
    }
}
