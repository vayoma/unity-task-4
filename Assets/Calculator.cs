using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
	public InputField firstValue;
	public InputField secondValue;
	public Text result;

	public void onClick(Text buttonText)
	{
		result.text = "";
		if (!_isCorrectValues()) { return; }

		float res = 0F;
		int value1 = int.Parse(firstValue.text);
		int value2 = int.Parse(secondValue.text);

		switch (buttonText.text)
		{
			case "+":
				res = value1 + value2;
				break;
			case "-":
				res = value1 - value2;
				break;
			case "*":
				res = value1 * value2;
				break;
			case "/":
				res = (float)value1 / (float)value2;
				break;
		}
		result.text = (res).ToString();
	}

	private bool _isCorrectValues()
	{
		return int.TryParse(firstValue.text, out int value1) && int.TryParse(secondValue.text, out int value2);
	}
}
