﻿using AutomarizacionTodolist.src.code.control;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionTodolist.src.code.page
{
    public class DataProject
    {
        public TextBox newNameProject = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button color = new Button(By.XPath("//button[@class =\"color_dropdown_toggle form_field_control\"]"));
        public Button saveDataNew = new Button(By.XPath("//button[@type =\"submit\"]"));
        public Button saveDataEdit = new Button(By.XPath("//button[@type =\"submit\" and span[contains(text(),\"Guardar\")]]"));

        public void ChangeColor(String newColor)
        {
            color.Click();
            Button changeColor = new Button(By.XPath("//span[@class = \"color_dropdown_select__name\" and text()='"+newColor+"']"));
            changeColor.Click();
        }
        public void ChangeView(String newView)
        {
            Button changeView = new Button(By.XPath("//div[@class = \"edit_project_modal__view_radio_option\" and text()='"+newView+"'] "));
            changeView.Click();
        }

        public void NewNameProject(String newName)
        {
            newNameProject.SetText(newName);
        }
        public void ButtonSaveNew()
        {
            saveDataNew.Click();
        }

        public void ButtonSaveEdit()
        {
            saveDataEdit.Click();
        }

    }
}
