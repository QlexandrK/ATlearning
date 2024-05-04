using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_DeleteTask : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Удаление созданной заявки", homePage => DeleteTask(homePage)));
            return caseCollection;
        }

        void DeleteTask(PortalHomePage homePage)
        {
            DateTime dateTime = DateTime.Now;
            string taskName = "Тестовая задача " + dateTime.ToString();
            string tasktDescription = "Описание тестовой задачи " + dateTime.ToString();
            string taskPrice = "5999".ToString();
            string endDate = "20.05.2024".ToString();

            new PortalHomePage()
                .CreateNewTask()//Нажимает Создать заявку
                .TaskName(taskName)//Вводит имя заявки
                .TaskDescription(tasktDescription)//Вводит описание заявки
                .TaskPriceInput(taskPrice)//Вводит стоимость
                .AddDeadlineDate(endDate)//Ввод дэдлайна
                .ChoiseCategory()//Выбор категории
                .CreateTaskButton()//Нажимает Создать заявку
                .UserMainButton();//Нажимает Главную Кнопку чтобы появилось левое меню
            new UkanLeftMenu()
                .OpenTasks()//Открывает страницу с заявками
                .EditTask(taskName)//Кнопка Редактировать заявку
                .DeleteTaskButton()//Кнопка Удалить
                .IsTaskDeleted(taskName);//Проверяет удалилась ли задача
        }
    }
}
