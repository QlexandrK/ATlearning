using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using OpenQA.Selenium;
using System.Xml.Linq;

namespace ATframework3demo.PageObjects
{
    public class PortalLoginPageInCase
    {
        public PortalHomePage LoginInsideTest(string userLogin, string userPassword)
        {
            var loginField = new WebItem("//input[@class='modalCard__form_input']", "Поле для ввода логина");
            var pwdField = new WebItem("//input[@class='modalCard__form_input password']", "Поле для ввода пароля");
            loginField.SendKeys(userLogin);
            pwdField.SendKeys(userPassword);
            var profileEditButton = new WebItem("//button[@id='logInButton']", "Кнопка Войти");
            profileEditButton.Click();
            return new PortalHomePage();
        }
    }
}
