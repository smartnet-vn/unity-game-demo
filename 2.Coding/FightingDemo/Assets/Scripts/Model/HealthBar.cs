using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public GameObject InnerHealthBar;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setInnerHealthBarWidthByPercent(float width) {
		SpriteRenderer sr = InnerHealthBar.GetComponent<SpriteRenderer> ();
		float prevWidth = sr.bounds.size.x;
		sr.transform.localScale = new Vector2(width,1f);
		float curWidth = sr.bounds.size.x;
		float posX = sr.transform.position.x;
		float posY = sr.transform.position.y;
		sr.transform.position = new Vector2 (posX - (prevWidth - curWidth)/2, posY);
	}
}
