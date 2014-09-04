using UnityEngine;
using System.Collections;

public class FizzBuzzUI : MonoBehaviour 
{
	private string roundsCountText;
	private FizzBuzz fizzBuzz = new FizzBuzz();

	private void OnGUI()
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
		    Debug.Log ("Empezo con " + rounds);
		}
	}
}
