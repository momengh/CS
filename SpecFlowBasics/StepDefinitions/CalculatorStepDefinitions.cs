using System;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine(number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine(number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("Numbers are added");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Console.WriteLine(result);
        }
        [Then(@"a message is displayed")]
        public void ThenAMessageIsDisplayed()
        {
            Console.WriteLine("Passed");
        }
        [Given(@"DIM user is logged in")]
        public void GivenDIMUserIsLoggedIn(Table table)
        {
            dynamic data = table.CreateDynamicSet();

            foreach (dynamic item in data)
            {
                Console.WriteLine("Admin type: " + item.Type);
            }
        }

        [When(@"the DIM user create a new user")]
        public void WhenTheDIMUserCreateANewUser()
        {
            Console.WriteLine("Creating a new user...");
        }

        [Then(@"a new user is created")]
        public void ThenANewUserIsCreated()
        {
            Console.WriteLine("user was created");
        }

    }
}