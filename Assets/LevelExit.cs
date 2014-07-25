using UnityEngine;
using System.Collections;

public class LevelExit : MonoBehaviour {

	public bool levelExit = false;
	public int dirtyLevel = 0;

	void Start () {
	
	}
	
	public void setLevelExit(){
		levelExit = true;
	}

	void Update () {
		if (levelExit)
		{
			//Application.LoadLevel ("Scene_level2");
		}
	}
}
