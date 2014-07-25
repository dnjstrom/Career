using UnityEngine;
using System.Collections;

public class Toilet : Entity {
	
	public int dirtyLevel;

	void Start () {

	}

	void Update () {

	}

	public void clean()
	{
		dirtyLevel -= 1;
	}
}
