using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("SnakeMain"))
		{
			SceneManager.LoadScene ("gameover");
		}

	}
}
