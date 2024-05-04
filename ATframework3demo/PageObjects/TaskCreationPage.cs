using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using System.Xml.Linq;

namespace ATframework3demo.PageObjects
{
    public class TaskCreationPage : UkanLeftMenu
       {
        /// <summary>
        /// Ввод названия задачи
        /// </summary>
        /// <param name="taskName"></param>
        /// <returns></returns>
        public TaskCreationPage TaskName(string taskName)
        {
            var taskNameInput = new WebItem("//input[@id='createTitle']", "Инпут названия задачи");
            taskNameInput.SendKeys(taskName);
            return new TaskCreationPage();
        }
        /// <summary>
        /// Ввод описания задачи
        /// </summary>
        /// <param name="tasktDescription"></param>
        /// <returns></returns>
        public TaskCreationPage TaskDescription(string tasktDescription)
        {
            var taskDescription = new WebItem("//textarea[@id='taskDescription']", "Инпут описания задачи");
            taskDescription.SendKeys(tasktDescription);
            return new TaskCreationPage();
        }
        /// <summary>
        /// Ввод стоимости задачи
        /// </summary>
        /// <param name="taskPrice"></param>
        /// <returns></returns>
        public TaskCreationPage TaskPriceInput(string taskPrice)
        {
            var taskPriceInput = new WebItem("//input[@id='createMaxPrice']", "Инпут стоимости задачи");
            taskPriceInput.SendKeys(taskPrice);
            return new TaskCreationPage();
        }
        /// <summary>
        /// Ввод крайнего срока
        /// </summary>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public TaskCreationPage AddDeadlineDate(string endDate)
        {
            var deadLineInput = new WebItem("//input[@id='deadline']", "Инпут крайнего срока");
            deadLineInput.SendKeys(endDate);
            return new TaskCreationPage();
        }
        /// <summary>
        /// Выбор категории заявки
        /// </summary>
        /// <returns></returns>
        public TaskCreationPage ChoiseCategoryInProject()
        {
            var selectButton = new WebItem("//input[@value='7']", "Выбор категории заявки");
            selectButton.Click();
            return new TaskCreationPage();
        }
       /// <summary>
       /// Выбор категории заявки при создании проекта
       /// </summary>
       /// <returns></returns>
        public TaskCreationPage ChoiseCategory()
        {
            var createCategity = new WebItem("//select[@class='create__category']", "Клик на всплыв окно категории заявки");
            var selectButton = new WebItem("//option[@value='7']", "Выбор категории заявки");
            createCategity.Click();
            selectButton.Click();
            return new TaskCreationPage();
        }
        /// <summary>
        /// Кнопка Создать задачу
        /// </summary>
        /// <returns></returns>
        public TaskPage CreateTaskButton()
        {
            var createButton = new WebItem("//button[@class='createBtn']", "кнопка Создать задачу");
            createButton.Click();
            return new TaskPage(); //Открывает созданную заявку
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
    }
}
