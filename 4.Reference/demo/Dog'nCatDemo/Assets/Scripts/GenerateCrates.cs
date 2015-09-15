using UnityEngine;
using System.Collections;

public class GenerateCrates : MonoBehaviour {

	public GameObject crates;
	
	// Use this for initialization
	void Start()
	{
		Invoke("CreatecCrates", Random.Range(0, 1f));
	}
	
	void CreatecCrates()
	{
		Instantiate(crates);
		Invoke ("CreatecCrates", Random.Range(1f, 3f));
	}
}
