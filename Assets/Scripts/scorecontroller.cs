using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scorecontroller : MonoBehaviour {
	public Text ScoreText;
	public Text HighScoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = PlayerPrefs.GetInt ("score").ToString();
		HighScoreText.text = PlayerPrefs.GetInt ("highscore").ToString ();
	}
}
