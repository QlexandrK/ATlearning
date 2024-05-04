using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATframework3demo.PageObjects
{
    public class ResponsesListPage
    {
        /// <summary>
        /// Раздел Отправленные отклики
        /// </summary>
        /// <returns></returns>
        public ResponsesListPage SendResponsesButton()
        {
            var createButton = new WebItem("//li[@id='sentResponse-btn']", "Отправленные отклики");
            createButton.Click();
            return new ResponsesListPage(); //
        }
        /// <summary>
        /// Раздел Пришедшие отклики
        /// </summary>
        /// <returns></returns>
        public ResponsesListPage ReceivedResponsesButton()
        {
            var createButton = new WebItem("//li[@id='receiveResponse-btn']", "Пришедшие отклики");
            createButton.Click();
            return new ResponsesListPage(); //
        }
        /// <summary>
        /// Проверяем наличие отправленного отклика на странице отправленных откликов
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckSendedResponse(string name)
        {
            var taskName = new WebItem($"//h3[@class='task__responseTitle' and contains(text(), '{name}')]", "Название отправленной заявки");
            return taskName.AssertTextContains(name, failMessage: "Отправленная заявка не найдена или не соответствует");
        }
        /// <summary>
        /// Проверяем наличие отклика на странице входящих откликов
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckReceivedResponse(string name)
        {
            var taskName = new WebItem($"//h3[@class='task__responseTitle' and contains(text(), '{name}')]", "Название пришедшей заявки");
            return taskName.AssertTextContains(name, failMessage: "Пришедшая заявка не найдена или не соответствует");
        }
    }
}
