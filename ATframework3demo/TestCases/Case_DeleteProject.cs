using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_DeleteProject : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Удаление созданного проекта", homePage => DeleteProject(homePage)));
            return caseCollection;
        }

        void DeleteProject(PortalHomePage homePage)
        {
            DateTime dateTime = DateTime.Now;
            string projectName = "Тестовый проект " + dateTime.ToString();
            string projectDescription = "Описание тестового проекта " + dateTime.ToString();

            new PortalHomePage()
                .CreateNewProject()//Кнопка Создать проект
                .ProjectName(projectName)//Вводит название проекта
                .ProjectDescription(projectDescription)//Вводит описание проекта
                .CreateProjectButton()//Нажимает Создать проект
                .OpenProjectsList()//Открывает страницу с проектами
                .OpenProject(projectName)//Открывает созданный проект
                .ProjectEdit()//кнопка Перейти к настройке проекта
                .DeleteProjectButton()//Нажимает Удалить проект, подтверждает удаление
                .IsProjectDeleted(projectName);//Проверяет наличие проекта на странице проектов
        }
    }
}