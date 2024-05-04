using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_CreateTask : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Создание новой заявки", homePage => CreateTask(homePage)));
            return caseCollection;
        }

        void CreateTask(PortalHomePage homePage)
        {
            DateTime dateTime = DateTime.Now;
            string taskName = "Тестовая задача " + dateTime.ToString();
            string tasktDescription = "Описание тестовой задачи " + dateTime.ToString();
            string taskPrice = "5999";
            string endDate = "20.05.2024";

            new PortalHomePage()
                .CreateNewTask()//Нажимает Создать заявку
                .TaskName(taskName)//Вводит имя заявки
                .TaskDescription(tasktDescription)//Вводит описание заявки
                .TaskPriceInput(taskPrice)//Вводит стоимость
                .AddDeadlineDate(endDate)//Ввод дэдлайна (НУЖНО ПЕРЕДЕЛАТЬ!!!)
                .ChoiseCategory()//Выбор категории
                .CreateTaskButton()//Нажимает Создать заявку
                .CheckTaskItems(taskName, tasktDescription);//Проверяет создалась ли заявка
        }
    }
}