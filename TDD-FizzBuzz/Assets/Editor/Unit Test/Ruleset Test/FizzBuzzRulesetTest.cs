using NUnit.Framework;

[TestFixture]
public class FizzBuzzRulesetTest : RulesetTest
{
	private const Ruleset ruleset = Ruleset.FizzBuzz;

	[Test]
	public void AnsweringPopDoesntIncresesScore()
	{
		AssertDontScore(7, "Pop", ruleset);
	}

	[Test]
	public void AnsweringFizzPopDoesntIncresesScore()
	{
		AssertDontScore(21, "FizzPop", ruleset);
	}
	
	[Test]
	public void AnsweringBuzzPopDoesntIncresesScore()
	{
		AssertDontScore(35, "BuzzPop", ruleset);
	}
	
	[Test]
	public void AnsweringFizzBuzzPopDoesntIncresesScore()
	{
		AssertDontScore(105, "FizzBuzzPop", ruleset);
	}
}
