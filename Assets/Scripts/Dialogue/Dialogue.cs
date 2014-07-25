using UnityEngine;
using System.Collections;

public class Dialogue
{
	public enum DialogueType { Conversation };

	public DialogueType dialogueType;
	public string message;
	public string person;

	public Dialogue(string message, string person = "", DialogueType type = DialogueType.Conversation)
	{
		this.message = message;
		this.person = person;
		this.dialogueType = type;
	}
}
