using UnityEngine;
using System.Collections;

public class Eat : MonoBehaviour {
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("SnakeMain"))
		{
			other.GetComponent<mainMovement>().AddTail();
			Destroy(gameObject);
		}
	}

}
