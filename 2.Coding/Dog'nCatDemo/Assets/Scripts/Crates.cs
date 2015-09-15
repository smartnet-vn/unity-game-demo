using UnityEngine;
using System.Collections;

public class Crates : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4, 0);
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
}
