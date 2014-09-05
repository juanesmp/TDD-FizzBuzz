using NUnit.Framework;

[TestFixture]
public class FizzBuzzConverterTest 
{
	private FizzBuzz fizzBuzz;

	[SetUp]
	public void Setup ()
	{
		fizzBuzz = new FizzBuzz();
		fizzBuzz.Start (100);
	}

	[Test]
	public void AnsweringFizzIncreasesScore()
	{
		AssertScore(6, "Fizz");
	}

	[Test]
	public void AnsweringBuzzIncresesScore()
	{
		AssertScore(20, "Buzz");
	}

	[Test]
	public void AnsweringFizzBuzzIncresesScore()
	{
		AssertScore(15, "FizzBuzz");
	}

	private void AssertScore(int number, string answer)
	{
		for (int i = 1; i < number; i++)
			fizzBuzz.AdvanceToNextRound ("");
		fizzBuzz.AdvanceToNextRound (answer);
		Assert.AreEqual (1, fizzBuzz.Score);
	}
}
