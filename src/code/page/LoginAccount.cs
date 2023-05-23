using AutomarizacionTodolist.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionTodolist.src.code.page
{
    public class LoginAccount
    {
        public TextBox email = new TextBox(By.Id("element-0"));
        public TextBox password = new TextBox(By.Id("element-3"));
        public Button loginButton = new Button(By.XPath("//button[@data-gtm-id=\"start-email-login\"]"));

        public void Login(String emailTest, String passwordTest)
        {
            email.SetText(emailTest);
            password.SetText(passwordTest);
            loginButton.Click();
        }

    }
}
