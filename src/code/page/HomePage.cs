using AutomarizacionTodolist.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionTodolist.src.code.page
{
    public  class HomePage
    {
        public Button logIn = new Button(By.XPath("//a[@href=\"/auth/login\"]"));

        public void ButtonLogIn()
        {
            logIn.Click();
        }
    }
}
