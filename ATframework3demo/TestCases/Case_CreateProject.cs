using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_CreateProject : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Создание нового проекта", homePage => CreateProject(homePage)));
            return caseCollection;
        }

        void CreateProject(PortalHomePage homePage)
        {
            DateTime dateTime = DateTime.Now;
            string projectName = "Тестовый проект " + dateTime.ToString();
            string projectDescription = "Описание тестового проекта " + dateTime.ToString();

            new PortalHomePage()
                .CreateNewProject()//Кнопка Создать проект
                .ProjectName(projectName)//Вводит название проекта
                .ProjectDescription(projectDescription)//Вводит описание проекта
                .CreateProjectButton();//Нажимает Создать проект
            new UkanLeftMenu()
                .OpenProjectsList()//Открывает список проектов
                .IsProjectCreated(projectName);//Проверяет наличие проекта в списке проектов
        }
    }
}