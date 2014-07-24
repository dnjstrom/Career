using UnityEngine;
using System.Collections;

public class Player : Entity {

	public bool interact = false;
	public Transform lineStart, lineEnd;

	RaycastHit2D interactWith;

	void Start () {
	
	}

	public void rayCasting()
	{
		Debug.DrawLine(lineStart.position, lineEnd.position, Color.green);

		if (Physics2D.Linecast (lineStart.position, lineEnd.position, 1 << LayerMask.NameToLayer ("Toilet"))) {
			interactWith = Physics2D.Linecast (lineStart.position, lineEnd.position, 1 << LayerMask.NameToLayer ("Toilet"));
			interact = true;
			Debug.Log ("Test");
		}
		else 
		{
			interact = false;
		}
		if (Input.GetKey (KeyCode.E) && interact == true) 
		{

			//interactWith.collider.gameObject.
			//Destroy (interactWith.collider.gameObject);

			SpriteSwap swapper = interactWith.collider.gameObject.GetComponent<SpriteSwap>();
			if(swapper != null)
			{
				swapper.SetSpriteClean();
			}
		}

	}

	public void movement()
	{
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

	void Update () {
		movement();
		rayCasting();
	}
}
