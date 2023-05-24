using AutomarizacionTodolist.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionTodolist.src.code.page
{
    public class ProjectTask
    {
        public Button menuProject = new Button(By.XPath("//button[@aria-label=\"Menú de opciones del proyecto\"]"));
        public Button editProject = new Button(By.XPath("//li[@class=\"menu_item icon_menu_item\"]//div[contains(text(),\"Editar proyecto\")]"));
        public Button deleteProject = new Button(By.XPath("//li[@class=\"menu_item icon_menu_item\"]//div[contains(text(),\"Eliminar proyecto\")]"));
        public Button confirmDelete = new Button(By.XPath("//button[@data-autofocus=\"true\"]"));

        public void SelectProyect(String projectName)
        {
            Button selectProject = new Button(By.XPath("//li[@class=\"iydsj+G\"]//span[contains(text(),'"+projectName+"')]"));
            selectProject.Click();
        }
        public Boolean SelectProyectDisplayed(String projectName)
        {
            Button selectProject = new Button(By.XPath("//li[@class=\"iydsj+G\"]//span[contains(text(),'" + projectName + "')]"));
            return selectProject.IsControlDisplayed();
        }
        public void SelectMenuProject()
        { 
            menuProject.Click();
        }
        public void SelectEditProject()
        {
            editProject.Click();
        }
        public void SelectDeleteProject()
        {
            deleteProject.Click();
            confirmDelete.Click();
        }
    }
}
