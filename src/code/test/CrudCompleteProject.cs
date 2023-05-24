using AutomarizacionTodolist.src.code.test;
using AutomatizacionTodolist.src.code.page;

namespace AutomatizacionTodolist.src.code.test
{
    [TestClass]
    public class CrudCompleteProject : TestBase
    {

        TaskBoard taskBoard = new TaskBoard();
        DataProject dataProject = new DataProject();
        ProjectTask projectTask = new ProjectTask();



        [TestMethod]
        public void CRUD()
        {
            taskBoard.NewProject();
            dataProject.NewNameProject("TEST");
            dataProject.ChangeColor("Amarillo");
            dataProject.ChangeView("Lista");
            dataProject.ButtonSaveNew();
            Assert.IsTrue(projectTask.SelectProyectDisplayed("TEST"), "Error the project is not visible");
            projectTask.SelectProyect("TEST");
            projectTask.SelectMenuProject();
            projectTask.SelectEditProject();
            dataProject.NewNameProject("TEST-EDIT");
            dataProject.ChangeColor("Rojo");
            dataProject.ChangeView("Lista");
            dataProject.ButtonSaveEdit();
            Assert.IsTrue(projectTask.SelectProyectDisplayed("TEST-EDIT"), "Error the project is not visible");
            projectTask.SelectProyect("TEST-EDIT");
            projectTask.SelectMenuProject();
            projectTask.SelectDeleteProject();
            Assert.IsFalse(projectTask.SelectProyectDisplayed("TEST-EDIT"), "Error the project is visible");
        }
    }
}
