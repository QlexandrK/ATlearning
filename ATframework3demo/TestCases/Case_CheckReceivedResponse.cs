using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_CheckReceivedResponse : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Проверка наличия ПОСТУПИВШЕГО отклика на странице Отклики", homePage => ReceivedResponse(homePage)));
            return caseCollection;
        }

        void ReceivedResponse(PortalHomePage homePage)
        {
            DateTime dateTime = DateTime.Now;
            string taskName = "Тестовая задача " + dateTime.ToString();
            string tasktDescription = "Описание тестовой задачи " + dateTime.ToString();
            string taskPrice = "5999".ToString();
            string endDate = "20.05.2024".ToString();
            string userLogin = "leon";
            string userPassword = "12345678Q";
            string user1Login = "abram";
            string user2Password = "12345678Q";
            string coverLetter = "Выполню быстро";

            new PortalHomePage()
                .CreateNewTask()//Нажимает Создать заявку
                .TaskName(taskName)//Вводит имя заявки
                .TaskDescription(tasktDescription)//Вводит описание заявки
                .TaskPriceInput(taskPrice)//Вводит стоимость
                .AddDeadlineDate(endDate)//Ввод дэдлайна заявки
                .ChoiseCategory()//Выбор категории
                .CreateTaskButton()//Нажимает Создать заявку
                .UserMainButton()//Нажимает на главную кнопку Юзера (Кнопку нужно вынести в отдельный метод) 
                .ExitButton()//Кнопка ВЫХОД
                .LoginInsideTest(userLogin, userPassword)//Входит под вторым пользователем
                .CatalogButton()//Переходит на страницу Каталог
                .OpenTaskInCatalog(taskName)//Находит задачу в каталоге и входит в нее
                .ResponseTask()//Первая кнопка Откликнуться
                .TaskPriceInput(taskPrice)//Вводит свою стоимость
                .TaskcoverLetter(coverLetter)//Вводит сопроводительное письмо
                .RespondTaskButton()//Нажимает на кнопку Откликнуться на заявку
                .UserMainButton()//Выходит на главную чтобы появилась кнопка выйти
                .ExitButton()//Нажимаем выйти
                .LoginInsideTest(user1Login, user2Password)//Входит под первым пользователем
                .OpenResponses()//Переходит на страницу Отклики
                .ReceivedResponsesButton()//Переходит в раздел Пришедшие отклики 
                .CheckReceivedResponse(taskName);//Проверяет наличие пришедшего отклика
        }
    }
}