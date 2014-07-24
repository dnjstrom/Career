using UnityEngine;
using System.Collections;

public class SpriteSwap : MonoBehaviour 
{
	public Sprite dirty;
	public Sprite clean;

	private SpriteRenderer _renderer;
	
	void Start () {
		_renderer = GetComponent<SpriteRenderer> ();

		_renderer.sprite = dirty;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetSpriteDirty()
	{
		_renderer.sprite = dirty;
	}

	public void SetSpriteClean()
	{
		_renderer.sprite = clean;
	}
}
