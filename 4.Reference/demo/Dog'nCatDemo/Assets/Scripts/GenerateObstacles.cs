using UnityEngine;
using System.Collections;

public class GenerateObstacles : MonoBehaviour {

	public GameObject crate, coin;
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
			Invoke("CreatecObstacles", Random.Range(0, 1f));
			started = true;
		}
	}

	void CreatecObstacles()
	{
		float x = 11.04f, y = -2.78f, z = -1;
		int tmpN = n;
		n = Random.Range(min, max);
		while(Mathf.Abs(n-tmpN) > 1) {
			n = Random.Range(min, max);
		}

		if(n >= 0) {
			for(int i=0; i<=n; i++) {
				y = -2.78f + i*2f;
				Instantiate(crate, new Vector3(x, y, z), Quaternion.identity);
			}
		}
		y = -2.78f + (n+1)*2f;
		bool isGenCoin = (Random.Range (1,5) > 1);
		if(isGenCoin) {
			Instantiate(coin, new Vector3(x, y, z), Quaternion.identity);
		}

		if(step < maxStep) {
			Invoke ("CreatecObstacles", 0.5f);
		} else {
			step = -1;
			maxStep = Random.Range(2,5);
			Invoke ("CreatecObstacles", 1.5f);
			n = -1;
		}
		step++;
	}
}
