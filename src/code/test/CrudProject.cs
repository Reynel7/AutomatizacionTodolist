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
    public class CrudProject : TestBase
    {

        HomePage homePage = new HomePage();
        LoginAccount loginAccount = new LoginAccount();
        TaskBoard taskBoard = new TaskBoard();
        DataProject dataProject = new DataProject();
        ProjectTask projectTask = new ProjectTask();
        public static bool Test1Called;
        public static bool Test2Called;
        public static bool Test3Called;


        [TestMethod]
        public void Create()
        {
            Test1Called = true;
            homePage.ButtonLogIn();
            loginAccount.Login("bancofie@gmail.com", "Fie123456*");
            taskBoard.NewProject();
            dataProject.NewNameProject("TEST");
            dataProject.ChangeColor("Amarillo");
            dataProject.ChangeView("Lista");
            dataProject.ButtonSave();
        //    Assert.IsTrue(principalFrame.GetUserName(), "Error the mail is not visible");
        //    Assert.AreEqual(principalFrame.GetUserNameText(), "testreynel@yopmail.com");


        }
        [TestMethod]
        public void Edit()
        {
            Test2Called = true;
            homePage.ButtonLogIn();
            loginAccount.Login("bancofie@gmail.com", "Fie123456*");
            projectTask.SelectProyect("TEST");
            projectTask.SelectMenuProject();
            projectTask.SelectEditProject();
            dataProject.NewNameProject("TEST-EDIT");
            dataProject.ChangeColor("Rojo");
            dataProject.ChangeView("Lista");
            dataProject.ButtonSave();
        //    projectTask.SelectProyect("TEST-EDIT");
        //    projectTask.SelectMenuProject();
        //    projectTask.SelectDeleteProject();
            //    Assert.IsTrue(principalFrame.GetUserName(), "Error the mail is not visible");
            //    Assert.AreEqual(principalFrame.GetUserNameText(), "testreynel@yopmail.com");
        }
        [TestMethod]
        public void Delete()
        {
            Test3Called = true;
            homePage.ButtonLogIn();
            loginAccount.Login("bancofie@gmail.com", "Fie123456*");
            projectTask.SelectProyect("TEST-EDIT");
            projectTask.SelectMenuProject();
            projectTask.SelectDeleteProject();
            //    Assert.IsTrue(principalFrame.GetUserName(), "Error the mail is not visible");
            //    Assert.AreEqual(principalFrame.GetUserNameText(), "testreynel@yopmail.com");
        }
    }
}
