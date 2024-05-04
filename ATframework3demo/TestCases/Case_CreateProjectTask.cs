using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_CreateProjectPost : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Создание нового проекта + создать задачу в проекте", homePage => CreateProjectPost(homePage)));
            return caseCollection;
        }

        void CreateProjectPost(PortalHomePage homePage)
        {
            DateTime dateTime = DateTime.Now;
            string projectName = "Тестовый проект " + dateTime.ToString();
            string projectDescription = "Описание тестового проекта " + dateTime.ToString();
            string taskName = "Тестовая задача " + dateTime.ToString();
            string tasktDescription = "Описание тестовой задачи " + dateTime.ToString();
            string taskPrice = "5999";
            string endDate = "20.05.2024";

            new PortalHomePage()
                .CreateNewProject()//Кнопка Создать проект
                .ProjectName(projectName)//Вводит название проекта
                .ProjectDescription(projectDescription)//Вводит описание проекта
                .CreateProjectButton()//Нажимает Кнопку Создания проекта
                .CreateTasksButton()//Нажимает Создать заявку в детальной странице проекта
                .TaskName(taskName)//Вводит имя заявки
                .TaskDescription(tasktDescription)//Вводит описание заявки
                .TaskPriceInput(taskPrice)//Вводит стоимость
                .AddDeadlineDate(endDate)//Ввод дэдлайна
                .ChoiseCategoryInProject()//Выбор категории
                .CreateTaskButton()//Нажимает Создать заявку
                .OpenProjectsList()//Левое меню Проекты
                .OpenProject(projectName)//Открывает созданный проект
                .ProjectEdit()//Кнопка Редактировать проект
                .ProjectPlan()//Переходит в раздел Планирование
                .CheckTaskInProject();//Проверяет имеется ли заявка на странице с проектами
        }
    }
}