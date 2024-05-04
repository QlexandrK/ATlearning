using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    public class UkanLeftMenu
    {
         public UserLinkPage OpenUserLink()
         {
              var btnUserLink = new WebItem("//a[@id='userLink']", "Список заявок");
              btnUserLink.Click();
              return new UserLinkPage();
         }

         public TasksListPage OpenTasks()
         {
              var btnOpenTasks = new WebItem("//a[@id='taskToogle']", "Список заявок");
              btnOpenTasks.Click();
              return new TasksListPage();
         }

         public ProjectsListPage OpenProjectsList()
         {
              var btnOpenProjects = new WebItem("//a[@id='projectToogle']", "Пункт левого меню 'Проекты'");
              btnOpenProjects.Click();
              return new ProjectsListPage();
         }

         public ResponsesListPage OpenResponses()
         {
              var btnOpenProjects = new WebItem("//a[@id='responsesLink']", "Пункт левого меню 'Отклики'");
              btnOpenProjects.Click();
              return new ResponsesListPage();
         }

         public NotificationListPage OpenNotifications()
         {
              var btnOpenNotifications = new WebItem("//a[@id='notificationLink']", "Пункт левого меню 'Уведомления'");
              btnOpenNotifications.Click();
              return new NotificationListPage();
         }

         public CommentsListPage OpenComments()
         {
              var btnOpenComments = new WebItem("//a[@id='commentLink']", "Пункт левого меню 'Отзывы'");
              btnOpenComments.Click();
              return new CommentsListPage();
         }
        public PortalLoginPageInCase ExitButton()
        {
            var exitButton = new WebItem("//a[@class='profile__logOut']", "Кнопка ВЫХОД");
            exitButton.Click();
            return new PortalLoginPageInCase();
        }
    }
}