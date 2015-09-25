using UnityEngine;
using System.Collections;

public class Man : MonoBehaviour {

	GameObject HealthBar;
	HealthBar HealthBarScript;

	// Use this for initialization
	void Start () {
		HealthBar = transform.FindChild("ManHealthBar").gameObject;
		HealthBarScript = HealthBar.GetComponent<HealthBar>();
		HealthBarScript.setInnerHealthBarWidthByPercent (0.3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
