﻿using UnityEngine;
using System.Collections;

public class FizzBuzz
{
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
