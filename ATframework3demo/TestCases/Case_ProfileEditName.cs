using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_ProfileEditName : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Изменение имени пользователя", homePage => ProfileEditName(homePage)));
            return caseCollection;
        }
        void ProfileEditName(PortalHomePage homePage)
        {
            DateTime dateTime = DateTime.Now;
            string profileName = Word(5);

            new PortalHomePage()
                .ProfileEditButton()//Нажимает на кнопку Редактировать профиль
                .ProfileEditName(profileName)//Стирает старое и вводим новое имя профиля
                .ChahgeInfoButton()//Нажимает кнопку Сохранить изменения
                .CheckUserName(profileName);//Проверяет соответствует ли имя
        }
        /// <summary>
        /// Генерирует уникальный набор букв заданного количества
        /// </summary>
        /// <param name="num">количество символов</param>
        /// <returns></returns>
        static string Word(int num)
        {
            Random rand = new Random();
            string alphabet = "абвгдежзийклмнопрстуфхцчьыэюя";
            string word = "";

            for (int i = 0; i < num; i++)
            {
                word += alphabet[rand.Next(alphabet.Length)];
            }
            return word;
        }
    }
}