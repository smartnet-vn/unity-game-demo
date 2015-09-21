using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

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
		Debug.Log ("grounded: " + grounded);
	}

	// Update is called once per frame
	void Update() {
		// Controls
		if(MainController.isStartGame) {
			if(Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
				Debug.Log ("Character is jumping!");
				isJumpping = true;
				anim.SetBool ("onGround", false);
				rigid.velocity = Vector2.zero;
				rigid.AddForce(jumpForce);
			}
		}
	}

	// OnCollisionEnter2D
	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.name == "Dog") {
			Die();
		};
	}

	// Die
	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
		MainController.isStartGame = false;
	}
}
