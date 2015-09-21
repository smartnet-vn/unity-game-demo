using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {

	// object
	public static GameObject player;
	public Texture2D startGameTexture;
	public static bool isStartGame = false;
	public static int score = 0;
	public Font defaultFont;
	GUIStyle guiStyle;

	// Use this for initialization
	void Start () {
		guiStyle = new GUIStyle ();
		guiStyle.font = defaultFont;
		guiStyle.normal.textColor = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.GetMouseButtonDown(0) || Input.anyKeyDown) && (!isStartGame)) {
			StartGame();
		}
	}

	public void StartGame() {
		isStartGame = true;
	}

	public static void ResetGame() {
		score = 0;
		Application.LoadLevel(Application.loadedLevel);
		isStartGame = false;
	}

	void OnGUI() {
		if(isStartGame) {
			guiStyle.normal.textColor = Color.black;
			GUI.Label(new Rect(11, 11, 100, 20), "Score: " + score, guiStyle);
			guiStyle.normal.textColor = Color.red;
			GUI.Label(new Rect(10, 10, 100, 20), "Score: " + score, guiStyle);
		} else {
			float ttW = startGameTexture.width/3;
			float ttH = startGameTexture.height/3;
			float ttX = (Screen.width - ttW) / 2;
			float ttY = (Screen.height - ttH) / 3;
			GUI.Label(new Rect(ttX, ttY, ttW, ttW), startGameTexture);
		}
	}
}
