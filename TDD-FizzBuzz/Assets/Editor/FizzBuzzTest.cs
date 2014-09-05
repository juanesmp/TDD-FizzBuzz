using NUnit.Framework;

[TestFixture]
public class FizzBuzzTest 
{
	private FizzBuzz fizzBuzz;

	[SetUp]
	public void Setup ()
	{
		fizzBuzz = new FizzBuzz();
	}

	[Test]
	public void NonFizzBuzzNumberReturnsNumber()
	{
		AssertFizzBuzz(2, "2");
	}

	[Test]
	public void FizzNumberReturnsFizz()
	{
		AssertFizzBuzz(6, "Fizz");
	}

	[Test]
	public void BuzzNumberReturnsBuzz()
	{
		AssertFizzBuzz(20, "Buzz");
	}

	[Test]
	public void FizzBuzzNumberReturnsFizzBuzz()
	{
		AssertFizzBuzz(15, "FizzBuzz");
	}
	
	[Test]
	public void StoresRoundCount()
	{
		fizzBuzz.Start (10);
		Assert.AreEqual (10, fizzBuzz.RoundCount);
	}

	[Test]
	public void GameStateIsStartingBeforeStart()
	{
		Assert.AreEqual (GameState.Starting, fizzBuzz.State);
	}

	[Test]
	public void GameStateIsPlayingAfterStart()
	{
		fizzBuzz.Start (10);
		Assert.AreEqual (GameState.Playing, fizzBuzz.State);
	}

	[Test]
	public void GameStateIsFinishedAfterLastRound()
	{
		fizzBuzz.Start (1);
		fizzBuzz.AdvanceToNextRound ();
		Assert.AreEqual (GameState.Finished, fizzBuzz.State);
	}
	
	[Test]
	public void RoundIsOneAfterStart()
	{
		fizzBuzz.Start (10);
		Assert.AreEqual (1, fizzBuzz.Round);
	}
	
	[Test]
	public void RoundIsIsOneMoreAfterAdvancingARound()
	{
		fizzBuzz.Start (10);
		int initialRound = fizzBuzz.Round;
		fizzBuzz.AdvanceToNextRound ();
		Assert.AreEqual (initialRound + 1, fizzBuzz.Round);
	}

	private void AssertFizzBuzz(int number, string expectedResult)
	{
		string result = fizzBuzz.Convert(number);
		Assert.AreEqual (expectedResult, result);
	}
}
