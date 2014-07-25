using UnityEngine;
using System.Collections;

public class CheckChildren : MonoBehaviour {

	public bool nextLevel = false;
	private int cleaned = 0;

	void Start () {

	}

	void checkCleaned(){
		int children = transform.childCount;
		for (int i = 0; i < children; i++) {
			try{
				if (transform.GetChild (i).gameObject.GetComponent<Toilet>().dirtyLevel <= 0) {
					cleaned += 1;
				}
			} catch{

			}

		}
		if (cleaned == 7) {
			nextLevel = true;
			transform.GetChild(7).gameObject.GetComponent<LevelExit>().setLevelExit();
		}
		cleaned = 0;
	}
	// Update is called once per frame
	void Update () {
		checkCleaned ();
	}
}
