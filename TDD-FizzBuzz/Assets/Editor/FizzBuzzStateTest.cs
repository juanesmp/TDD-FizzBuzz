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
	public void GameStateIsStartingBeforeStart()
	{
		Assert.AreEqual (GameState.Starting, fizzBuzz.State);
	}
	
	[Test]
	public void GameStateIsFinishedAfterLastRound()
	{
		fizzBuzz.Start (1);
		fizzBuzz.AdvanceToNextRound ("");
		Assert.AreEqual (GameState.Finished, fizzBuzz.State);
	}
	
	[Test]
	public void GameStateIsPlayingAfterStart()
	{
		fizzBuzz.Start (10);
		Assert.AreEqual (GameState.Playing, fizzBuzz.State);
	}
}
