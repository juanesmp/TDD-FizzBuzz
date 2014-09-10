using NUnit.Framework;

[TestFixture]
public class FizzBuzzConverterTest 
{
	private FizzBuzz fizzBuzz;

	[SetUp]
	public void Setup ()
	{
		fizzBuzz = new FizzBuzz();
		fizzBuzz.ChooseRoundCount (1000);
	}

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
	public void AnsweringPopIncresesScore()
	{
		AssertScore(7, "Pop", Ruleset.FizzBuzzPop);
	}

	[Test]
	public void AnsweringPopDoesntIncresesScore()
	{
		AssertDontScore(7, "Pop", Ruleset.FizzBuzz);
	}

	[Test]
	public void AnsweringFizzBuzzIncresesScore([Values(Ruleset.FizzBuzz, Ruleset.FizzBuzzPop)] Ruleset ruleset)
	{
		AssertScore(15, "FizzBuzz", ruleset);
	}

	[Test]
	public void AnsweringFizzPopIncresesScore()
	{
		AssertScore(21, "FizzPop", Ruleset.FizzBuzzPop);
	}
	
	[Test]
	public void AnsweringBuzzPopIncresesScore()
	{
		AssertScore(35, "BuzzPop", Ruleset.FizzBuzzPop);
	}
	
	[Test]
	public void AnsweringFizzBuzzPopIncresesScore()
	{
		AssertScore(105, "FizzBuzzPop", Ruleset.FizzBuzzPop);
	}

	private void AssertScore(int number, string answer, Ruleset ruleset)
	{
		AssertScore (number, answer, ruleset, true);
	}

	private void AssertDontScore (int number, string answer, Ruleset ruleset)
	{
		AssertScore (number, answer, ruleset, false);
	}

	private void AssertScore(int number, string answer, Ruleset ruleset, bool score)
	{
		fizzBuzz.ChooseRuleset(ruleset);
		
		for (int i = 1; i < number; i++)
			fizzBuzz.AdvanceToNextRound ("");
		
		fizzBuzz.AdvanceToNextRound (answer);
		Assert.AreEqual (score ? 1 :  0, fizzBuzz.Score);
	}
}
