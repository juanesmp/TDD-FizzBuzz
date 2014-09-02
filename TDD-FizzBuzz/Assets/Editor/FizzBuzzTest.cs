using UnityEngine;
using System.Collections;
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

	private void AssertFizzBuzz(int number, string expectedResult)
	{
		string result = fizzBuzz.Convert(number);
		Assert.AreEqual (expectedResult, result);
	}
}
