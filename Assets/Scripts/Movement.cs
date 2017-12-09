using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {
	public GameObject tailObj;
	public mainMovement snake;
	public float Speed;
	public Vector3 tail;
	public int temp;
	void Start()
	{
		snake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<mainMovement>();
		Speed = snake.Speed+2.5f;
		tailObj = snake.tail[snake.tail.Count-2];
		temp = snake.tail.IndexOf(gameObject);
	}
	void Update () {
		tail = tailObj.transform.position;
		transform.LookAt(tail);
		transform.position = Vector3.Lerp(transform.position,tail,Time.deltaTime*Speed);
	}
	void OnTriggerEnter(Collider inp)
	{
		if(inp.CompareTag("SnakeMain"))
		{
			if(temp > 2)
			{
				SceneManager.LoadScene ("gameover");			
			}
		}

	}
	
}
