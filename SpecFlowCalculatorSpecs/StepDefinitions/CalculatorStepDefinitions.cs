using SpecFlowCalculator;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowCalculatorSpecs.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();

        private int _result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"an empty string")]
        public void GivenAnEmptyString()
        {
            _calculator.Numbers = "";
        }

        [When(@"the string is calculated")]
        public void WhenTheStringIsCalculated()
        {
            _result = _calculator.Calculate();
        }

        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(int p0)
        {
            _result.Should().Be(p0);
        }

        [Given(@"a string ""(.*)""")]
        public void GivenAString(string p0)
        {
            _calculator.Numbers = p0;
        }

        [Then(@"the calculation of the string throws a NegativeNumberNotAllowed exception")]
        public void ThenTheCalculationOfTheStringThrowsANegativeNumberNotAllowedException()
        {
            _scenarioContext.Pending();
        }
    }
}