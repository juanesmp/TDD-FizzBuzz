public enum GameState
{
	ChoosingRuleset,
	ChoosingRoundCount,
	Playing,
	Finished
}

public enum Ruleset
{
	FizzBuzz,
	FizzBuzzPop,
}

public class FizzBuzz
{
	private Ruleset ruleset;

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

	public void ChooseRuleset (Ruleset ruleset)
	{
		this.ruleset = ruleset;
		State = GameState.ChoosingRoundCount;
	}

	public void ChooseRoundCount (int roundCount)
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
		if (number % 7 == 0 && ruleset == Ruleset.FizzBuzzPop)
			result += "Pop";
		if (result == string.Empty)
			result = number.ToString ();
		return result;
	}
}
