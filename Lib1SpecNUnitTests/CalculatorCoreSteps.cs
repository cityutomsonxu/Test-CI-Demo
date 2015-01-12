using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Lib1SpecNUnitTests
{
    [Binding]
    public class CalculatorCoreSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
public void GivenIHaveEnteredIntoTheCalculator(int p0)
{
    Assert.AreEqual(1, 1);
}

        [When(@"I press add")]
public void WhenIPressAdd()
{
    Assert.AreEqual(1, 1);
}

        [Then(@"the result should be (.*) on the screen")]
public void ThenTheResultShouldBeOnTheScreen(int p0)
{
    Assert.AreEqual(1, 1);
}
    }
}
