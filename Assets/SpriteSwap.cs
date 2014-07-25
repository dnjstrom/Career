using UnityEngine;
using System.Collections;

public class SpriteSwap : MonoBehaviour 
{
	private SpriteRenderer _renderer;
	private int dirtyLevel;
	
	void Start () {
		dirtyLevel = GetComponent<Toilet> ().dirtyLevel;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void clean()
	{
		if (dirtyLevel > 0) 
		{		
			GetComponent<Toilet>().clean();
		}
	}
}
