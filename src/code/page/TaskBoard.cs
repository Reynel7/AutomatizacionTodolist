using AutomarizacionTodolist.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionTodolist.src.code.page
{
    public class TaskBoard
    {
        public Button newProject = new Button(By.XPath("//a[@href=\"/app/projects\"]"));
        public Button newProjectPlus = new Button(By.XPath("//button[@aria-label=\"Añadir proyecto\"]"));

        public void NewProject()
        {
            newProject.Click();
            newProjectPlus.Click();
        }
    }
}
