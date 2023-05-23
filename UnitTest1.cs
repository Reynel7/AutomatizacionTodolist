using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomarizacionTodolist
{
    [TestClass]
    public class UnitTest1
    {

        IWebDriver driver;

        [TestInitialize]
        public void OpenBrowser()
        {
            Console.WriteLine("setup");
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + "/driver/chromedriver.exe");
            driver.Navigate().GoToUrl("https://todoist.com/");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            Console.WriteLine("clean");
            driver.Quit();
        }
        [TestMethod]
        public void TestMethod1()
        {
            // click on login
            driver.FindElement(By.XPath("//a[@href=\"/auth/login\"]")).Click();
            // input email
            driver.FindElement(By.Id("element-0")).SendKeys("bancofie@gmail.com");


            // input password
            driver.FindElement(By.Id("element-3")).SendKeys("Fie123456*");

            // click on login button
            driver.FindElement(By.XPath("//button[@data-gtm-id=\"start-email-login\"]")).Click();
            Thread.Sleep(50000);
            // click on new project
        /*    Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//a[@href=\"/app/projects\"]")))
                .Click()
                .Perform();*/
            IWebElement clickable = driver.FindElement(By.XPath("//a[@href=\"/app/projects\"]"));
            new Actions(driver)
                .ClickAndHold(clickable)
                .Perform();
            Thread.Sleep(7000);
            // new project
            driver.FindElement(By.XPath("//button[@aria-label=\"Añadir proyecto\"]")).Click();
            // input name project
            driver.FindElement(By.Id("edit_project_modal_field_name")).SendKeys("Test1");
            // click on button
            driver.FindElement(By.XPath("//button[@class =\"color_dropdown_toggle form_field_control\"]")).Click();
            // change color
            driver.FindElement(By.XPath("//span[@class = \"color_dropdown_select__name\" and text()=\"Amarillo\"]")).Click();
            // type of view
            driver.FindElement(By.XPath("//div[@class = \"edit_project_modal__view_radio_option\" and text()=\"Lista\"] ")).Click();
            // click button save
            driver.FindElement(By.XPath("//button[@type =\"submit\" and span[contains(text(),\"Añadir\")]]")).Click();
            // button of menu project
            driver.FindElement(By.XPath("//button[@aria-label=\"Menú de opciones del proyecto\"]")).Click();
            // button for edit
            driver.FindElement(By.XPath("//li[@class=\"menu_item icon_menu_item\"]//div[contains(text(),\"Editar proyecto\")]")).Click();
            // button for delete project
            driver.FindElement(By.XPath("//li[@class=\"menu_item icon_menu_item\"]//div[contains(text(),\"Eliminar proyecto\")]")).Click();
            Thread.Sleep(3000);
        }
    }
}