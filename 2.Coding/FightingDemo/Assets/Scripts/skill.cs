using UnityEngine;
using System.Collections;

public class skill : MonoBehaviour {

	Rigidbody2D rigid;
	Vector2 velocity = new Vector2(-4f, 0);

	// Use this for initialization
	void Start () {
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
		case "Man":
			Man man = collision.gameObject.GetComponent<Man>();
			man.setInnerHealthBarWidthByPercent(0.3f);
			Destroy(rigid.gameObject);
			break;
		}
	}
}
