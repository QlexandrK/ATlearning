using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using atFrameWork2.BaseFramework.LogTools;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATframework3demo.PageObjects
{
    public class ProjectsListPage
    {
        /// <summary>
        /// Созданный проект в списке - Редактировать
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public ProjectPage OpenProject(string projectName)
        {
            var project = new WebItem($"//td[@data-label='Название проекта' and contains(text(), '{projectName}')]/ ..//td[@data-label='Редактировать' ]", "Проект в списке");
            project.Click();
            return new ProjectPage();
        }
        /// <summary>
        /// Проверяем удалился ли проект в списке на странице проектов
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsProjectDeleted(string name)
        {
            var CancelResponse = new WebItem($"//td[@data-label='Название проекта' and contains(text(),'{name}')]", "Название проекта");
            if(CancelResponse.WaitElementDisplayed())
            {
                Log.Error("Проект не удалился, тест не пройден");
                return false;
            }
            else
            {
                Log.Info("Проект удален");
                return true;
            }
        }
        /// <summary>
        /// Проверяем наличие проекта в списке на странице проектов
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsProjectCreated(string name)
        {
            var CancelResponse = new WebItem($"//td[@data-label='Название проекта' and contains(text(),'{name}')]", "Название проекта");
            if(CancelResponse.WaitElementDisplayed())
            {
                Log.Info("Проект создан");
                return true;
            }
            else
            {
                Log.Error("Проект не создан, тест не пройден");
                return false;
            }
        }
    }
}
