using UnityEngine;
using System.Collections;

public class setSprite : MonoBehaviour {

	private SpriteRenderer _renderer;
	private int dirtyLevel;

	public Sprite dirty1;
	public Sprite dirty2;
	public Sprite dirty3;
	public Sprite dirty4;
	public Sprite dirty5;
	public Sprite clean;

	void Start () {
		_renderer = GetComponent<SpriteRenderer> ();
		_renderer.sprite = dirty4;
	}
	
	// Update is called once per frame
	void Update () {
		dirtyLevel = GetComponent<Toilet> ().dirtyLevel;
		setdLSprite (dirtyLevel);
	}

	public void setdLSprite(int dL)
	{
		if (dirtyLevel == 0) 
		{
			_renderer.sprite = clean;
		} 
		else if (dirtyLevel == 1) 
		{
			_renderer.sprite = dirty1;
		}
		else if (dirtyLevel == 2) 
		{
			_renderer.sprite = dirty2;
		}
		else if (dirtyLevel == 3) 
		{
			_renderer.sprite = dirty3;
		}
		else if (dirtyLevel == 4) 
		{
			_renderer.sprite = dirty4;
		}
		else if (dirtyLevel == 5) 
		{
			_renderer.sprite = dirty5;
		}
	
	}
}
