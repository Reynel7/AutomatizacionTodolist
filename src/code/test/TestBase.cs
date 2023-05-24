using AutomatizacionTodolist.src.code.page;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomarizacionTodolist.src.code.test
{
    [TestClass]
    public class TestBase
    {
        HomePage homePage = new HomePage();
        LoginAccount loginAccount = new LoginAccount();

        [TestInitialize]
        public void Precondition()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://todoist.com/es");
            homePage.ButtonLogIn();
            loginAccount.Login("bancofie@gmail.com", "Fie123456*");

        }

        [TestCleanup]
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }
    }
}
