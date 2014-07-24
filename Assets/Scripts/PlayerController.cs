using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public int speed = 4;
    public bool isWalking = false;
    public int rotationOffset = 90;
    
    Animator animator;

	// Use this for initialization
	void Start () {
        rigidbody2D.transform.Rotate(new Vector3(0, 0, 90));
        animator = this.GetComponent<Animator>();
	}
	
	
	void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, x * speed, 0.4f), Mathf.Lerp(0, y * speed, 0.4f));
        rigidbody2D.velocity = new Vector2(x * speed, y * speed);

        isWalking = rigidbody2D.velocity.sqrMagnitude != 0;
        animator.SetBool("isWalking", isWalking);

        Vector2 mouse = Input.mousePosition;
        Vector2 point = Camera.main.ScreenToWorldPoint(mouse);
        float dx = Camera.main.transform.position.x - point.x;
        float dy = Camera.main.transform.position.y - point.y;
        float angle = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;

        rigidbody2D.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle+rotationOffset));
	}
}
