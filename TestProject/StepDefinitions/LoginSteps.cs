using QUp.Framework.Base;
using TechTalk.SpecFlow;
using TestProject.Pages;
using TechTalk.SpecFlow.Assist;

namespace TestProject.StepDefinitions
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<HomePage>();
        }

        [Given(@"I see the homepage")]
        public void GivenISeeTheHomepage()
        {
            CurrentPage.As<HomePage>().CheckIfLoginExist();
        }

        [Then(@"I click login")]
        public void ThenIClickLogin()
        {
            CurrentPage.As<HomePage>().ClickLogin();
        }

        [When(@"I enter Username and password")]
        public void WhenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            
            CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
        }

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
           CurrentPage =  CurrentPage.As<LoginPage>().ClickLoginButton();
        }

        [Then(@"I should see the username")]
        public void ThenIShouldSeeTheUsername()
        {
            if (CurrentPage.As<HomePage>().GetLoggedInUser().Contains("admin"))
                System.Console.WriteLine("Login successful");
            else
                System.Console.WriteLine("Unsuccessful login");          
        }
    }
}
