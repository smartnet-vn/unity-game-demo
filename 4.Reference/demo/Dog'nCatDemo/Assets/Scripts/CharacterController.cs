using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	// Components
	Rigidbody2D rigid;
	Animator anim;

	// idle
	bool isIdle = false;

	// running
	bool isRunning = true;

	// jump
	public float jumpHeight;
	bool startJump = false;
	bool isJumpping = false;
	int jumpLimit = 2;

	// slice
	float sliceTime;
	float sliceSpeed = 0.5f;
	float sliceDistant = 3f;
	bool isSlice = false;

	// Ground
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 1.175947f;
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		Debug.Log ("Character Controller Start !");
		//character = transform.root.gameObject;
		rigid = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		jumpHeight = GetComponent<SpriteRenderer> ().sprite.bounds.size.y * 3f;

		sliceTime = sliceSpeed;
	}

	void FixedUpdate()
	{
		// Normal jump (full speed)
		if (startJump)
		{
			startJump = false;
			rigid.velocity = new Vector2(0, jumpHeight);
			jumpLimit--;
		}
	}
	
	// Update is called once per frame
	void Update() {
		// Controls
		if(MainController.isStartGame) {
			if(isIdle) {
				StartRun();
			}

			if((Input.GetKeyDown(KeyCode.UpArrow) 
			   || Input.GetKeyDown(KeyCode.Space) 
			    || Input.GetMouseButtonDown(0)) && (jumpLimit > 0)) {
				StartJump();
			}

			OnSlice();
		}
	}

	// OnCollisionEnter2D
	void OnCollisionEnter2D(Collision2D collision)
	{
		switch(collision.gameObject.name) {
		case "Dog":
			Die();
			break;
		case "Coin(Clone)":
			StartSlice();
			Destroy(collision.gameObject);
			MainController.score ++;
			break;
		case "Crate(Clone)" :
			//rigid.AddForce(new Vector2(2,0));
			break;
		}

		if(collision.gameObject.layer == 9) {
			//isJumpping = false;
			jumpLimit = 2;
		}
	}

	void StartRun() {
		isIdle = false;
		isRunning = true;
		anim.SetBool ("isIdle", isIdle);
		anim.SetBool ("isRunning", isRunning);
	}

	void StartJump() {
		startJump = true;
		isRunning = false;
		anim.SetBool ("isRunning", isJumpping);
		anim.SetBool ("isRunning", isRunning);
	}

	void OnGround() {
		
	}

	void StartSlice() {
		sliceTime = sliceSpeed;
		isSlice = true;
		isRunning = false;
		anim.SetBool ("isSlice", isSlice);
		anim.SetBool ("isRunning", isRunning);
	}

	void OnSlice() {
		if(isSlice) {
			sliceTime -= Time.deltaTime;
			if(sliceTime > 0) {
				transform.Translate(Vector2.right*sliceDistant*Time.deltaTime);
				transform.eulerAngles = new Vector2(0, 0);
			} else {
				sliceTime = sliceSpeed;
				isSlice = false;
				isRunning = true;
				anim.SetBool ("isSlice", isSlice);
				anim.SetBool ("isRunning", isRunning);
			}
		}
	}

	// Die
	void Die()
	{
		MainController.ResetGame ();
	}
}
