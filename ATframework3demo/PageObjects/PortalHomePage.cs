using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    public class PortalHomePage : UkanLeftMenu
    {
        public PortalHomePage UserMainButton()
        {
            var userMainButton = new WebItem("//button[@class='header__userBtn']", "Главная кнопка профиля");
            var userAccauntButton = new WebItem("//a[@class='header__modalLink' and contains(text(), 'Аккаунт')]", "Кнопка Аккаунт (возвращает на главную)");
            userMainButton.Click();
            userAccauntButton.Click();
            return new PortalHomePage();
        }
        public ProjectCreationPage CreateNewProject()
        {
            var btnPlus = new WebItem("//button[@class='plus-link']", "Кнопка ПЛЮС");
            var btnCreateProject = new WebItem("//a[@class='create__link' and contains(text(), 'проект')]", "Кнопка Создать проект");
            btnPlus.Click();
            btnCreateProject.Click();
            return new ProjectCreationPage();
        }
        public TaskCreationPage CreateNewTask()
        {
            var btnPlus = new WebItem("//button[@class='plus-link']", "Кнопка ПЛЮС");
            var btnCreateTask = new WebItem("//a[@class='create__link' and contains(text(), 'заявку')]", "Кнопка Создать заявку");
            btnPlus.Click();
            btnCreateTask.Click();
            return new TaskCreationPage();
        }
        public ProfileEditPage ProfileEditButton()
        {
            var profileEditButton = new WebItem("//a[@class='editProfile']", "Кнопка редактирования профиля");
            profileEditButton.Click();
            return new ProfileEditPage();
        }
        public CatalogPage CatalogButton()
        {
            var catalogButton = new WebItem("//a[@id='catalogLink']", "Кнопка перехода на страницу Каталог");
            catalogButton.Click();
            return new CatalogPage();
        }
       /// <summary>
       /// Проверяет соответсвует ли описание профиля введенному
       /// </summary>
       /// <param name="text"></param>
       /// <returns></returns>
        public bool CheckUserInfo(string text)
        {
            var profileInfo = new WebItem($"//p[contains(@class, 'userInfo__bio') and contains(text(), '{text}')]", "Описание профиля успешно изменено");
            return profileInfo.AssertTextContains(text, failMessage: "Описание не найдено или не соответствует");
        }
        /// <summary>
        /// Проверяет соответсвует ли имя профиля введенному
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool CheckUserName(string text)
        {
            var profileName = new WebItem($"//p[contains(@class, 'userInfo__name') and contains(text(), '{text}')]", "Имя профиля успешно изменено");
            return profileName.AssertTextContains(text, failMessage: "Имя не найдено или не соответствует");
        }
    }
}
