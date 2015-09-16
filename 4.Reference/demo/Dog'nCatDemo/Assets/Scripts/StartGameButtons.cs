using UnityEngine;
using System.Collections;

public class StartGameButtons : MonoBehaviour {
	public GameObject gameObject, one, two, three;
	GameObject[] numArr;

	float timeRemaining = 3;
	bool firstBlood = false;
	bool[] isDetroyed;

	// Use this for initialization
	void Start () {
		numArr = new GameObject[] {three,two, one, gameObject};
		isDetroyed = new bool[] {false, false, false, false};
	}
	
	// Update is called once per frame
	void Update () {
		if(firstBlood) {
			int iTimeRemaining = (int)timeRemaining;
			if(!isDetroyed[iTimeRemaining]) {
				//Debug.Log (iTimeRemaining);
				//Destroy(numArr[iTimeRemaining]);
				//isDetroyed[iTimeRemaining] = true;
				//Instantiate(numArr[iTimeRemaining-1], new Vector3(0,0, -5), Quaternion.identity);
			}

			if(timeRemaining > 0) {
				timeRemaining -= Time.deltaTime;
			} else {
				Debug.Log ("Game Start !");
				//MainController.isStartGame = true;
			}
		}
	}

	// OnMouseDown
	void OnMouseDown() {
		if(!firstBlood) {
			firstBlood = true;
			Destroy(gameObject);
			MainController.isStartGame = true;
		}
	}
}
