using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public int speed = 4;
    public bool isWalking = false;
    public int rotationOffset = 90;
	public float angle;
	public bool cleanBool = true;

	public bool interact = false;
	public Transform lineStart, lineEnd;
	
	RaycastHit2D interactWith;
    
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
        angle = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;

        rigidbody2D.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle+rotationOffset));
		rayCasting ();


	}

	public void rayCasting()
	{

				lineEnd.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle + rotationOffset));
				Debug.DrawLine (lineStart.position, lineEnd.position, Color.green);
		
				if ((Physics2D.Linecast (lineStart.position, lineEnd.position, 1 << LayerMask.NameToLayer ("Toilet"))) ||
		    (Physics2D.Linecast (lineStart.position, lineEnd.position, 1 << LayerMask.NameToLayer ("Exit")))) {
						interactWith = Physics2D.Linecast (lineStart.position, lineEnd.position, 1 << LayerMask.NameToLayer ("Toilet"));
						interact = true;

				} else {
						interact = false;
				}
				if (Input.GetKey (KeyCode.E) && interact == true) {
						try{
						SpriteSwap swapper = interactWith.collider.gameObject.GetComponent<SpriteSwap> ();
						if (swapper != null) {
								if (cleanBool) {
										swapper.clean ();
										cleanBool = false;
								}
						}
						} catch {}
						try{
						LevelExit le = Physics2D.Linecast (lineStart.position, lineEnd.position, 1 << LayerMask.NameToLayer ("Exit")).collider.gameObject.GetComponent<LevelExit> ();
						if (le != null && le.levelExit) {
								Application.LoadLevel ("Scene_level2");
							}
						} catch {}
				}
				if (Input.GetKey (KeyCode.R) && interact == true) {
						cleanBool = true;
				}
		}
}
