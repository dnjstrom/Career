using UnityEngine;
using System.Collections;

public class Player : Entity {

	void Start () {
	
	}

	void Update () {
		/*
		var h = Input.GetAxis("Horizontal");
		var v = Input.GetAxis ("Vertical");
		var xpos = h * speed;
		var ypos = v * speed;

		rigidbody2D.transform.position = new Vector3(xpos, ypos, 0);
		*/

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) 
		{
			rigidbody2D.transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) 
		{
			rigidbody2D.transform.position += Vector3.down * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			rigidbody2D.transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
		{
			rigidbody2D.transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}
}
