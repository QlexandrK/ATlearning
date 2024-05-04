using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects;

namespace ATframework3demo.PageObjects
{
    public class ProjectCreationPage
    {
        public ProjectCreationPage ProjectName(string projectTitle) 
        {
            var projectName = new WebItem("//input[@class='create__title']", "Инпут названия проекта");
            projectName.SendKeys(projectTitle);
            return new ProjectCreationPage();
        }
        public ProjectCreationPage ProjectDescription(string projectTitle)
        {
            var projectDescription = new WebItem("//input[@class='create__description']", "Инпут описания проекта");
            projectDescription.SendKeys(projectTitle);
            return new ProjectCreationPage();
        }
        public ProjectPage CreateProjectButton()
        {
            var createButton = new WebItem("//button[@class='createBtn']", "кнопка Создать проект");
            createButton.Click();
            return new ProjectPage();
        }
    }
}
