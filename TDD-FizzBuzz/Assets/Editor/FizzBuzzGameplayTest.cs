using NUnit.Framework;

[TestFixture]
public class FizzBuzzGameplayTest
{
	private FizzBuzz fizzBuzz;
	
	[SetUp]
	public void Setup ()
	{
		fizzBuzz = new FizzBuzz();
		fizzBuzz.Start (10);
	}

	[Test]
	public void StoresRoundCount()
	{
		Assert.AreEqual (10, fizzBuzz.RoundCount);
	}
	
	[Test]
	public void RoundIsOneAfterStart()
	{
		Assert.AreEqual (1, fizzBuzz.Round);
	}
	
	[Test]
	public void RoundIsIsOneMoreAfterAdvancingARound()
	{
		int initialRound = fizzBuzz.Round;
		fizzBuzz.AdvanceToNextRound ("");
		Assert.AreEqual (initialRound + 1, fizzBuzz.Round);
	}
	
	[Test]
	public void ScoreIsIncreasedIfAnswerIsRight()
	{
		fizzBuzz.AdvanceToNextRound ("1");
		Assert.AreEqual (1, fizzBuzz.Score);
	}
}
