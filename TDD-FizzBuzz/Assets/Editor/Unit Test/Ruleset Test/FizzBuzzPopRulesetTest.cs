using NUnit.Framework;

[TestFixture]
public class FizzBuzzPopRulesetTest : RulesetTest
{
	private const Ruleset ruleset = Ruleset.FizzBuzzPop;

	[Test]
	public void AnsweringPopIncresesScore()
	{
		AssertScore(7, "Pop", ruleset);
	}

	[Test]
	public void AnsweringFizzPopIncresesScore()
	{
		AssertScore(21, "FizzPop", ruleset);
	}
	
	[Test]
	public void AnsweringBuzzPopIncresesScore()
	{
		AssertScore(35, "BuzzPop", ruleset);
	}
	
	[Test]
	public void AnsweringFizzBuzzPopIncresesScore()
	{
		AssertScore(105, "FizzBuzzPop", ruleset);
	}
}
