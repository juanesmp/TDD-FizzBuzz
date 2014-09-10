public enum GameState
{
	Starting,
	Playing,
	Finished
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

	public int Round 
	{
		get;
		private set;
	}

	public int Score
	{
		get;
		private set;
	}

	public void Start (int roundCount)
	{
		RoundCount = roundCount;
		Round = 1;
		State = GameState.Playing;
	}

	public void AdvanceToNextRound (string answer)
	{
		if (answer == Convert (Round))
			Score++;

		if (Round < RoundCount)
			Round++;
		else
			State = GameState.Finished;
	}

	private string Convert (int number)
	{
		string result = string.Empty;
		if (number % 3 == 0)
			result += "Fizz";
		if (number % 5 == 0)
			result += "Buzz";
		if (number % 7 == 0)
			result += "Pop";
		if (result == string.Empty)
			result = number.ToString ();
		return result;
	}
}
