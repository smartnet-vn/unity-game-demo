using UnityEngine;
using System.Collections;

public class GenerateCrates : MonoBehaviour {

	public GameObject crates;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreatecCrates", 1f, 4f);
	}
	
	void CreatecCrates()
	{
		Instantiate(crates);
	}
}
