using NUnit.Framework;

[TestFixture]
public class CommonRulesetTest : RulesetTest
{
	[Test]
	public void AnsweringFizzIncreasesScore([Values(Ruleset.FizzBuzz, Ruleset.FizzBuzzPop)] Ruleset ruleset)
	{
		AssertScore(6, "Fizz", ruleset);
	}

	[Test]
	public void AnsweringBuzzIncresesScore([Values(Ruleset.FizzBuzz, Ruleset.FizzBuzzPop)] Ruleset ruleset)
	{
		AssertScore(20, "Buzz", ruleset);
	}

	[Test]
	public void AnsweringFizzBuzzIncresesScore([Values(Ruleset.FizzBuzz, Ruleset.FizzBuzzPop)] Ruleset ruleset)
	{
		AssertScore(15, "FizzBuzz", ruleset);
	}
}
