using UnityEngine;
using System.Collections;
using System.Xml;

public class DialogueManager : MonoBehaviour
{
	public TextAsset dialogueText;

	private AnimationState _anim;
	private GUIText _text;
	//private Dialogue _dialogue;
	private DialogueChain _chain;

	private XmlDocument _xmldoc;

	protected void Awake()
	{
		_anim = GetComponentInChildren<AnimationState>();
		_text = GetComponentInChildren<GUIText>();

		if (_anim == null)
			throw new MissingComponentException("Could not locate Animator for the DialogueBox.");


		//load xml document from text asset
		_xmldoc = new XmlDocument();
		_xmldoc.LoadXml(dialogueText.text);

		XmlNodeList xnList = _xmldoc.SelectNodes("/DialogueSystem/Dialogue[@id='1']/Message");
		_chain = new DialogueChain(xnList);
	}

	protected void Update()
	{
		if (Input.GetKeyUp(KeyCode.Q))
			ShowDialogueBox();
		else if (Input.GetKeyUp(KeyCode.W))
			HideDialogueBox();
		if (Input.GetKeyUp(KeyCode.O))
		{
			Dialogue di = _chain.GetNext();
			if (di == null)
				HideDialogueBox();
			else
				_text.text = di.message;
		}
	}

	protected void ShowDialogueBox()
	{
		_text.enabled = false;
		_anim.SetTrigger("Open", PrintText);
	}

	protected void HideDialogueBox()
	{
		_text.enabled = false;
		_anim.SetTrigger("Close");
	}

	protected void PrintText()
	{
		_text.enabled = true;
		//_text.text = _chain.GetDialogues().GetEnumerator().Current.message;
		_text.text = _chain.GetNext().message;
		//Debug.Log(_text.text);
	}
}
