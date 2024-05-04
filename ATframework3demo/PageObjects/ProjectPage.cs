using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.BaseFramework.LogTools;
using ATframework3demo.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATframework3demo.PageObjects
{
    public class ProjectPage : TaskCreationPage
    {
        public ProjectPage ProjectEdit()
        {
            var ProjectEditButton = new WebItem("//a[@class='project__link' and contains(text(), 'настройке проекта')]", "кнопка Перейти к настройке проекта");
            ProjectEditButton.Click();
            return new ProjectPage();
        }
        public ProjectPage ProjectPlan()
        {
            var ProjectPlanButton = new WebItem("//li[@id='plan-btn']", "кнопка Планирование проекта");
            ProjectPlanButton.Click();
            return new ProjectPage(); 
        }
        public ProjectPage EditTasksButton()
        {   
            var editTasksButton = new WebItem("//li[@id='edit-btn']", "кнопка Редактировать заявки в проекте");
            editTasksButton.Click();
            return new ProjectPage(); 
        }
        public ProjectPage AddTasksButton()
        {   
            var addTasksButton = new WebItem("//li[@id='addTask-btn']", "Добавить существующую заявку в проект");
            addTasksButton.Click();
            return new ProjectPage(); 
        }
        public ProjectPage CreateTasksButton()
        {
            var createTasksButton = new WebItem("//li[@id='createTask-btn']", "Создать заявку в проекте");
            createTasksButton.Click();
            return new ProjectPage(); 
        }
        public ProjectsListPage DeleteProjectButton()
        {
            var deleteProjectButton = new WebItem("//li[@id='delete-btn']", "Удалить заявку в проекте");
            var deleteButton = new WebItem("//Button[@class='deleteProject']", "Кнопка удалить");
            deleteProjectButton.Click();
            deleteButton.Click();
            return new ProjectsListPage();//После удаления открывается список проектов
        }
        /// <summary>
        /// Проверка не используется, потому что на странице проекта не выводится его название
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckProjectItems(string name)
        {
            var profileName = new WebItem($"//h2[@class='project__title' and contains(text(), '{name}')]", "Название проекта присутсвует");
            return profileName.AssertTextContains(name, failMessage: "Название не найдено или не соответствует");
        }

        /// <summary>
        /// Проверка присутствия кнопки Удалить задачу, если есть - значит задача в проекте создалась
        /// </summary>
        /// <returns></returns>
        public bool CheckTaskInProject()
        {
            var deleteButton = new WebItem("//input[@class='projectTaskDelete']", "Проверка присутствия кнопки Удалить задачу");
            if (deleteButton.WaitElementDisplayed())
            {
                Log.Info("Отклик совершен, тест пройден");
                return true;
            }
            else
            {
                Log.Error("Отклик не совершен");
                return false;
            }
        }
    }
}
