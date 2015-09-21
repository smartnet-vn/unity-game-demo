using UnityEngine;
using System.Collections;

public class Obstacles : MonoBehaviour {

	public Vector2 velocity = new Vector2(-2, 0);
	Rigidbody2D rigid;
	
	// Use this for initialization
	void Start()
	{
		rigid = GetComponent<Rigidbody2D> ();
		rigid.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// OnCollisionEnter2D
	void OnCollisionEnter2D(Collision2D collision)
	{
		switch(collision.gameObject.name) {
		case "Left":
			// Destroy(rigid.gameObject);
			break;
		}
	}
}
