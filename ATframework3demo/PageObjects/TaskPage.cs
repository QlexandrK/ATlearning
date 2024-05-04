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
    public class TaskPage : UkanLeftMenu
    {
        /// <summary>
        /// Ввод стоимости задачи
        /// </summary>
        /// <param name="taskPrice"></param>
        /// <returns></returns>
        public TaskPage TaskPriceInput(string taskPrice)
        {
            var taskPriceInput = new WebItem("//input[@id='setPrice']", "Инпут стоимости задачи");
            taskPriceInput.SendKeys(taskPrice);
            return new TaskPage();
        }
        /// <summary>
        /// Ввод описания задачи
        /// </summary>
        /// <param name="coverLetter"></param>
        /// <returns></returns>
        public TaskPage TaskcoverLetter(string coverLetter)
        {
            var coverLetterInput = new WebItem("//textarea[@id='detail__coverLetter']", "Инпут сопроводительного письма");
            coverLetterInput.SendKeys(coverLetter);
            return new TaskPage();
        }
        /// <summary>
        /// Первая кнопка Откликнуться
        /// </summary>
        /// <returns></returns>
        public TaskPage ResponseTask()
        {
            var responseBtn = new WebItem("//button[@class='responseBtn']", "кнопка Откликнуться");
            responseBtn.Click();
            return new TaskPage();
        }
        /// <summary>
        /// Кнопка Откликнуться на задачу (появляется после нажатия на первую кнопку Откликнуться)
        /// </summary>
        /// <returns></returns>
        public TaskPage RespondTaskButton()
        {
            var respondButton = new WebItem("//button[@class='detail__btn']", "кнопка Откликнуться на задачу");
            respondButton.Click();
            return new TaskPage();
        }
        /// <summary>
        /// Кнопка Редактировать задачу
        /// </summary>
        /// <returns></returns>
        public TaskPage EditThisTask()
        {
            var editThisTask = new WebItem("//a[@href=contains(text(), 'Редактировать')]", "кнопка Редактировать задачу");
            editThisTask.Click();
            return new TaskPage();
        }
        /// <summary>
        /// Проверяем сообветсвует ли название и описание задачи (Создалась ли задача)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="name">описание</param>
        /// <returns></returns>
        public bool CheckTaskItems(string text, string name)
        {
            var taskName = new WebItem("//section[@class='detail__header']", "Название задачи найдено и соответсвует");
            var textArea = new WebItem("//div[@class='detail__description']", "Описание задачи соответсвует созданному");
            return textArea.AssertTextContains(text, failMessage: "текст не найден или не соответствует") &&
            taskName.AssertTextContains(name, failMessage: "Название не найдено или не соответствует");
        }
        /// <summary>
        /// кнопка Удалить заявку
        /// </summary>
        /// <returns></returns>
        public TasksListPage DeleteTaskButton()
        {
            var deleteButton = new WebItem("//button[@class='deleteTask']//img", "кнопка Удалить заявку");
            deleteButton.Click();
            return new TasksListPage();
        }
        /// <summary>
        /// Проверка отклика на заявку (Если присутствует кнопка удалить - значит откликнулся)
        /// </summary>
        /// <returns></returns>
        public bool CheckTaskResponse()
        {
            var cancelResponseBtn = new WebItem("//button[@class='task__responseDelete']", "Проверка присутствия кнопки Отменить отклик");
            if(cancelResponseBtn.WaitElementDisplayed())
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
        /// <summary>
        /// Главная кнопка Юзера(нажимаем для появления левого меню)
        /// </summary>
        /// <returns></returns>
        public PortalHomePage UserMainButton()
        {
            var userMainButton = new WebItem("//button[@class='header__userBtn']", "Главная кнопка профиля");
            var userAccauntButton = new WebItem("//a[@class='header__modalLink' and contains(text(), 'Аккаунт')]", "Кнопка Аккаунт (возвращает на главную)");
            userMainButton.Click();
            userAccauntButton.Click();
            return new PortalHomePage();
        }
    }
}
