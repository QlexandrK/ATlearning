using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_ProfileEditDescription : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Изменение описания профиля", homePage => ProfileEditDescription(homePage)));
            return caseCollection;
        }
        void ProfileEditDescription(PortalHomePage homePage)
        {
            DateTime dateTime = DateTime.Now;
            string profileDescription = "Описание профиля изменено " + dateTime.ToString();

            new PortalHomePage()
                .ProfileEditButton()//Нажимает на кнопку Редактировать профиль
                .ProfileEditInput(profileDescription)//Вводит описание профиля(доделать чтобы стирал перед вводом)
                .ChahgeInfoButton()//Нажимает кнопку Сохранить изменения
                .CheckUserInfo(profileDescription);//Проверяет соответствует ли описание
        }
    }
}
