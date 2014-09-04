public enum GameState
{
	Starting,
	Playing,
}

public class FizzBuzz
{
	public GameState State
	{
		get;
		private set;
	}

	public int RoundCount 
	{
		get;
		private set;
	}

	public void Start (int roundCount)
	{
		RoundCount = roundCount;
	}

	public string Convert (int number)
	{
		if (number % 3 == 0 && number % 5 == 0)
			return "FizzBuzz";
		else if (number % 3 == 0)
			return "Fizz";
		else if (number % 5 == 0)
			return "Buzz";
		else
			return number.ToString ();
	}
}
