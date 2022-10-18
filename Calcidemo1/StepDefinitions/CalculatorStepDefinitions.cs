using NUnit.Framework;

namespace CalculatorDemo1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        int i, j;
        int ans;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            i = number;
            //throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            j = number;
            //throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"The numbers are {i} and {j}");
            //throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            int actual = i + j;
            Console.WriteLine($"Result is {nameof(ThenTheResultShouldBe)}:{actual}");
            Assert.AreEqual(result, actual);    
            //throw new PendingStepException();
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"The numbers are {i} and {j}");
            //throw new PendingStepException();
        }

        [Then("the output should be (.*)")]
        public void ThenTheOutputShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            int actual = j - i;
            Console.WriteLine($"Result is {nameof(ThenTheOutputShouldBe)}:{actual}");
            Assert.AreEqual(result, actual);
            //throw new PendingStepException();
        }
        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"The numbers are {i} and {j}");
            //throw new PendingStepException();
        }

        [Then("the output1 should be (.*)")]
        public void ThenTheOutput1ShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            int actual = j * i;
            Console.WriteLine($"Result is {nameof(ThenTheOutput1ShouldBe)}:{actual}");
            Assert.AreEqual(result, actual);
            //throw new PendingStepException();
        }


        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"The numbers are {i} and {j}");
            //throw new PendingStepException();
        }

        [Then("the output2 should be (.*)")]
        public void ThenTheOutput2ShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            int a = i / j;
            Console.WriteLine($"Result is {nameof(ThenTheOutput2ShouldBe)}:{a}");
            //throw new PendingStepException();
            Assert.AreEqual(result, a);

        }
    }
}
