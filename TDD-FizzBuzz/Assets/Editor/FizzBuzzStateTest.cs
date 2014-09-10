using NUnit.Framework;

[TestFixture]
public class FizzBuzzStateTest
{
	private FizzBuzz fizzBuzz;
	
	[SetUp]
	public void Setup ()
	{
		fizzBuzz = new FizzBuzz();
	}

	[Test]
	public void GameStateIsChoosingRulesetAtStart()
	{
		Assert.AreEqual (GameState.ChoosingRuleset, fizzBuzz.State);
	}

	[Test]
	public void GameStateIsChoosingRoundCountAfterChoosingRuleset()
	{
		fizzBuzz.ChooseRuleset (Ruleset.FizzBuzz);
		Assert.AreEqual (GameState.ChoosingRoundCount, fizzBuzz.State);
	}

	[Test]
	public void GameStateIsPlayingAfterChoosingRoundCount()
	{
		fizzBuzz.ChooseRoundCount (10);
		Assert.AreEqual (GameState.Playing, fizzBuzz.State);
	}

	[Test]
	public void GameStateIsFinishedAfterLastRound()
	{
		fizzBuzz.ChooseRoundCount (1);
		fizzBuzz.AdvanceToNextRound ("");
		Assert.AreEqual (GameState.Finished, fizzBuzz.State);
	}
}
