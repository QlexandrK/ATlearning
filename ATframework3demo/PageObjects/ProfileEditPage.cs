using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects
{
    public class ProfileEditPage
    {
        /// <summary>
        /// //Ввод описания профиля
        /// </summary>
        /// <param name="profileDescription"></param>
        /// <returns></returns>
        public ProfileEditPage ProfileEditInput(string profileDescription) 
        {   
            var profileDataEdit = new WebItem("//textarea[@class='editData__bio']", "Инпут описания профиля");
            EntityEdit(profileDataEdit, profileDescription);
            return new ProfileEditPage();
        }
        /// <summary>
        /// Стирает и меняет имя профиля
        /// </summary>
        /// <param name="profileName"></param>
        /// <returns></returns>
        public ProfileEditPage ProfileEditName(string profileName)
        {   
            var profileNameEdit = new WebItem("//input[@name='userName']", "Инпут имени профиля");
            EntityEdit(profileNameEdit, profileName);
            return new ProfileEditPage();
        }
        /// <summary>
        /// Кнопка Изменить основную информация
        /// </summary>
        /// <returns></returns>
        public PortalHomePage ChahgeInfoButton()
        {   
            var changeButton = new WebItem("//button[contains(text(), 'Изменить основную информацию')]", "кнопка Изменить основную информация");
            changeButton.Click();
            return new PortalHomePage(); //Открывает основную страницу
        }
        /// <summary>
        /// Выделяет и стирает текст
        /// </summary>
        /// <param name="webItem"></param>
        /// <param name="name"></param>
        private static void EntityEdit(WebItem webItem, string name)
        {
            webItem.SendKeys(Keys.Control + 'A' + Keys.Backspace);
            webItem.SendKeys(name);
        }
    }
}
