using UnityEngine;
using System.Collections;

public class MinimizeAtAwake : MonoBehaviour 
{

	void Awake () 
	{
		transform.localScale = new Vector3(0, 0, 0);
	}
}
