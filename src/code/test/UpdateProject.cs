using OpenQA.Selenium;
using AutomatizacionTodolist.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutomarizacionTodolist.src.code.test;

namespace AutomatizacionTodolist.src.code.test
{
    [TestClass]
    public class UpdateProject : TestBase
    {

        DataProject dataProject = new DataProject();
        ProjectTask projectTask = new ProjectTask();

        [TestMethod]
        public void Edit()
        {
            projectTask.SelectProyect("TEST");
            projectTask.SelectMenuProject();
            projectTask.SelectEditProject();
            dataProject.NewNameProject("TEST-EDIT");
            dataProject.ChangeColor("Rojo");
            dataProject.ChangeView("Lista");
            dataProject.ButtonSaveEdit();
            Assert.IsTrue(projectTask.SelectProyectDisplayed("TEST-EDIT"), "Error the mail is not visible");
        }
    }
}
