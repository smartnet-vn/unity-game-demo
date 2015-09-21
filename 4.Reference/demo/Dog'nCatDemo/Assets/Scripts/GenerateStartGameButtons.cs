using UnityEngine;
using System.Collections;

public class GenerateStartGameButtons : MonoBehaviour {
	public GameObject startGameButtons;

	// Use this for initialization
	void Start () {
		Instantiate(startGameButtons, new Vector3(0,0, -5), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
