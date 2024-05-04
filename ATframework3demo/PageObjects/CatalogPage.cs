using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATframework3demo.PageObjects
{
    public class CatalogPage
    {
       /// <summary>
       /// Наводит на задачу в каталоге и нажимает Подробнее
       /// </summary>
       /// <param name="taskName"></param>
       /// <returns></returns>
        public TaskPage OpenTaskInCatalog(string taskName)
        {
            var taskInList = new WebItem($"//div[@class= 'task__main']/h3[contains(text(), '{taskName}')]", "задача в списке Каталога");
            var taskLink = new WebItem($"//a[@class='task__link' and contains(text(), 'Подробнее')]", "Подробнее");
            taskInList.Hover();
            taskLink.Click();
            return new TaskPage();
        }
    }
}
