using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using atFrameWork2.BaseFramework.LogTools;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATframework3demo.PageObjects
{
    public class TasksListPage
    {
        /// <summary>
        /// Созданная задача в списке задач
        /// </summary>
        /// <param name="taskName"></param>
        /// <returns></returns>
        public TaskPage OpenTask(string taskName)
        {

            var task = new WebItem($"//a[@class='taskViewLink' and contains(text(), '{taskName}')]", "Задача в списке");
            task.Click();
            return new TaskPage();
        }
        /// <summary>
        /// Кнопка Редактировать заявку из списка
        /// </summary>
        /// <param name="taskName"></param>
        /// <returns></returns>
        public TaskPage EditTask(string taskName)
        {

            var editTask = new WebItem($"//a[@class='taskViewLink' and contains(text(), '{taskName}')]/ ../ ..//a[@class='editTask' and contains(text(), 'Редактировать заявку')]", "Редактировать задачу в списке");
            editTask.Click();
            return new TaskPage();
        }

        /// <summary>
        /// Проверяем наличие задачи в списке на странице задач
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsTaskDeleted(string name)
        {
            var CancelResponse = new WebItem($"//td[@data-label='Название проекта' and contains(text(),'{name}')]", "Название задачи");
            if (CancelResponse.WaitElementDisplayed())
            {
                Log.Error("Задача не удалилась, тест не пройден");
                return false;
            }
            else
            {
                Log.Info("Задача удалена");
                return true;
            }
        }
    }
}
