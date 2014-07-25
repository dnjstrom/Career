using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public class DialogueChain
{
	private LinkedList<Dialogue> _dialogueChain;
	private LinkedListNode<Dialogue> _currentDialogue;

	public DialogueChain(XmlNodeList dialogue)
	{
		_dialogueChain = new LinkedList<Dialogue>();

		foreach (XmlNode node in dialogue)
			_dialogueChain.AddLast(new Dialogue(node.InnerText));

		_currentDialogue = _dialogueChain.First;
	}

	public IEnumerable<Dialogue> GetDialogues()
	{
		foreach (Dialogue dialogue in _dialogueChain)
			yield return dialogue;
	}

	public Dialogue GetNext()
	{
		if (_currentDialogue == null)
		{
			Reset();
			return null;
		}

		Dialogue dialogue = _currentDialogue.Value;
		_currentDialogue = _currentDialogue.Next;
		return dialogue;
	}

	public void Reset()
	{
		_currentDialogue = _dialogueChain.First;
	}
}
