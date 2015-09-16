using UnityEngine;
using System.Collections;

public class GenerateCrates : MonoBehaviour {

	public GameObject crates;
	bool started = false;
	int n = -1;
	int min = -1;
	int max = 3;
	int step = 0;
	int maxStep = 3;
	
	// Use this for initialization
	void Start()
	{
	}

	void Update() {
		if((!started) && MainController.isStartGame) {
			Invoke("CreatecCrates", Random.Range(0, 1f));
			started = true;
		}
	}
	
	void CreatecCrates()
	{
		int tmpN = n;
		n = Random.Range(min, max);
		while(Mathf.Abs(n-tmpN) > 1) {
			n = Random.Range(min, max);
		}

		if(n >= 0) {
			for(int i=0; i<=n; i++) {
				float x = 11.04f;
				float y = -2.78f + i*2f;
				float z = -1;
				Instantiate(crates, new Vector3(x, y, z), Quaternion.identity);
				//Instantiate(crates);
			}
		}

		if(step < maxStep) {
			Invoke ("CreatecCrates", 0.5f);
		} else {
			step = -1;
			maxStep = Random.Range(2,5);
			Invoke ("CreatecCrates", 1.5f);
			n = -1;
		}
		step++;
	}
}
