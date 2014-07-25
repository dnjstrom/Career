using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GUIText))]
public class RelativeFontSize : MonoBehaviour 
{
	public int fontSize = 35;

	private GUIText _text;

	void Start()
	{
		_text = GetComponent<GUIText>();
	}

	void Update()
	{
		_text.fontSize = Screen.width / fontSize;
	}
}
