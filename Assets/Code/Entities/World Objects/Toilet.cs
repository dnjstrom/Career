using UnityEngine;
using System.Collections;

public class Toilet : Entity {

	public Sprite[] toiletSprite;

	public bool isDirty;
	/*
	void awake()
	{
		toiletSprites = Resources.LoadAll<Sprite> ("toilets");
	}
*/
	void Start () {
		isDirty = true;
		/*
		GameObject toilet = new GameObject ();
		toilet.AddComponent<SpriteRenderer> ();
		toilet.GetComponent<SpriteRenderer> ().sprite = toiletSprites [0];
		toilet.GetComponent<SpriteRenderer>().sprite = toiletSprites[1];
		*/
	}
	
	void cleaningToilet()
	{
		
	}

	void Update () {

	}
}
