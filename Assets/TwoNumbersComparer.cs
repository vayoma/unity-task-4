using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
	public InputField firstValue;
	public InputField secondValue;
	public Text result;

	public void onClick()
	{
		result.text = "";
		if (!_isCorrectValues()) { return; }

		int value1 = int.Parse(firstValue.text);
		int value2 = int.Parse(secondValue.text);

		if      (value1 > value2) { result.text = (value1).ToString(); }
		else if (value1 < value2) { result.text = (value2).ToString(); }
		else { result.text = "Равны"; }
	}

	private bool _isCorrectValues()
	{
		return int.TryParse(firstValue.text, out int value1) && int.TryParse(secondValue.text, out int value2);
	}
}
