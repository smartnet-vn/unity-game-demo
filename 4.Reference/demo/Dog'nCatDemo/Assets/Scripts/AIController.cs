using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour {

	// Components
	Rigidbody2D rigid;
	Animator anim;

	// jump
	public Vector2 jumpForce = new Vector2(0, 1.5f);
	bool isJumpping = false;

	// Ground
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 1.175947f;
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		Debug.Log ("Character Controller Start !");
		rigid = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("onGround", grounded);
		anim.SetFloat ("vSpeed", rigid.velocity.y);
	}

	// Update is called once per frame
	void Update() {
	}

	// OnCollisionEnter2D
	void OnCollisionEnter2D(Collision2D collision)
	{
		switch(collision.gameObject.name) {
		case "Crate(Clone)":
			Debug.Log ("Dog: Jumping!!!");

			break;
		case "Coin(Clone)":
			transform.Translate(Vector2.right);
			transform.eulerAngles = new Vector2(0, 0);
			Destroy(collision.gameObject);
			break;
		}
	}
}
