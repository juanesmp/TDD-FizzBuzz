using NUnit.Framework;

public class RulesetTest
{
	private FizzBuzz fizzBuzz;

	[SetUp]
	public virtual void Setup ()
	{
		fizzBuzz = new FizzBuzz();
		fizzBuzz.ChooseRoundCount (1000);
	}

	protected void AssertScore(int number, string answer, Ruleset ruleset)
	{
		AssertScore (number, answer, ruleset, true);
	}
	
	protected void AssertDontScore (int number, string answer, Ruleset ruleset)
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
