using UnityEngine;
using System.Collections;

public class DialogueManager : MonoBehaviour 
{
	private AnimationState _anim;
	private GUIText _text;
	string message = "test";

	protected void Awake()
	{
		_anim = GetComponentInChildren<AnimationState>();
		_text = GetComponentInChildren<GUIText>();

		if (_anim == null)
			throw new MissingComponentException("Could not locate Animator for the DialogueBox.");
	}

	protected void Update()
	{
		if (Input.GetKeyUp(KeyCode.Q))
			ShowDialogueBox();
		else if (Input.GetKeyUp(KeyCode.W))
			HideDialogueBox();
	}

    protected void ShowDialogueBox()
    {
		_text.enabled = false;
		_anim.SetTrigger("Open", PrintText);
    }

    protected void HideDialogueBox()
    {
		_text.enabled = false;
		_anim.SetTrigger("Close", PrintText);
	}

	protected void PrintText()
	{
		_text.enabled = true;
		_text.text = message;
	}
}
