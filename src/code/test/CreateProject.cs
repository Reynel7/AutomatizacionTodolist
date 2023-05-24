using OpenQA.Selenium;
using AutomatizacionTodolist.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutomarizacionTodolist.src.code.test;
using System.Text.Json.Serialization;

namespace AutomatizacionTodolist.src.code.test
{
    [TestClass]
    public class CreateProject : TestBase
    {

        TaskBoard taskBoard = new TaskBoard();
        DataProject dataProject = new DataProject();
        ProjectTask projectTask = new ProjectTask();



        [TestMethod]
        public void Create()
        {
            taskBoard.NewProject();
            dataProject.NewNameProject("TEST");
            dataProject.ChangeColor("Amarillo");
            dataProject.ChangeView("Lista");
            dataProject.ButtonSaveNew();
            Assert.IsTrue(projectTask.SelectProyectDisplayed("TEST"), "Error the project is not visible");
        }
    }
}
