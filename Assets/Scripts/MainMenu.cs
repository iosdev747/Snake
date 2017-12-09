using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	
	public bool isStart;
	public bool isQuit;
	public bool isRetry;
	public bool isMainmenu;
	public bool isEasy;
	public bool isMedium;
	public bool isHard;
	public bool isReset;

	void OnMouseUp(){
		if(isStart)
		{
			SceneManager.LoadScene ("Play");
		}
		if (isQuit)
		{
			Application.Quit();
		}
		if(isMainmenu)
		{
			SceneManager.LoadScene ("MainMenu");
		}
		if(isRetry)
		{
			SceneManager.LoadScene ("Play");
		}
		if (isEasy)
		{
			PlayerPrefs.SetInt ("level", 1);
		}
		if (isMedium)
		{
			PlayerPrefs.SetInt ("level", 2);
		}
		if (isHard)
		{
			PlayerPrefs.SetInt ("level", 3);
		}
		if (isReset) 
		{
			PlayerPrefs.SetInt ("highscore", 0);
		}
	}
}
