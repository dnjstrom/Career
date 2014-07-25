using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Skills : MonoBehaviour {

    public Skill fit;

	// Use this for initialization
	void Start () {
        Debug.Log(fit.CalculatePrestige());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
