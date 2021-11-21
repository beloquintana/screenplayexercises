using OpenQA.Selenium;

namespace ScreenPlay.Actions
{
    class Click
    {
        public static void On(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
