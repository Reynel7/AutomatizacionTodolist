using OpenQA.Selenium;
using AutomatizacionTodolist.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutomatizacionTodolist.src.code.page;
using AutomarizacionTodolist.src.code.test;

namespace AutomatizacionTodolist.src.code.test
{
    [TestClass]
    public class DeleteProject : TestBase
    {

        ProjectTask projectTask = new ProjectTask();

       
        [TestMethod]
        public void Delete()
        {
            projectTask.SelectProyect("TEST-EDIT");
            projectTask.SelectMenuProject();
            projectTask.SelectDeleteProject();
            Assert.IsFalse(projectTask.SelectProyectDisplayed("TEST-EDIT"), "Error the project is visible");
        }
    }
}
