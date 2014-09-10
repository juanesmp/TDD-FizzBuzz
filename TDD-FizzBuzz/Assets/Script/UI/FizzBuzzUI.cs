using UnityEngine;
using System.Collections;

public class FizzBuzzUI : MonoBehaviour 
{
	private string roundsCountText = string.Empty;
	private FizzBuzz fizzBuzz = new FizzBuzz();

	private void OnGUI()
	{
		switch (fizzBuzz.State)
		{
		case GameState.Starting:
			DrawWelcomeScreen ();
			break;
		case GameState.Playing:
			DrawGameScreen();
			break;
		case GameState.Finished:
			DrawFinishScreen ();
			break;
		}
	}

	private void DrawWelcomeScreen ()
	{
		Rect labelRect = new Rect(10, 10, 300, 40);
		GUI.Label (labelRect, "Escriba el número de rondas");
		
		Rect textFieldRect = new Rect(10, 50, 300, 40);
		roundsCountText = GUI.TextField (textFieldRect, roundsCountText);
		
		Rect buttonRect = new Rect(10, 90, 300, 40);
		if (GUI.Button (buttonRect, "Empezar"))
		{
			int rounds = int.Parse (roundsCountText);
			fizzBuzz.Start (rounds);
		}
	}

	private void DrawGameScreen ()
	{
		Rect labelRect = new Rect(10, 10, 300, 40);
		GUI.Label (labelRect, "Ronda = " + fizzBuzz.Round.ToString ());

		labelRect.y += labelRect.height;
		GUI.Label (labelRect, "Puntaje = " + fizzBuzz.Score);

		Rect buttonRect = new Rect(10, labelRect.y + labelRect.height, 100, 40);
		DrawResponseButton (buttonRect, fizzBuzz.Round.ToString ());

		buttonRect.y += buttonRect.height + 10;
		DrawResponseButton (buttonRect, "Fizz");
		
		buttonRect.y += buttonRect.height + 10;
		DrawResponseButton (buttonRect, "Buzz");
		
		buttonRect.y += buttonRect.height + 10;
		DrawResponseButton (buttonRect, "Pop");

		buttonRect.y += buttonRect.height + 10;
		DrawResponseButton (buttonRect, "FizzBuzz");
	
		buttonRect.y += buttonRect.height + 10;
		DrawResponseButton (buttonRect, "FizzPop");
	
		buttonRect.y += buttonRect.height + 10;
		DrawResponseButton (buttonRect, "BuzzPop");
		
		buttonRect.y += buttonRect.height + 10;
		DrawResponseButton (buttonRect, "FizzBuzzPop");
	}

	private void DrawResponseButton(Rect rect, string response)
	{
		if (GUI.Button (rect, response))
			fizzBuzz.AdvanceToNextRound (response);
	}

	private void DrawFinishScreen ()
	{
		Rect labelRect = new Rect(10, 10, 300, 40);
		GUI.Label (labelRect, "Fin");

		labelRect.y += labelRect.height;
		GUI.Label (labelRect, "Puntaje = " + fizzBuzz.Score);
	}
}
