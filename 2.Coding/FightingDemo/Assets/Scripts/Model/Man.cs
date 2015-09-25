using UnityEngine;
using System.Collections;

public class Man : MonoBehaviour {

	CharacterInfo info;
	GameObject HealthBar;
	HealthBar HealthBarScript;

	// Use this for initialization
	void Start () {
		HealthBar = transform.FindChild("ManHealthBar").gameObject;
		HealthBarScript = HealthBar.GetComponent<HealthBar>();
		//HealthBarScript.setInnerHealthBarWidthByPercent (0.3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setInnerHealthBarWidthByPercent(float width) {
		HealthBarScript.setInnerHealthBarWidthByPercent (width);
	}
}
